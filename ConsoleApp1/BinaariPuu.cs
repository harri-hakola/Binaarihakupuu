using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaarihakupuu
{
    public class BinaariPuu
    {
        public Ehdokas root;

        public void Insert(string etunimi, string sukunimi, int aanimaara)
        {
            if (root != null)
            {
                root.Insert(etunimi, sukunimi, aanimaara);
            }
            else
            {
                root = new Ehdokas(etunimi, sukunimi, aanimaara);
            }
        }

        public Ehdokas Find(string sukunimi)
        {
            if (root != null)
            {
                return root.Find(sukunimi);
            }
            else
            {
                return null;
            }
        }

        public void InOrderTraversal()
        {
            if (root != null)
                root.InOrdertraversal();
        }
    }
}
