using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_kg
{
    public partial class form_fraktal : Form
    {
        Graphics g;
        string axiom;
        double angle;
        string direction;
        int iterations;
        SortedDictionary<char, string> rules;
        Stack<Tuple<double, double, double, double>> savedStates;
        double re, gree, wi;
        Random rand = new Random();


        public form_fraktal()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            rules = new SortedDictionary<char, string>();
            savedStates = new Stack<Tuple<double, double, double, double>>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files|*.TXT";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fname = openDialog.FileName;
                    string[] flines = File.ReadAllLines(fname);
                    string[] parameters = flines[0].Split(' ');

                    axiom = parameters[0];
                    angle = Convert.ToDouble(parameters[1]);
                    direction = parameters[2];

                    rules.Clear();
                    string[] rule;
                    for (int i = 1; i < flines.Length; ++i)
                    {
                        rule = flines[i].Split('>');
                        rules[Convert.ToChar(rule[0])] = rule[1];
                    }
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Не удается открыть файл.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
