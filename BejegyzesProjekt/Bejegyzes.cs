using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {

        public string szerzo, tartalom;
        public DateTime letrejott, szerkesztve;
        public int likeok;

        /// <summary>
        /// Bejegyzes ctor
        /// </summary>
        /// <param name="szerzo"></param>
        /// <param name="tartalom"></param>
        public Bejegyzes(string szerzo, string tartalom)
        {
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.szerkesztve = letrejott;
        }

        /// <summary>
        /// szerzo get
        /// </summary>
        public string Szerzo
        {
            get
            {
                return this.szerzo;
            }
        }

        /// <summary>
        /// tartalom get/set
        /// </summary>
        public string Tartalom
        {
            get
            {
                return this.tartalom;
            }
            set
            {
                if (this.tartalom != value)
                {
                    this.szerkesztve = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// likok get/set
        /// </summary>
        public int Likeok
        {
            get
            {
                return this.likeok;
            }
        }


        /// <summary>
        /// letrejott get
        /// </summary>
        public DateTime Letrejott
        {
            get
            {
                return this.letrejott;
            }
        }


        /// <summary>
        /// szerkesztve get
        /// </summary>
        public DateTime Szerkesztve
        {
            get
            {
                return this.szerkesztve;
            }
        }

        /// <summary>
        /// likeok számának növelése
        /// </summary>
        public void Like()
        {
            likeok++;
        }


        public string Kiir()
        {
            if (Convert.ToDateTime(letrejott) == Convert.ToDateTime(szerkesztve))
            {
                return "Szerző : " + szerzo + "\nTartalom : " + tartalom + "\nLikeok : " + likeok + "\nLétrejött : " + letrejott+"\n";
            }
            else
            {
                return "Szerző : " + szerzo + "\nTartalom : " + tartalom + "\nLikeok : " + likeok + "\nLétrejött : " + letrejott + "\nSzerkesztve : " + szerkesztve +"\n";
            }

        }


    }
}
