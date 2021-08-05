using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class RealName : FormComponent
    {
        public override void getValue()
        {
            Console.WriteLine("Enter real name");
            Console.Write("> ");
            base.value = Console.ReadLine();
        }

        public override void print()
        {
            Console.WriteLine("Real Name: " + value);
        }

        public override void setValue(string value)
        {
            base.value = value;
        }
    }
}
