using System;
using System.IO;
using System.Windows.Forms;

namespace MagazzinoConFile
{
    public partial class frmMagazzinoFile : Form
    {
        public frmMagazzinoFile()
        {
            InitializeComponent();
        }
        int nArt; //contiene il numero di articoli presebte nel file
        string lastCodArt = null;  //contiene il codice articolo dell'ultimo articolo inserito
        int nClienti;
        string lastCodCliente = null;  //contiene il codice cliente dell'ultimo cliente inserito
        int nVendite;
        string lastCodVendita=null;  //contiene il codice vendita dell'ultima vendita inserita
        private void frmMagazzinoFile_Load(object sender, EventArgs e)
        {
            //gestione file e dgv per gli articoli
            impostaDgv(dgvArticoli, 7, "Cod_Art Nome_Art Azienda Prezzo Giacenza Scorta Cod_Forn");
            nArt = caricaDaFile(dgvArticoli, 7, "articoli.txt", ref lastCodArt);
            //gestione file e dgv per i clienti
            impostaDgv(dgvClienti, 4, "Cod_Cliente Cognome Nome Città");
            nClienti = caricaDaFile(dgvClienti, 4, "clienti.txt", ref lastCodCliente);
            //gestione file e dgv per le vendite
            impostaDgv(dgvVendite, 5, "Progr Cod_Art Cod_Cliente Qta Data");
            nVendite = caricaDaFile(dgvVendite, 5, "vendite.txt", ref lastCodVendita);
            caricaCombo("fornitori.txt", 3, cmbCodForn);
            caricaCombo("articoli.txt", 7, cmbCodArt);
            caricaCombo("clienti.txt", 4, cmbCodCliente);
            caricaComboConDuplicati("articoli.txt", 7, 2, cmbAziende);
            caricaComboConDuplicati("clienti.txt", 4, 3,cmbCittà);
        }

        private void caricaComboConDuplicati(string nf, int nCampi, int campo, ComboBox cmb)
        {
            //scorro il file articoli.txt e uso un vettore di appoggio per togliere i duplicati
            string[] dato = new string[nCampi];
            string s;
            string[] a = new string[10];  //vettore di appoggio 
            int i=0; //indice del vettore di appoggio a
            int j;  //per la ricerca seq.
            StreamReader sr = new StreamReader(nf);
            cmb.Items.Clear();
            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                dato = s.Split(' ');
                if (i == 0)
                    a[i++] = dato[campo];
                else
                {
                    //ric. seq. sul vettore a
                    j = 0;
                    while ((a[j]!=dato[campo])&&(j!=i-1))
                        j++;
                    if (a[j] != dato[campo])  //se NON l'ho trovato
                        a[i++] = dato[campo];
                }
            }
            sr.Close();
            for (int k = 0; k < i; k++)
                cmb.Items.Add(a[k]);
        }

