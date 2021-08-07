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
            if (!value.Contains(c))
            {
                Console.WriteLine("Input does not contain " + c);
                fc.getValue();
            }
        }
    }
}
