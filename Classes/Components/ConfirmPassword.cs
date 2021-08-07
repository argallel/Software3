using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class ConfirmPassword : FormComponent
    {
        public override string getValue()
        {
            Console.WriteLine("Confirm password");
            Console.Write("> ");
            base.value = Console.ReadLine();
            return value;
        }

        public override void print()
        {
            Console.WriteLine("Confirm Password: " + value);
        }

        public override void setValue(string value)
        {
            base.value = value;
        }
    }
}
