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
      
        private SystemProcess ElementFromSystemProcesses(int id)
        {
            foreach (SystemProcess systemProcess in systemProcesses)
            {
                if (systemProcess.Id == id)
                {
                    return systemProcess;
                }
            }
            return null;
        }

        public SystemProcess GetProcessInfo(int id)
        {
            return ElementFromSystemProcesses(id);
        }

        public ProcessThreadCollection GetThreadsInfo(int id)
        {
            SystemProcess sysProcess = ElementFromSystemProcesses(id);
            return sysProcess.Threads;
        }
    }
}
