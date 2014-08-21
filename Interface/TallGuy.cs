using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class TallGuy: IClown
    {
        public string Name;
        public int Heigth;
        public void TalkAboutYourself()
        {
            MessageBox.Show("Меня зовут  " + Name + " я ростом " + Heigth + " см.");
        }

        public string FunnyThingIHave
        {
            get { return "большие ботинки"; }
        }
        public void Honk()
        {
            MessageBox.Show(" BEE-BEE!!");
        }
    }
}
