using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_2
{
    class Chess_caster:Chess
    {
        public void set(string _character, int _hp, int _mp, int _atk, int _atkRange, int _moveRange)
        {
            character = _character;
            hp = _hp;
            mp = _mp;
            atk = _atk;
            atkRange = _atkRange;
            moveRange = _moveRange;
        }
        public override void Skill()
        {
           atk *= 2;
        }
    }
}
