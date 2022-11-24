using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool JePrvocislo(int cislo)
        {
            bool jePrvocislo = true;
            if(cislo==0)
            {
                jePrvocislo = false;
            }
            else if(cislo>=3)
            {
                for (int i = 2; i < cislo/2&&jePrvocislo; i++)
                {
                    if(cislo%i==0)
                    {
                        jePrvocislo=false;
                    }
                }
            }
            return jePrvocislo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<int> list = new List<int>();
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(1,101));
                listBox1.Items.Add(list[i]);
                if (JePrvocislo(list[i]))
                {
                    listBox2.Items.Add(list[i]);
                }
            }
        }
    }
}
