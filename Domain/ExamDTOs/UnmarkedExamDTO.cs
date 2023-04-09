using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.GenericClasses;

namespace Domain.ExamDTOs
{
    public class UnmarkedExamDTO : GenericExam
    {
        public DateTime DateAssigned { get; set; }
        public List<GenericQuestion> Questions { get; set; }
    }
}
