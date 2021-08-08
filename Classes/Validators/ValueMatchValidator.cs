using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Validators
{
    public class ValueMatchValidator : FormComponent
    {
        FormComponent fc;
        FormComponent fc2;

        public ValueMatchValidator(FormComponent fc, FormComponent fc2)
        {
            this.fc = fc;
            this.fc2 = fc2;
        }

        public override string getValue()
        {
            do { fc.value = fc.getValue();
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
            if (fc.value != fc2.value)
            {
                Console.WriteLine("Inputs do not match.");
                return false;
            }
            return true;
        }
    }
}
