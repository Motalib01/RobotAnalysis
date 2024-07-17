using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Poteax.Models
{
    public class ResultData
    {
        public string Type { get; set; }
        public double FX { get; set; }
        public double MY { get; set; }
        public double MZ { get; set; }

        public ResultData(string type, double fx, double my, double mz)
        {
            Type = type;
            FX = fx;
            MY = my;
            MZ = mz;
        }
    }
}
