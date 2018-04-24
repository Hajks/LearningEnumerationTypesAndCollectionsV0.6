using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV0._6
{
    public partial class Form1 : Form // It was simple task, to arrange code in the right order. Code isn't readable at all, it's not my fault, i've used what was given. Task from page 399, from "Head first C#". 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();

            string zilch = "zero";
            string first = "jeden";
            string second = "dwa";
            string third = "trzy";
            string fourth = "4.2";
            string twopointwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            if(a.Contains("trzy"))
            {
                a.Add("cztery");
            }
            if(a.IndexOf("Cztery") != 4)
            {
                a.Add(fourth);
            }
            a.RemoveAt(2);
            if(a.Contains("dwa"))
            {
                a.Add(twopointwo);
            }
            printL(a);
        }
        private void printL(List<string> a)
        {
            string result = "";
            foreach (string element in a)
            {
                result += "\n" + element;
            }
            MessageBox.Show(result);
        }

    }
}
