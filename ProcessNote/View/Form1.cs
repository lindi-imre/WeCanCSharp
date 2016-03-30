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

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProcessManager procManager = new ProcessManager();
            List<SystemProcess> sysProcesses = procManager.SystemProcesses;

            foreach (SystemProcess item in sysProcesses)
            {
                resultListBox.Items.Add(item);
            }
        }
    }
}
