using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StateMethodDesignPattern
{
    public class DraftState : IState
    {
        public void Handle()
        {
            Console.WriteLine("Document is in Draft state. Editing is allowed");
        }
    }
}
