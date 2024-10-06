using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Classes
{
    /// <summary>
    /// Цитрусовые
    /// </summary>
    public class Cytrus: Fruit
    {
        /// <summary>
        /// Цвет кожуры
        /// </summary>
        public string PeelColor { get; set; }
        public Cytrus(Cytrus cytrus): base(cytrus) 
        {
            PeelColor = cytrus.PeelColor;
        }

        public Cytrus()
        {
        }

        public override Cytrus MyClone()
        {
            return new Cytrus(this);
        }
        public override object Clone()
        {
            return MyClone();
        }
    }
}
