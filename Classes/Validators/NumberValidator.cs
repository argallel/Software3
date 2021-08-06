using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Validators
{
    public class NumberValidator : FormComponent
    {
        FormComponent fc;

        public NumberValidator(FormComponent fc)
        {
            this.fc = fc;
        }

        public override void getValue()
        {
            fc.getValue();
            validate();
        }

        public override void print()
        {
            fc.print();
            Console.WriteLine("With a number validator");
        }

        public override void setValue(string value)
        {
            fc.setValue(value);
        }

        public void validate()
        {
            if(!Int32.TryParse(fc.value, out int x))
            {
                Console.WriteLine("Input is not a valid integer.");
                fc.getValue();
            }
        }
    }
}
