using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class FunnyFunny: IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIhave
        {
            get { return "BEE-BEE! I have ...." + funnyThingIHave; }
        }
        public void Honk()
        {
            MessageBox.Show(this.funnyThingIHave);
        }
    }
}
