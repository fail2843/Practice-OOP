using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public static class MyListExtensions
    {
        public static int SampleCount(this List<int> list, int sample)
        {
            int count = 0;
            foreach (int i in list)
                if (i == sample) count++;
            return count;
        }
    }
}
