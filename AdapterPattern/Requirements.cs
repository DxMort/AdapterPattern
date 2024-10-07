using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Requirements
    {
        private int gpuGb;
        private int HDDGb;
        private double RAMGb;
        private double cpuGhz;
        private int coresNum;

        public Requirements(int gpuGb,
                            int HDDGb,
                            int RAMGb,
                            double cpuGhz,
                            int coresNum)
        {
            this.gpuGb = gpuGb;
            this.HDDGb = HDDGb;
            this.RAMGb = RAMGb;
            this.cpuGhz = cpuGhz;
            this.coresNum = coresNum;
        }

        public int getGpuGb()
        {
            return gpuGb;
        }
        public int getHDDGb()
        {
            return HDDGb;
        }
        public double getRAMGb()
        {
            return RAMGb;
        }
        public double getCpuGhz()
        {
            return cpuGhz;
        }
        public int getCoresNum()
        {
            return coresNum;
        }
    }
    public enum PegiAgeRating
    {
        P3, P7, P12, P16, P18
    }
}
