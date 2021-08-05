using Assi3.Classes;
using Assi3.Classes.Components;
using System;
using System.Collections.Generic;

namespace Assi3 {
    public class Form {
        Username username;
        Email email;
        RealName realName;
        Password password;
        ConfirmPassword confirmPassword;
        Age age;

        List<FormComponent> components;

        public Form()
        {
            components = new List<FormComponent>();
            username = new Username();
            email = new Email();
            realName = new RealName();
            password = new Password();
            confirmPassword = new ConfirmPassword();
            age = new Age();
        }

        public void AddComponent(FormComponent fc)
        {
            components.Add(fc);
        }
    }
}
