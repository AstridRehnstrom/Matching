﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matching.Domain
{
    public class Education
    {
        public int Id { get; set; }
        public EducationType EducationType { get; set; }
        public Person Person { get; set; }

    }
}
