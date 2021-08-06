using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.States
{
    class EnterState : IState
    {
        public EnterState(Form fc) : base(fc) { }

        override public void Run(Form form)
        {
            //user input goes here
            foreach ( FormComponent comp in form.components) {
                comp.getValue();
            }
        }
    }
}
