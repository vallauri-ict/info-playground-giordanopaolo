using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Uso_delle_liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Libro
        {
            public int ID;
            public string Autore;
            public string Titolo;
        }
        List<Libro> MiaLista = new List<Libro>();
        List<object> listobj = new List<object>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Libro l;
            l.ID = Convert.ToInt32(TxtID.Text);
            l.Autore = txtAutore.Text;
            l.Titolo = txtTitolo.Text;
            MiaLista.Add(l);
        }
        private void btnaddobj_Click(object sender, EventArgs e)
        {
            object l = TxtID.Text;
            listobj.Add(l);
        }
        private void btnviusalizza_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach(var elemento in MiaLista)
                MessageBox.Show("Elemento numero : " + (i++) + "\t" + elemento.Titolo);
        }
        private void btnvisualizzaobj_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var elemento in listobj)
                MessageBox.Show("Elemento numero : " + (i++) + "\t" + elemento);
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            Libro ris = MiaLista.Find(x => x.Titolo == txtfind.Text);
            MessageBox.Show(ris.Autore+" "+ris.ID);
        }
        private void btn_click(object sender, EventArgs e)
        {
            List<Libro> titoli = new List<Libro>();
            titoli = MiaLista.FindAll(x => x.Autore == txtfind.Text);
            foreach (var item in titoli)
                MessageBox.Show(item.Titolo);
            
        }

    }
}
