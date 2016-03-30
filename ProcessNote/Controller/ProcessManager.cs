using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using ProcessNote.Model;

namespace ProcessNote.Controller
{
    class ProcessManager
    {
        private List<SystemProcess> systemProcesses;


        public ProcessManager()
        {
            this.systemProcesses = SystemProcesses;
        }
        public List<SystemProcess> SystemProcesses
        {
            get
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    systemProcesses.Add((SystemProcess)process);
                }
                return systemProcesses;
            }
        }
      
        public SystemProcess GetProcessInfo(int id)
        {
            return null;
        }

        public ProcessThreadCollection GetThreadsInfo(int id)
        {
            return null;
        }
    }
}
