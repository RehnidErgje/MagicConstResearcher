using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicConstResearcher
{
    public struct ResearchResult
    {
        public string Name;
        public double[] X,Y, AbsoluteError, RelativeError;
        public double max, min, xmax, xmin;
    }
}
