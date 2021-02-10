using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Interfacce
{
    class MyComponent : IDInterfacce
    {
        #region interfaccia
        private int _id;
        private bool _status;
        public int id { get => _id; set => _id = value; }

        public bool status => _status;
        #endregion

        public void connetti(string s)
        {
            _status = true;
            System.Windows.Forms.MessageBox.Show("Connesso a" + s) ;
        }

        public void disconnetti(string s)
        {
            _status = false;
            System.Windows.Forms.MessageBox.Show("Disconnesso da" + s);
        }
        public void stato()
        {
            /*if(_status)
                System.Windows.Forms.MessageBox.Show("Attualmente connesso con id:" + _id.ToString());
            else System.Windows.Forms.MessageBox.Show("Non connesso!!");*/
            System.Windows.Forms.MessageBox.Show(_status? "Attualmente connesso con id:" + _id.ToString(): "Non connesso!!");
        }

        

    }
}
