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

        public override string getValue()
        {
            value = fc.getValue();
            validate();
            return value;
        }

        public override void print()
        {
            fc.print();
        }

        public override void setValue(string value)
        {
            fc.setValue(value);
        }

        public void validate()
        {
            if(!Int32.TryParse(value, out int x))
            {
                Console.WriteLine("Input is not a valid integer.");
                fc.getValue();
            }
        }
    }
}
