using System;
using System.Windows.Forms;

namespace MagicConstResearcher.ResearchMethod
{
    class InvSqrtFloatFixed : AbstractResearcher
    {
        public InvSqrtFloatFixed()
        {
            property1 = 0.5;
            property2 = 0.5;
        }
        public override unsafe ResearchResult GetResult(float _a, float _b, double p1, double p2, double p3 = 0)
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
                Name = "InvSqrtFloatFixed"
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
                    int mx = temp % 8388608;
                    float xx;
                    if ((temp >> 23) % 2 == 1)
                    {
                        xx = 0.25f + *(float*)&mx;
                    }
                    else
                    {
                        double xt = 0.5 + 3627654D / 8388608D;
                        if (xt > *(float*)&mx)
                            xx = 0.5f + (*(float*)&mx) / 2;
                        else
                            xx = 0.125f + (*(float*)&mx) / 8;
                    }
                    float xhalf = 0.5f * xx;
                    if (property1 != 0)
                    {
                        float r1 = (Single)property1 - xhalf * x * x;
                        x = x * (1f + r1);
                    }
                    if (property2 != 0)
                    {
                        float r2 = (Single)property2 - xhalf * x * x;
                        x = x * (1f + r2);
                    }
                    int rez = (temp / 8388608 + (*(int*)&x) % 8388608);
                    invSqrt = *(float*)&rez;
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
