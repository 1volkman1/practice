using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hit_the_key
{
    class stats
    {
        public int Total = 0;
        public int MIssed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctkey)
        {
            Total++;

            if (!correctkey)
            {
                MIssed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (MIssed + Correct);
        }
    }
}
