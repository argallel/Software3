using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class Username : FormComponent
    {
        public override string getValue()
        {
            Console.WriteLine("Enter username");
            Console.Write("> ");
            base.value = Console.ReadLine();
            return value;
        }

        public override void print()
        {
            Console.WriteLine("Username: " + value);
        }

        public override void setValue(string value)
        {
            base.value = value;
        }
    }
}
