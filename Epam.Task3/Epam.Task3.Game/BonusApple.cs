﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class BonusApple : Bonus
    {
        public BonusApple()
        {
        }

        public override TimeSpan BonusTime => new TimeSpan(0, 0, 4);
    }
}
