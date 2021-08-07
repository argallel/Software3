using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Validators
{
    public class MinLengthValidator : FormComponent
    {
        FormComponent fc;
        int length;

        public MinLengthValidator(FormComponent fc, int length)
        {
            this.fc = fc;
            this.length = length;
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
            if (value.Length < length)
            {
                Console.WriteLine("Input is not long enough. Must be at least " + length + " characters.");
                value = fc.getValue();
            }
        }
    }
}
