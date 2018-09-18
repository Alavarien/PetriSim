using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriSim
{
    class Dish
    {
        //Our circles are square
        private Pouia[,] dish;



        public Dish(int height, int width)
        {
            this.dish = new Pouia[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    dish[i, j] = new Pouia();
                }
            }

        }


    }
}
