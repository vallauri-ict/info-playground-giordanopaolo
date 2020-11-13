using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace _11_esvalidazione
{
    class Utenti
    {
        private static Utenti instance = null;
        private Utenti()
        {
           
        }
        public static Utenti Getsingleton()
        {
            if (instance == null)
                instance = new Utenti();
            return instance;
        }
        public static void ToString(string cognome, string nome, string mail, 
                                    string cap, string indirizzo, string città, 
                                    string codicefiscale, string user, string password)
        {
            string s;
            if (!presente(user))
            {
                StreamWriter sw = new StreamWriter("utenti.txt", true);
                s = cognome + " " + nome + " " + mail + " " + cap + " " + indirizzo + " " + città + " " + codicefiscale + " " + user + " " + password;
                sw.WriteLine(s);
                sw.Close();
            }
        }

        private static bool presente(string user)
        {
            StreamReader sr = new StreamReader("utenti.txt");
            bool presente = false;
            string[] tutto = new string[9];
            while(sr.Peek()!=-1)
            {
                string s = sr.ReadLine();
                tutto = s.Split(' ');
                if(tutto[7] == user)
                {
                    System.Windows.Forms.MessageBox.Show("nome utente non disponibile sceglierne un altro");
                    presente = true;
                }    

            }
            sr.Close();
            return presente;
        }
    }
}
