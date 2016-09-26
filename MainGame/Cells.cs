using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGame
{
    class Cells
    {
        float xPos;
        float yPos;
        bool isAlive;
        int neighbors;

        public Cells()
        {
            isAlive = false;
        }

        public Cells(float x, float y)
        {
            xPos = x;
            yPos = y;
            isAlive = false;
        }

        public void setNeighbor(int x)
        {
            neighbors += x;
        }

        public bool getAlive()
        {
            return isAlive;
        }

        public void toggleAlive()
        {
            isAlive = !isAlive;
        }
        public void setAliveFalse()
        {
            isAlive = false;
        }
        public void setAliveTrue()
        {
            isAlive = true;
        }
        public int getNeighbors()
        {
            return neighbors;
        }
    }
}
