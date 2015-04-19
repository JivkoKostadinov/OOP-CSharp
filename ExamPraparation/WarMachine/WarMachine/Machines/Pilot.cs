

namespace Furniture.Machines
{
    using Furniture.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot cannot be null");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Null machine cannot be added to pilot");
             this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines
                .OrderBy(m => m.HealthPoints)
                .ThenBy(m => m.Name);

             var noMachineMaybe = 
                this.machines.Count > 0 ? 
                this.machines.Count.ToString() 
                : "no";
            var pluaralMAchinesMaybe =
                this.machines.Count == 1
                ? "machine"
                : "machine";
            
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}", this.name, noMachineMaybe, pluaralMAchinesMaybe));

            foreach (var machine  in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }

            return result.ToString().Trim();

        }
    }
}
