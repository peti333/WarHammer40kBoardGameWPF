using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{
    class Dice
    {
        private int _type;
        private int _value;

        public Dice(int type) { _type = type; }

        public int ThrowDice() 
        {
            _value = new Random().Next(1, (_type+1)); 

            return _value;
        }
        public int GetType() { return _type;}
        public int GetValue() {  return _value;}
    }
}
