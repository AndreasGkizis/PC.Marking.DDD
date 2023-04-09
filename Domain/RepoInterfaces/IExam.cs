using Domain.ExamDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces
{
    internal interface IExam
    {
        /// <summary>
        /// Gets all the exams to be marked for a specific marker
        /// </summary>
        /// <returns></returns>
        List<UnmarkedExamDTO> GetUnmarkedExamList();

        /// <summary>
        /// Get all already marked but assigned for remarking Exams
        /// </summary>
        /// <returns></returns>
        List<MarkedExamDTO> GetReMarkExamList();

        /// <summary>
        /// Sends a list of marked exams 
        /// </summary>
        /// <returns></returns>
        List<MarkedExamDTO> SendMarkedExam();
    }
}
