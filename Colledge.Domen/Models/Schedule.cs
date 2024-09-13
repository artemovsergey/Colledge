using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Domen.Models
{
    public class Schedule : Base
    {
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
        public Group Group { get; set; }

        public int NumberWeek { get; set; }
        public int NumberPair { get; set; }
        public int NumberDay { get; set; }

    }
}
