using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.States
{
    class DoneState : IState
    {
        public DoneState(FormComponent fc) : base(fc) { }
        public void Run()
        {
            Console.WriteLine("Run in done state");
        }
    }
}
