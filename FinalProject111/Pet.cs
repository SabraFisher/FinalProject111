using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject111
{
    public class Pet
    {
        public int PetId {  get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public string Age { get; set; }

        public override string? ToString()
        {
            return $"{PetId} - {Name} - {Species} - {Color} - {Age}";
        }
    }
}
