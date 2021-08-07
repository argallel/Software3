using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.States
{
    class DoneState : IState
    {
        public DoneState(Form fc) : base(fc) { }
        override public void Run(Form form)
        {
            Console.WriteLine("\nEnter 'print' to print form, 'reset' to reset the form, or 'exit' to finish");
            bool flag = true;
            
            while (flag)
            {
                Console.Write(">");
                switch (Console.ReadLine().ToLower())
                {
                    case "print":
                        form.PrintForm();
                        break;
                    case "reset":
                        flag = false;
                        break;
                    case "exit":
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.\n");
                        break;
                }
            }

            new StateContext().Run(form);
        }
    }
}
