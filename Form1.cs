using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Lumberjacks_Eat_Flapjacks
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> breakfastLine;
        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
            RedrawList();
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack newLumberjack = new Lumberjack(lumberjackName.Text);
            breakfastLine.Enqueue(newLumberjack);
            RedrawList();
        }

        private void RedrawList()
        {
            int counter = 1;
            breakfastLineText.Text = "";
            foreach (Lumberjack currentLumberjack in breakfastLine)
            {
                breakfastLineText.Text += $"{counter}-. {currentLumberjack.Name} \r\n";
                counter++;
            }
            if(breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack firstLumberjack = breakfastLine.Peek();
                nextInLine.Text = $"{firstLumberjack.Name} has {firstLumberjack.FlapjackCount} flapjacks";
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Lumberjack firstLumberjack = breakfastLine.Peek();
            Flapjack food;
            if (crispy.Checked)
            {
                food = Flapjack.crispy;
            } else if (soggy.Checked) {
                food = Flapjack.soggy;
            } else if (browned.Checked) {
                food = Flapjack.browned;
            }else
            {
                food = Flapjack.banana;
            }
            firstLumberjack.TakeFlapjacks(food, (int)numberFlapjacks.Value);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack firstLumberjack = breakfastLine.Dequeue();
            firstLumberjack.EatFlapjacks();
            RedrawList();
        }
    }
}
