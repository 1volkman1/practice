using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class ScaryScary:FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings;
        public string ScaryThingIHave {
            get { return "У меня " + numberOfScaryThings + " пауков"; }
            }
        public void ScareLittleChildren()
        {
            MessageBox.Show("Ага! Попался!");
        }
    }
}
