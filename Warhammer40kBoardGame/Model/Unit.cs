using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarHammerApplication.Model
{
    class Unit
    {
        private string _name;
        private int _movement;
        private int _movementCurrent;
        private int _toughness;
        private int _save;
        private int _invulnerableSave;
        private int _leaderShip;
        private int _isBattleShocked;
        private int _objectiveControl;
        private List<RangedWeapon> _rangedWeapons;
        private List<MeleeWeapon> _meleeWeapons;
        private List<Ability> _abilities;
        private List<UnitModel> _models;



    }
}
