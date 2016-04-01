using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProcessNote.Controller;
using ProcessNote.Model;
using System.Diagnostics;
using ProcessNote.View;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        List<SystemProcess> systemProcesses;
        ProcessManager processManager;
        private bool isSavedComment = false;
        private bool commentIsChanged = false;
        private string comment;
        private int previousIndex = -1;

        public Form1()
        {
            InitializeComponent();
            processManager = new ProcessManager();
            FillProcessesToListBox();
        }

        private void FillProcessesToListBox()
        {
            resultListBox.Items.Clear();
            systemProcesses = processManager.SystemProcesses;
            string processData;
            foreach (SystemProcess item in systemProcesses)
            {
                processData = string.Format("{0} [{1}]", item.Process.ProcessName, item.Process.Id);
                resultListBox.Items.Add(processData);
            }
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = resultListBox.SelectedIndex;
            SystemProcess selectedProcess = systemProcesses[index];
            try
            {
                nameTextBox.Text = selectedProcess.Process.ProcessName;
                PIDTextBox.Text = selectedProcess.Process.Id.ToString();
                PerformanceCounter performanceCounter = new PerformanceCounter("Process", "% Processor Time", selectedProcess.Process.ProcessName);
                performanceCounter.NextValue();
                System.Threading.Thread.Sleep(1000);
                CPUTextBox.Text = performanceCounter.NextValue().ToString();
                memoryTextBox.Text = (selectedProcess.Process.WorkingSet64 / 1024 / 1024).ToString();
                runningTimeTextBox.Text = (DateTime.Now - selectedProcess.Process.StartTime).TotalSeconds.ToString();
                startTimeTextBox.Text = selectedProcess.Process.StartTime.ToString();
                if (!commentIsChanged)
                {
                    commentRichTextBox.Text = selectedProcess.Comment;
                }
                else
                {
                    MessageBox.Show("Please save the comment!");
                    resultListBox.SelectedIndex = previousIndex;
                }
                previousIndex = index;
            }
            catch(Exception exp)
            {
               MessageBox.Show("You have no permission to access the execution this process");
            }
        }

        private bool isSelectedProcess()
        {
            int index = resultListBox.SelectedIndex;
            return resultListBox.SelectedIndex != -1;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillProcessesToListBox();
        }

        private void saveCommentButton_Click(object sender, EventArgs e)
        {
            if (isSelectedProcess())
            {
                int index = resultListBox.SelectedIndex;
                SystemProcess selectedProcess = systemProcesses[index];
                selectedProcess.Comment = commentRichTextBox.Text;
                commentIsChanged = false;
            }
            else
            {
                MessageBox.Show("Select a process first!");
            }
        }

        private void threadsButton_Click(object sender, EventArgs e)
        {
            if (isSelectedProcess())
            {
                int index = resultListBox.SelectedIndex;
                SystemProcess selectedProcess = systemProcesses[index];
                string selectedProcessName = selectedProcess.Process.ProcessName;
                Process[] selectedThreadsOfProcess = processManager.GetThreadsInfo(selectedProcessName, selectedProcess.Process.Id);
                if (selectedThreadsOfProcess != null)
                {
                    ThreadsForm threadsForm = new ThreadsForm(selectedThreadsOfProcess);
                    threadsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(string.Format("Select a process first!"));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keepOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void commentRichTextBox_TextChanged(object sender, EventArgs e)
        {
            commentIsChanged = true;
            comment = commentRichTextBox.Text;
        }

        //private void resultListBox_DoubleClick(object sender, EventArgs e)
        //{
        //    resultListBox_SelectedIndexChanged(sender, e);
        //}
    }
}
