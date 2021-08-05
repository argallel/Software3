using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class Age : FormComponent
    {
        public override void getValue()
        {
            Console.WriteLine("Enter age");
            Console.Write("> ");
            base.value = Console.ReadLine();
        }

        public override void print()
        {
            Console.WriteLine("Age: " + value);
        }

        public override void setValue(string value)
        {
            base.value = value;
        }
    }
}
