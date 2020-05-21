using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Model
{
    class Week
    {
        public int Index { get; set; }
        public IEnumerable<Day> Days { get; set; }
    }
}
