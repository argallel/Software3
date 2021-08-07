using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3.Classes
{
    public abstract class FormComponent
    {
        public string value;
        public abstract void setValue(string value);
        public abstract string getValue();
        public abstract void print();
    }
}
