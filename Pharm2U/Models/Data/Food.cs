namespace Pharm2U.Models.Data
{
    public class Food
    {
        /// <summary>
        /// Id number
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Name of the food
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of food (solid, liquid, jello?)
        /// </summary>
        public string Type { get; set; }

        public Food(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Display method for this class
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string str = string.Empty;

            str += "---- Food ID: " + Id.ToString() + "   Name : " + Name + "   Type: " + Type;

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
