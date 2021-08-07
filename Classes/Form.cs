using Assi3.Classes;
using Assi3.Classes.Components;
using Assi3.Classes.States;
using System;
using System.Collections.Generic;

namespace Assi3 {
    public class Form {

        public IState formState;

        public List<FormComponent> components;

        public Form()
        {
            components = new List<FormComponent>();
            ChangeState(new EnterState(this));
        }

        public void ChangeState(IState state)
        {
            formState = state;
        }

        public void AddComponent(FormComponent fc)
        {
            components.Add(fc);
        }

        public void PrintForm()
        {
            Console.WriteLine();
            foreach(FormComponent comps in components)
            {
                comps.print();
            }
            Console.WriteLine();
        }
    }
}
