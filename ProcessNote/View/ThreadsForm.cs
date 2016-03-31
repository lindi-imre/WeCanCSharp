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
        public ThreadsForm(ProcessThreadCollection selectedThreadsOfProcess)
        {
            InitializeComponent();
            List<string> resultList = new List<string>();
            foreach (Thread thread in selectedThreadsOfProcess)
            {
                string name = thread.Name;
                resultList.Add(name);
            }

            foreach (ProcessThread processThread in selectedThreadsOfProcess)
            {
                string pid = processThread.Id.ToString();
                //string cpu = processThread.TotalProcessorTime.ToString();
                //string runtime = (DateTime.Now.Second - processThread.StartTime.Second).ToString();
                //string stratTime = processThread.StartTime.Second.ToString();
                resultList.Add(pid);
                //resultList.Add(cpu);
                //resultList.Add(runtime);
                //resultList.Add(stratTime);
                //resultDataGridView.Rows.Add();
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
