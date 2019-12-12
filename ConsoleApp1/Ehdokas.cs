using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaarihakupuu
{
    public class Ehdokas
    {
        public string etunimi;
        public string sukunimi;
        public int aanimaara;


        public Ehdokas(string etunimi, string sukunimi, int aanimaara)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.aanimaara = aanimaara;
        }

        public Ehdokas leftNode;
        public Ehdokas rightNode;

        public void Insert(string etunimi, string sukunimi, int aanimaara)
        {
            
            if (sukunimi.CompareTo(this.sukunimi) >= 0)
            {
                if (rightNode == null)
                {
                    rightNode = new Ehdokas(etunimi, sukunimi, aanimaara);
                }
                else
                {
                    rightNode.Insert(etunimi, sukunimi, aanimaara);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new Ehdokas(etunimi, sukunimi, aanimaara);
                }
                else
                {
                    leftNode.Insert(etunimi, sukunimi, aanimaara);
                }
            }
        }

        public Ehdokas Find(string value)
        {
            Ehdokas currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.sukunimi)
                {
                    return currentNode;
                }
                else if (value.CompareTo(currentNode.sukunimi) >0)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            //Ei löytynyt
            return null;
        }

        public void InOrdertraversal()
        {
            if (leftNode != null)
                leftNode.InOrdertraversal();
            Console.WriteLine(etunimi + " " + sukunimi + " " + aanimaara);

            if (rightNode != null)
                rightNode.InOrdertraversal();
        }
    }
}
