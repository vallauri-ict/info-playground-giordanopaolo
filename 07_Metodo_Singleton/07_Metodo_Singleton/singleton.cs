using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Metodo_Singleton
{
    class singleton
    {
        public int val = 0;
        private static singleton instance = null;

        private singleton()
        {

        }

        private singleton(int val)
        {
            this.val = val;
        }
        public static singleton Getsingleton(int valore)
        {
            if (instance == null)
                instance = new singleton(valore);
            else instance.val = valore;
            return instance;
        }
    }
}
