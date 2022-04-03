using System;
using System.Collections.Generic;
using System.Text;

namespace Connect_Four
{
    class Command
    {
        public void Execute();

        public void Undo();

        public void Redo();
    }
}
