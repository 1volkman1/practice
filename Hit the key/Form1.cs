using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hit_the_key
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        stats stats = new stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //добавим случайную клавишу в listbox1
            listBox1.Items.Add((Keys)random.Next(65, 90));

            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over!!!");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                //Если пользователь правильно нажимает, клавишу удалить ее из ListBox1
                //и увеличить скорость появления букв
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;

                difficultyProgressBar.Value = 800 - timer1.Interval;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            //Обновляем элементы StatusStrip
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = " Missed: " + stats.MIssed;
            accuracyLabel.Text = " Accuracy: " + stats.Accuracy + "%";
            totalLabel.Text = " Total: " + stats.Total;
        }
    }
}
