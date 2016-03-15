﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class Sickle : Tool
    {
        public Sickle()
        {
            base.name = "Sickle";
            base.durability = 100;
            base.durabilityCost = 5;
            base.upgradeLevel = 0;
            base.toolLevel = 0;
            base.staminaUsage = 5;
        }

        protected override void Sell()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            Player player = new Player();
            player.Stamina = player.Stamina - staminaUsage;
            durability -= durabilityCost;

            Console.WriteLine(name + "'s durability is now " + durability);
        }

        public override void Repair()
        {
            durability++;
        }

        public override void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
