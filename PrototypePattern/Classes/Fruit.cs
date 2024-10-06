using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Interfaces;

namespace PrototypePattern.Classes
{
    /// <summary>
    /// Фрукты
    /// </summary>
    public class Fruit: IMyCloneable<Fruit>, ICloneable
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ареол произростания
        /// </summary>
        public string GrowthAreol { get; set; }
        public Fruit(Fruit fruit) 
        {
            Name = fruit.Name;
            GrowthAreol = fruit.GrowthAreol;
        }

        public Fruit()
        {
        }

        public virtual Fruit MyClone()
        {
            return new Fruit(this);
        }
        public virtual object Clone()
        {
            return MyClone();
        }
    }
}
