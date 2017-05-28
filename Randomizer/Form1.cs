using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Randomizer
{
    public partial class Form1 : Form
    {
        public static List<string> stringsToRandomize = new List<string>();
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            foreach(RichTextBox rtb in this.Controls.OfType<RichTextBox>())
            {
                stringsToRandomize.Add(rtb.Text);
            }

            stringsToRandomize.Shuffle();
            textBox1.Text = "";
            foreach(string str in stringsToRandomize)
            {
                if (string.IsNullOrEmpty(str))
                {
                    
                }
                else { textBox1.Text = textBox1.Text + str.ToUpper() + "    "; }
                }
            stringsToRandomize.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(RichTextBox rtb in this.Controls.OfType<RichTextBox>())
            {
                rtb.Text = "";
            }
        }
    }

    /// <summary>
    /// The following function makes use of the Fisher-Yates algorithm for shuffling. An extension method is implemented for this list.
    /// </summary>

    public static class Randomizer
    {
        public static Random rand = new Random();
        
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count; // Starts counter at 15
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                /* Swaps temporary variable with current index */
                T temp = list[k]; 
                list[k] = list[n];
                list[n] = temp;
            }
        }

    }
}
