﻿using System;

namespace Matching.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }
        public ContactInfo ContactInfo { get; set; }



    }
}