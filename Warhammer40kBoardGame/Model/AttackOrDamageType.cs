using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{

    enum AttackOrDamage {  Attack, Damage };
    enum TypeOfAttack {number, dice};
    

    //Need a better name for type
    //ex.: d6 + 3 attacks
    class AttackOrDamageType
    {
        private TypeOfAttack _typeOfAttack;
        private AttackOrDamageType _attackOrDamage;
        private int _modifier;
        private List<Dice> _dices;
        private int _value;

        //Need better constructors
        public AttackOrDamageType(TypeOfAttack typeOfAttack, int modifier) 
        {
            _typeOfAttack = typeOfAttack;
            _modifier = modifier;
        }

        public int GetValue() 
        {
            int result = 0;
            if(_typeOfAttack == TypeOfAttack.number) 
            {
                result = _value;
            }
            else
            {
                foreach(Dice dice in _dices) 
                {
                    result += dice.ThrowDice();
                }
            }
            result += _modifier;

            return result;
        }

        public AttackOrDamageType GetAttackOrDamage() { return _attackOrDamage; }

        public TypeOfAttack GetTypeOfAttack() { return _typeOfAttack;}
        public int GetModifier() { return _modifier;}
    }
}