        private void caricaCombo(string nf, int nCampi, ComboBox cmb)
        {
            string[] dato = new string[nCampi];
            string s;
            StreamReader sr = new StreamReader(nf);
            cmb.Items.Clear();
            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                dato = s.Split(' ');
                cmb.Items.Add(dato[0]);
            }
            sr.Close();
        }

        private int caricaDaFile(DataGridView dgv, int nCampi, string nf, ref string cod)
        {
            StreamReader sr = new StreamReader(nf);
            string s;
            string[] dato = new string[nCampi];
            int nRiga = 0; //indice della riga su cui scrivere sulla dgv
            dgv.Rows.Clear();
            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                dato = s.Split(' ');
                caricaRiga(dgv, dato, nRiga, nCampi);
                nRiga++;
            }
            cod = dato[0];
            sr.Close();
            return nRiga; //ritorno al termine il numero attuale di record nel file
        }

        private void caricaRiga(DataGridView dgv, string[] dato, int nRiga, int nCampi)
        {
            dgv.Rows.Add();
            for (int i = 0; i < nCampi; i++)
                dgv.Rows[nRiga].Cells[i].Value = dato[i];
        }

        private void impostaDgv(DataGridView dgv, int nCampi, string campi)
        {
            string[] v = new string[nCampi];

            dgv.ColumnCount = nCampi;
            v = campi.Split(' ');
            for (int i = 0; i < nCampi; i++)
                dgv.Columns[i].HeaderText = v[i];
            dgv.RowHeadersVisible = false;
            dgv.AutoResizeColumns();
        }

        private void btnInserisciArt_Click(object sender, EventArgs e)
        {
            dgvArticoli.ClearSelection();
            if (clsArticoli.controllaArticolo(lastCodArt, txtCodArt.Text, txtNomeArt.Text, cmbAziende.Text, txtPrezzo.Text, txtGiacenza.Text, txtScorta.Text, cmbCodForn.Text))
            {
                lastCodArt = clsArticoli.inserisciRecord("articoli.txt", txtCodArt.Text, txtNomeArt.Text, cmbAziende.Text, txtPrezzo.Text, txtGiacenza.Text, txtScorta.Text, cmbCodForn.Text);
                string[] dato = new string[7];
                caricaDato(dato, txtCodArt.Text, txtNomeArt.Text, cmbAziende.Text, txtPrezzo.Text, txtGiacenza.Text, txtScorta.Text, cmbCodForn.Text);
                caricaRiga(dgvArticoli, dato, nArt, 7);
                pulisciCampiArticolo();
                dgvArticoli.Rows[nArt].Selected = true;
                //aggiornaCmbArticoli(???, nArt, cmbCodArt);
                nArt++;
                MessageBox.Show("Inserimento effettuato");
            }
        }
        private void pulisciCampiArticolo()
        {
            txtCodArt.Text = "";
            txtNomeArt.Text = "";
            cmbAziende.Text = "";
            txtPrezzo.Text = "";
            txtGiacenza.Text = "";
            txtScorta.Text = "";
            cmbCodForn.Text = "";
        }
        //OVERLOAD DEL METODO
        private void caricaDato(string[] dato, string s1, string s2, string s3, string s4, string s5, string s6, string s7)
        {
            dato[0] = s1;
            dato[1] = s2;
            dato[2] = s3;
            dato[3] = s4;
            dato[4] = s5;
            dato[5] = s6;
            dato[6] = s7;
        }
        //OVERLOAD DEL METODO
        private void caricaDato(string[] dato, string s1, string s2, string s3, string s4)
        {
            dato[0] = s1;
            dato[1] = s2;
            dato[2] = s3;
            dato[3] = s4;
        }
        private void caricaDato(string[] dato, string s1, string s2, string s3, string s4, string s5)
        {
            dato[0] = s1;
            dato[1] = s2;
            dato[2] = s3;
            dato[3] = s4;
            dato[4] = s5;
        }

        private void btnInserisciCliente_Click(object sender, EventArgs e)
        {
            dgvClienti.ClearSelection();
            if (clsClienti.controllaCliente(lastCodCliente, txtCodCliente.Text, txtCognome.Text, txtNome.Text, cmbCittà.Text))
            {
                lastCodCliente = clsClienti.inserisciRecord("clienti.txt", txtCodCliente.Text, txtCognome.Text, txtNome.Text, cmbCittà.Text);
                string[] dato = new string[4];
                caricaDato(dato, txtCodCliente.Text, txtCognome.Text, txtNome.Text, cmbCittà.Text);
                caricaRiga(dgvClienti, dato, nClienti, 4);
                pulisciCampiCliente();
                dgvClienti.Rows[nClienti].Selected = true;
                //aggiornaCmbClienti(???, nClienti, cmbCodCliente);
                nClienti++;
                MessageBox.Show("Inserimento effettuato");
            }
        }
        private void pulisciCampiCliente()
        {
            txtCodCliente.Text = "";
            txtCognome.Text = "";
            txtNome.Text = "";
            cmbCittà.Text = "";
        }
        private void pulisciCampiVendita()
        {
            cmbCodArt.Text = "";
            cmbCodCliente.Text = "";
            nudQta.Value = 1;
        }
        private void btnInserisciVendita_Click(object sender, EventArgs e)
        {
            dgvVendite.ClearSelection();
            if (clsVendite.controllaVendita(cmbCodArt.Text,cmbCodCliente.Text, Convert.ToInt32(nudQta.Value),"articoli.txt"))
            {
                clsVendite.inserisciRecord("vendite.txt", ref lastCodVendita, cmbCodArt.Text, cmbCodCliente.Text, Convert.ToInt32(nudQta.Value));
                string[] dato = new string[5];
                caricaDato(dato, lastCodVendita, cmbCodArt.Text, cmbCodCliente.Text, nudQta.Value.ToString(),DateTime.Now.ToShortDateString());
                caricaRiga(dgvVendite, dato, nVendite, 5);
                pulisciCampiVendita();
                dgvVendite.Rows[nVendite].Selected = true;
                nVendite++;
                MessageBox.Show("Inserimento effettuato");
                //clsArticoli.verificaScorta("articoli,txt", nArt, indArt, "fornitori.txt", dgvArticoli);
            }
        }
    }
}
