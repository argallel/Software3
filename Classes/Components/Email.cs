using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class Email : FormComponent
    {
        public override void getValue()
        {
            Console.WriteLine("Enter Email");
            Console.Write("> ");
            base.value = Console.ReadLine();
        }

        public override void print()
        {
            Console.WriteLine("Email: " + value);
        }

        public override void setValue(string value)
        {
            base.value = value;
        }
    }
}
