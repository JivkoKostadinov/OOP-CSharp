

namespace Furniture.Machines
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using WarMachines.Interfaces;
    
    public class Tank : Machine, ITank, IMachine
    {
        private const int initialHealthPoints = 100;
        private const int attackPointsChange = 40;
        private const int defensePointsChange = 30;





        public Tank(string name, double attackPoints, double defenseMode)
            : base(name, attackPoints, defenseMode, initialHealthPoints)
        {
            this.DefenseMode = true;
            //TODO:start defense mode
        }
        public bool DefenseMode
        {
            get;
            private set;
        }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= attackPointsChange;
                this.DefensePoints += defensePointsChange;
            }
            else
            {
                this.AttackPoints += attackPointsChange;
                this.DefensePoints -= defensePointsChange;
            }
        }

           public override string ToString()
           {
               var baseString = base.ToString();

               var result = new StringBuilder();

               result.Append(baseString);
               result.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

               return result.ToString();

           }

        }
    }
}
