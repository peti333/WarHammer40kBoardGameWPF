using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{
    class MeleeWeapon
    {
        public string Name { get; set; }
        private AttackOrDamageType _attacks;
        private int _weaponSkill;
        private int _strength;
        private int _armorPenetration;
        private AttackOrDamageType _damage;
        private List<WeaponKeyWord> _weaponKeyWords;
    }
}
