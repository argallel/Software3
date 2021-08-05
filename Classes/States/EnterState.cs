using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.States
{
    class EnterState : IState
    {
        public EnterState(FormComponent fc) : base(fc) { }
        public void Run()
        {
            Console.WriteLine("Run in enter state");
        }
    }
}
