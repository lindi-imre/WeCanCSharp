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
        public List<SystemProcess> GetProcessesFromSystem()
        {
            List<SystemProcess> resultList = new List<SystemProcess>();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                resultList.Add((SystemProcess) process);
            }
            return resultList;
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
