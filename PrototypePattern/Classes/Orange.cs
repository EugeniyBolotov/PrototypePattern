using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Classes
{
    /// <summary>
    /// Апельсин
    /// </summary>
    public class Orange: Cytrus
    {
        /// <summary>
        /// Диаметр плода
        /// </summary>
        public int FruitDiametr {  get; set; }
        public Orange(Orange orange) : base(orange)
        {
            FruitDiametr = orange.FruitDiametr;
        }

        public Orange()
        {
        }

        public override Orange MyClone()
        {
            return new Orange(this);
        }
        public override object Clone()
        {
            return MyClone();
        }
    }
}
