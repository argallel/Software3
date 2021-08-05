using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class Password : FormComponent
    {
        public override void getValue()
        {
            Console.WriteLine("Enter password");
            Console.Write("> ");
            base.value = Console.ReadLine();
        }

        public override void print()
        {
            Console.WriteLine("Password: " + value);
        }

        public override void setValue(string value)
        {
            base.value = value;
        }
    }
}
