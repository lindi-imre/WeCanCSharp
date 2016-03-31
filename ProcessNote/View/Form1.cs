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
            nameTextBox.Text = selectedProcess.Process.ProcessName;
            PIDTextBox.Text = selectedProcess.Process.Id.ToString();
            //CPUTextBox.Text = selectedProcess.Process.TotalProcessorTime.ToString();
            memoryTextBox.Text = (selectedProcess.Process.WorkingSet / 1024 / 1024).ToString();
            //runningTimeTextBox.Text = (DateTime.Now.Second - selectedProcess.Process.StartTime.Second).ToString();
            //startTimeTextBox.Text = selectedProcess.Process.StartTime.Second.ToString();
            if (commentRichTextBox.Text != selectedProcess.Comment)
            {
                MessageBox.Show("Please save the comment!");
                resultListBox.SetSelected(index, false);
            }
            commentRichTextBox.Text = selectedProcess.Comment;
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
            int index = resultListBox.SelectedIndex;
            if (isSelectedProcess())
            {
                SystemProcess selectedProcess = systemProcesses[index];
                selectedProcess.Comment = commentRichTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please select a process first!");
            }
        }

        private void threadsButton_Click(object sender, EventArgs e)
        {
            int index = resultListBox.SelectedIndex;
            SystemProcess selectedProcess = systemProcesses[index];
            ProcessThreadCollection selectedThreadsOfProcess = processManager.GetThreadsInfo(index);
            if (isSelectedProcess() && selectedThreadsOfProcess != null)
            {
                ThreadsForm threadsForm = new ThreadsForm(selectedThreadsOfProcess);
                threadsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(string.Format("{0} [{1}] have not got any threads.", selectedProcess.Process.ProcessName, selectedProcess.Process.Id));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
