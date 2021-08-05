using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Validators
{
    public class CharacterValidator : FormComponent
    {
        FormComponent fc;
        string c;

        public CharacterValidator(FormComponent fc, string c)
        {
            this.fc = fc;
            this.c = c;
        }

        public override void getValue()
        {
            fc.getValue();
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
            if (!fc.value.Contains(c))
            {
                Console.WriteLine("Input does not contain " + c);
                fc.getValue();
            }
        }
    }
}
