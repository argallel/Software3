using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes.Components
{
    public class TextBox : FormComponent
    {
        FormComponent _fc;

        public TextBox(string type)
        {
            switch (type)
            {
                case "Age":
                    _fc = new Age();
                    break;
                case "Confirm Password":
                    _fc = new ConfirmPassword();
                    break;
                case "Password":
                    _fc = new Password();
                    break;
                case "Real Name":
                    _fc = new RealName();
                    break;
                case "Email":
                    _fc = new Email();
                    break;
                case "Username":
                    _fc = new Username();
                    break;
            }
        }

        public override void getValue()
        {
            throw new NotImplementedException();
        }

        public override void print()
        {
            throw new NotImplementedException();
        }

        public override void setValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
