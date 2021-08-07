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
            fc.value = fc.getValue();
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
            if (fc.value != fc2.value)
            {
                Console.WriteLine("Inputs do not match.");
                value = fc.getValue();
            }
        }
    }
}
