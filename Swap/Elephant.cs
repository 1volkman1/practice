using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoIAm()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tail.", Name + " says ...");
        }

        public void TellMe(string message, Elephant WhoSaidIt)
        {
            MessageBox.Show(WhoSaidIt.Name + " says: " + message);
        }
        public void SpeakTo(Elephant WhoTolkMe,string message)
        {
            WhoTolkMe.TellMe(message, this);
        }

    }
}
