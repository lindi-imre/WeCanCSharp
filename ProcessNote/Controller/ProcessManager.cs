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
        private List<SystemProcess> systemProcesses = new List<SystemProcess>();

        public ProcessManager()
        {
            this.systemProcesses = SystemProcesses;
        }

        public List<SystemProcess> SystemProcesses
        {
            get
            {
                Process[] processes = Process.GetProcesses();
                systemProcesses.Clear();
                foreach (Process process in processes)
                {
                    systemProcesses.Add(new SystemProcess(process));
                }
                return systemProcesses;
            }
        }
      
        private SystemProcess ElementFromSystemProcesses(int id)
        {
            foreach (SystemProcess systemProcess in systemProcesses)
            {
                if (systemProcess.Process.Id == id)
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
            ProcessThreadCollection threadsOfProcess = null;
            SystemProcess sysProcess = ElementFromSystemProcesses(id);
            try
            {
                threadsOfProcess = sysProcess.Process.Threads;
                return sysProcess.Process.Threads;
            }
            catch (Exception exp)
            {
                return threadsOfProcess;
            }
        }
    }
}
