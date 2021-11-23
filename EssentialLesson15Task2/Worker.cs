using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson15Task1
{
    struct Worker
    {
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public int? Year { get; set; }

        public override string ToString()
        {
            return $"Lastname {LastName}, JobTitle {JobTitle}, Year {Year}";
        }
    }
}
