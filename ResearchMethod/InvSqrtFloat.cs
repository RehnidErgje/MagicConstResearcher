using System;
using System.Windows.Forms;

namespace MagicConstResearcher.ResearchMethod
{
    class InvSqrtFloat : AbstractResearcher
    {
        public InvSqrtFloat()
        {
            property1 = 1.5;
            property2 = 1.5;
        }
        public override unsafe ResearchResult GetResult(float _a, float _b, double p1, double p2, double p3 = 0 )
        {
            property1 = p1;
            property2 = p2;
            int a = *(int*)(&_a);
            int b = *(int*)(&_b);
            UInt64 n = (UInt64)(b - a);
            ResearchResult result = new ResearchResult
            {
                Y = new double[count],
                X = new double[count],
                AbsoluteError = new double[count],
                RelativeError = new double[count],
                Name = "InvSqrtFloat"
            };
            int space;
            if (count < n)
                space = (int)(n / count);
            else
            {
                space = 1;
                count = n;
            }
            var i = 0;
            var temp = a;   
            int k = 0;
            float x;
            double dx;
            double basicSqrt;
            double invSqrt;
            while (i < (int)count)
            {
                x = *(float*)&temp;
                basicSqrt = 1f / Math.Sqrt(x);
                {
                    float xhalf = 0.5f * x;
                    int j = *(int*)(&x);
                    j = 0x5f375a86 - (j >> 1);
                    x = *(float*)&j;
                    if (property1 != 0)
                    x = x * ((Single)property1 - xhalf * x * x);
                    if (property2 != 0)
                    x = x * ((Single)property2 - xhalf * x * x);
                    invSqrt = x;
                }
                dx = invSqrt - basicSqrt;
                if (dx / basicSqrt > result.max)
                {
                    result.max = dx / basicSqrt;
                    result.xmax = *(float*)&temp;
                }
                if (dx / basicSqrt < result.min)
                {
                    result.min = dx / basicSqrt;
                    result.xmin = *(float*)&temp;
                }
                if (k > space)
                {
                    result.Y[i] = invSqrt;
                    result.AbsoluteError[i] = dx;
                    result.RelativeError[i] = dx / basicSqrt;
                    result.X[i] = *(float*)&temp;
                    i++;
                    k = 1;
                }
                k++;
                temp++;
                ready = i;
            }
            return result;
        }
    }
}
