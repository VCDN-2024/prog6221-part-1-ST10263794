using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10263794_PROG6221_POE_PART1
{
    // Class to represent an ingredient
    internal class Recipe
    {
        public string name {  get; set; }
        public string[] Steps { get; set; }
        public Ingredients[] Ingredients { get; set; }

    }
}
