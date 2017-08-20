using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsForms
{
    class ClickingEventArgs : EventArgs
    {

        public ClickingEventArgs(bool isClicked)
        {
            IsClicked = isClicked;
        }

        public bool IsClicked { get; private set; }
    }
}
