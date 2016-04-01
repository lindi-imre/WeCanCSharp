using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using ProcessNote.Model;
using System.Threading;

namespace ProcessNote.View
{
    public partial class ThreadsForm : Form
    {
        public ThreadsForm(Process[] selectedThreadsOfProcess)
        {
            InitializeComponent();
            foreach(Process thread in selectedThreadsOfProcess)
            {
                string name = thread.ProcessName;
                string pid = thread.Id.ToString();
                resultDataGridView.Rows.Add(name, pid);
            }
            numberOfTreadsTextBox.Text = selectedThreadsOfProcess.Length.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
