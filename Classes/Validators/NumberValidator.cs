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
            do { value = fc.getValue();
            } while (!validate());

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

        public bool validate()
        {
            if(!int.TryParse(value, out _))
            {
                Console.WriteLine("Input is not a valid integer.");
                return false;
            }
            return true;
        }
    }
}
