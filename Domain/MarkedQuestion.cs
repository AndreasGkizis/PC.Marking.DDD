using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.GenericClasses;

namespace Domain
{
    public class MarkedQuestion: GenericQuestion
    {
        /// <summary>
        /// This is a Dictionary that will hold all the markings done to date by Markers
        /// the string part would be the ID? of each marker and the 
        /// bool would be whether it is considered correct,
        /// That way if it is marked by more than one people the last user
        /// can see what the previous ones have marked
        /// </summary>
        public Dictionary<string, bool> MarkerMarked { get; set; }
    }
}
