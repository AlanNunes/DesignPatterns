using Student.NotificationPattern.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.NotificationPattern.Entities
{
    public class Student
    {
        public Student(Name name, Email email)
        {
            Name = name;
            Email = email;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
    }
}
