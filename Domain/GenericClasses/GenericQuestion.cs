using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.GenericClasses
{
    public class GenericQuestion
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public List<Option> Options { get; set; }


        // Done by the automated makring process which happens ALWAYS
        public bool AutoMarkedCorrect { get; set; }
    }
}
