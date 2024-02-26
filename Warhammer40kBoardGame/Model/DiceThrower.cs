using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WarHammerApplication.Model
{
    class DiceThrower
    {
        List<Dice> _dices = new List<Dice> ();

        public DiceThrower() 
        { }


        public void AddDices(int type, int number) 
        {
            for(int i = 0; i < number; i++) 
            {
                _dices.Add(new Dice(type));
            }
        }

        public void AddAndThrowDices(int type, int number)
        {
            for (int i = 0; i < number; i++)
            {
                _dices.Add(new Dice(type));
                _dices[i].ThrowDice();
            }
        }

        public int CountDices(int minValue) 
        {
            int result = 0;

            foreach (Dice d in _dices) 
            {
                if(d.GetValue() >= minValue) {  result++; }
            }

            return result;
        }


        // 1 => If value is 1
        // x => if value less than or equal x 
        public void RollOnCondition(int condition) 
        {
            if(condition == 1) 
            {
                foreach(Dice d in _dices) 
                {
                    if(d.GetValue() == 1) { d.ThrowDice(); }
                }
            }
            else 
            {
                foreach (Dice d in _dices) 
                {
                    if (d.GetValue() <= condition) { d.ThrowDice(); }
                }
            }
        }

        public List<Dice> GetDices() { return _dices; }

        public void ClearDices() 
        {
            _dices.Clear();
        }

    }
}
