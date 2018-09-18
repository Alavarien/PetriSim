using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriSim.Cell
{
    class BasicCell
    {
        public static int STARTING_HEALTH = 30;
        public static int MAX_HEALTH = 50;
        public static int STARTING_FOOD = 25;
        public static int MAX_FOOD = 100;



        private int posX;
        private int posY;
        private int health;
        private int age;
        private int food;

        public BasicCell()
        {
            this.posX = 0;
            this.posY = 0;
            this.age = 0;
            this.food = STARTING_FOOD;
            this.health = STARTING_HEALTH;
        }
    }
}
