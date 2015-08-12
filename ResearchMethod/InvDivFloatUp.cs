using System;
using System.Windows.Forms;

namespace MagicConstResearcher.ResearchMethod
{
    class InvDivFloatUp : AbstractResearcher
    {
        public InvDivFloatUp()
        {
            property1 = 2.0;
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
                Name = "InvDivFloatUp"
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
            double basicDiv;
            double invDiv;
            while (i < (int)count)
            {
                x = *(float*)&temp;
                float y = x;
                basicDiv = 1f / x;
                {
                    int j = *(int*)(&x);
                    j = 0x7ef311c3 - j;
                    y = *(float*)&j;
                    float r = 1 - x * y;
                    y = y * (1 + r * (1 + r));
                    if (property1 != 0)
                    y = y * ((Single)property1 - y * x);
                    invDiv = y;
                }
                dx = invDiv - basicDiv;
                if (dx / basicDiv > result.max)
                {
                    result.max = dx / basicDiv;
                    result.xmax = *(float*)&temp;
                }
                if (dx / basicDiv < result.min)
                {
                    result.min = dx / basicDiv;
                    result.xmin = *(float*)&temp;
                }
                if (k > space)
                {
                    result.Y[i] = invDiv;
                    result.AbsoluteError[i] = dx;
                    result.RelativeError[i] = dx / basicDiv;
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
