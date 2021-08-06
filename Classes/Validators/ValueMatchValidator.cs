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
            if (fc.value != fc2.value)
            {
                Console.WriteLine("Inputs do not match.");
                fc.getValue();
            }
        }
    }
}
