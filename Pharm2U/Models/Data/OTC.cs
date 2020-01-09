using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm2U.Models.Data
{
    public class OTC
    {
        /// <summary>
        /// Id number
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Name of the food
        /// </summary>
        public string Name { get; set; }

        public OTC(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "---- OTC ID: " + Id.ToString() + "    OTC Name : " + Name;

            return str;
        }

        /// <summary>
        /// Override of the ToString method to print out class information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Display();
        }
    }
}
