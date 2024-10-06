using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Classes
{
    /// <summary>
    /// Мандарин
    /// </summary>
    public class Tangerine: Cytrus
    {
        /// <summary>
        /// Сорт
        /// </summary>
        public string Variety {  get; set; }

        public Tangerine(Tangerine tangerine) : base(tangerine)
        {
            Variety = tangerine.Variety;
        }

        public Tangerine()
        {
        }

        public override Tangerine MyClone()
        {
            return new Tangerine(this);
        }
        public override object Clone()
        {
            return MyClone();
        }
    }
}
