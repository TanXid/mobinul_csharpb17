using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {

        private string lockStatus;
        public string LockStatus
        {
            get { return lockStatus; }
            set
            {
                if (value == "Open" || value == "Close")
                {
                    lockStatus = value;
                }
                else
                {
                    throw new ArgumentException("LockStatus must be either 'Open' or 'Close'");
                }
            }
        }
    }
}
