using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote.Model
{
    public class SystemProcess: Process
    {
        private string comment;

        public SystemProcess()
        {
            Comment = "";
        }

        public string Comment
        {
            get
            {
                return comment;
            }

            set
            {
                comment = value;
            }
        }
    }
}
