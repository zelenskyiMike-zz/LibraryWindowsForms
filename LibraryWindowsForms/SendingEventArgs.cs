using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsForms
{
    class SendingEventArgs : EventArgs
    {

        public SendingEventArgs(bool isAdded)
        {
            IsAdded = isAdded;
        }

        public bool IsAdded { get; private set; }
    }
}
