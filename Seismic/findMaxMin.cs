using System;
using Unplugged.Segy;
namespace Seismic
{
    class findMaxMin
    {
        public static double[] Do(ISegyFile line,double[] usilenie)
        {
            ITrace trace = line.Traces[0];
            double max_outter = double.MinValue;
            double min_outter = double.MaxValue;
            double max_inner = double.MinValue;
            double min_inner = double.MaxValue;
            double new_value;
            int j;
            for (int i = 0; i < line.Traces.Count; i++)
            {
                trace = line.Traces[i];
                max_inner = double.MinValue;
                min_inner = double.MaxValue;
                j = 1;
                foreach (var sampleValue in trace.Values)
                {
                    if (usilenie[0]==0)
                    {
                        if (sampleValue < min_inner) min_inner = sampleValue;
                        if (sampleValue > max_inner) max_inner = sampleValue;
                    }
                    else
                    {
                        new_value = sampleValue * usilenie[1] * Math.Pow(j, usilenie[2]);
                        if (new_value < min_inner) min_inner = new_value;
                        if (new_value > max_inner) max_inner = new_value;
                    }
                    j++;
                }
                if (min_inner < min_outter) min_outter = min_inner;
                if (max_inner > max_outter) max_outter = max_inner;
            }
            double[] ans = { min_outter, max_outter };
            return ans;
        }
    }
}
