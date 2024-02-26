using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{
    class Obstacle
    {

        private int test;
        private List<Point> _points = new List<Point>();

        public Obstacle() 
        {
        
        }

        public void AddFirstPoint(int x, int y) 
        {
            _points.Add(new Point(x, y));
        }

        public void AddPointWithNeighbours(int x, int y,  Point next) 
        {
            _points.Add(new Point(x, y, next));
        }


    }
}
