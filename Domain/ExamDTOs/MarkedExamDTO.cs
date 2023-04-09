using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.GenericClasses;

namespace Domain.ExamDTOs
{
    public class MarkedExamDTO : GenericExam
    {
        public DateTime MarkingDate { get; set; }
        public List<MarkedQuestion> Questions { get; set; }
    }
}
