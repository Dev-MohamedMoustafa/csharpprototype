/*
 * this code was written by Mohamed Moustafa
 * As a preview of his knowledge in Design Patterns
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Profile : IClonable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public IClonable Clone()
        {
            return new Profile()
            {
                Name = this.Name,
                Age = this.Age,
                Nationality = this.Nationality
            };
        }
    }
}
