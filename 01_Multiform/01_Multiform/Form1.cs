﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Multiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "sciao belo";
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 formtextbox = new Form2(textBox1);
            formtextbox.Text = "si";
            formtextbox.Show();





            FormFiglia form = new FormFiglia();
            this.AddOwnedForm(form);//congratulazione è appena nata un form femmina
            form.Show();
        }
    }
}
