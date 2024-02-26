using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{
    //44*60 inch but will store it as more blocks to make placement of models more natural
    class Map
    {
        //Might be wrong :o
        private Block[,] _map = new Block[44, 60];



        public void CreateMap() 
        {
            for(int i = 0; i < 44 ; i++) 
            {
                for(int  j = 0; j < 60; j++) 
                {
                    _map[i, j] = new Block();   
                }
            }
        }

        //x and y values might need to swap, will depend on the View method
        public Block GetCell(int x, int y) { return _map[x, y]; }
    }
}
