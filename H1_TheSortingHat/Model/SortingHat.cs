using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheSortingHat.Model
{
    /// <summary>
    /// Class <see cref="SortingHat"/> has different colleges and makes it possible to fetch them
    /// </summary>
    internal class SortingHat
    {
        public enum Colleges
        {
            Gryffindor = 1,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }

        /// <summary>
        /// Gets a college by id
        /// </summary>
        /// <param name="collegeID">id of college</param>
        /// <returns>The college by id</returns>
        public Colleges GetCollege(byte collegeID)
        {
            return (Colleges)collegeID;
        }
    }
}
