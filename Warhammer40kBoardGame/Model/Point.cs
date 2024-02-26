using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{
    class Point
    {
        public int x, y;
        private Point nextPoint;

        public Point(int x, int y,Point next) 
        {
            this.x = x;
            this.y = y;
            this.nextPoint = next;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.nextPoint = this;
        }

        public Point GetNextPoint() {  return nextPoint; }

    }
}
