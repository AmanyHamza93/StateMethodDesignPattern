﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StateMethodDesignPattern
{
    public class ReviewState : IState
    {
        public void Handle()
        {
            Console.WriteLine("Document is in Review state. Editing is restricted");
        }
    }
}