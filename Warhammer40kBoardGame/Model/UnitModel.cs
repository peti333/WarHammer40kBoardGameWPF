using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{

    //<summary>
    //Individual models for moving and position
    //</summary>
    class UnitModel
    {
        private int _movement;
        private int _movementCurrent;
        private int _x;
        private int _y;

        //Need to move the model _x and _y
        //Will be finished later when Map is finished
        public void moveModel(int movement) 
        {
            if(_movement - movement > 0) 
            {
                _movementCurrent = -movement;
            }
            else 
            {
                //Will be handled later
                System.Console.WriteLine("Not enough movement!");
            }
            
        }
    }
}
