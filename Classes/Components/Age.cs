using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    class Age : FormComponent
    {
        public override string getValue()
        {
            Console.WriteLine("Enter age");
            Console.Write("> ");
            base.value = Console.ReadLine();
            return base.value;
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
