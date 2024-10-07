using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ComputerGame
    {
        private string name;
        private PegiAgeRating pegiAgeRating;
        private double budgetInMillionsOfDollars;
        private int minimumGpuMemoryInMegabytes;
        private int diskSpaceNeededInGB;
        private int ramNeededInGb;
        private int coresNeeded;
        private double coreSpeedInGhz;

        public ComputerGame(string name, PegiAgeRating pegiAgeRating, double budgetInMillionsOfDollars, int minimumGpuMemoryInMegabytes,
            int diskSpaceNeededInGB, int ramNeededInGb, int coresNeeded, double coreSpeedInGhz)
        {
            this.name = name;
            this.pegiAgeRating = pegiAgeRating;
            this.budgetInMillionsOfDollars = budgetInMillionsOfDollars;
            this.minimumGpuMemoryInMegabytes = minimumGpuMemoryInMegabytes;
            this.diskSpaceNeededInGB = diskSpaceNeededInGB;
            this.ramNeededInGb = ramNeededInGb;
            this.coresNeeded = coresNeeded;
            this.coreSpeedInGhz = coreSpeedInGhz;
        }

        public string getName()
        {
            return name;
        }
        public PegiAgeRating getPegiAgeRating()
        {
            return pegiAgeRating;
        }
        public double getBudgetInMillionsOfDollars()
        {
            return budgetInMillionsOfDollars;
        }
        public int getMinimumGpuMemoryInMegabytes()
        {
            return minimumGpuMemoryInMegabytes;
        }
        public int getDiskSpaceNeededInGB()
        {
            return diskSpaceNeededInGB;
        }
        public int getRamNeededInGb()
        {
            return ramNeededInGb;
        }
        public int getCoresNeeded()
        {
            return coresNeeded;
        }
        public double getCoreSpeedInGhz()
        {
            return coreSpeedInGhz;
        }
    }
}
