using System;

namespace MagicConstResearcher.ResearchMethod
{
    class InvSqrtDouble : AbstractResearcher
    {
        public InvSqrtDouble()
        {
            property1 = 1.875;
            property2 = 1.5000000076;
            property3 = 1.5;
        }
        public override unsafe ResearchResult GetResult(float _a, float _b, double p1, double p2, double p3)
        {
            property1 = p1;
            property2 = p2;
            property3 = p3;
            UInt64 a, b, n;
            {
                double limit = (double)_a;
                a = *(UInt64*)(&limit);
                limit = (double)_b;
                b = *(UInt64*)(&limit);
                n = b - a;
            }
            UInt64 space;
            if (count < n)
                space = (n / (count));
            else
            {
                space = 1;
                count = n;
            }
            ResearchResult result = new ResearchResult
            {
                Y = new double[count],
                X = new double[count],
                AbsoluteError = new double[count],
                RelativeError = new double[count],
                Name = "InvSqrtDouble"
            };

            var i = 0;
            double x;
            UInt64 k = 0;
            double dx;
            double basicSqrt;
            double invSqrt;
            UInt64 temp = *(UInt64*)&a;
            while (i < (int)count)
            {
                x = *(double*)&temp;
                basicSqrt = 1f / Math.Sqrt(x);
                {
                    double xhalf = 0.5 * x;
                    UInt64 j = *(UInt64*)(&x);
                    j = 0x5fe6eb50c7b537a9 - (j >> 1);
                    x = *(double*)&j;
                    if (property1 != 0)
                    {
                        double c = xhalf * x * x;
                        x = x * (property1 - c * (2.5 - 1.5 * c));
                    }
                    if (property2 != 0)
                        x = x * (property2 - xhalf * x * x);
                    if (property3 != 0)
                        x = x * (property3 - xhalf * x * x);
                    invSqrt = x;
                }
                dx = invSqrt - basicSqrt;
                if (dx / basicSqrt > result.max)
                {
                    result.max = dx / basicSqrt;
                    result.xmax = *(double*)&temp;
                }
                if (dx / basicSqrt < result.min)
                {
                    result.min = dx / basicSqrt;
                    result.xmin = *(double*)&temp;
                }
                if (k > space)
                {
                    result.Y[i] = invSqrt;
                    result.AbsoluteError[i] = dx;
                    result.RelativeError[i] = dx / basicSqrt;
                    result.X[i] = *(double*)&temp;
                    i++;
                    ready = i;
                    k = 1;
                }
                k = k + 1000000000;
                temp = temp + 1000000000;
            }
            UInt64 step = 1000000000;
            UInt64 steplimith = step;
            UInt64 LimithA;
            UInt64 LimithB;
            while (step > 1)
            {
                {
                    double convMax = result.xmax;
                    LimithA = *(UInt64*)&convMax - steplimith;
                    LimithB = *(UInt64*)&convMax + steplimith;
                }
                //Step 2 refinement of MAX+
                step /= 10;
                temp = LimithA;
                while (temp < LimithB)
                {
                    x = *(double*)&temp;
                    basicSqrt = 1f / Math.Sqrt(x);
                    {
                        double xhalf = 0.5 * x;
                        UInt64 j = *(UInt64*)(&x);
                        j = 0x5fe6eb50c7b537a9 - (j >> 1);
                        x = *(double*)&j;
                        if (property1 != 0)
                        {
                            double c = xhalf * x * x;
                            x = x * (property1 - c * (2.5 - 1.5 * c));
                        }
                        if (property2 != 0)
                            x = x * (property2 - xhalf * x * x);
                        if (property3 != 0)
                            x = x * (property3 - xhalf * x * x);
                        invSqrt = x;
                    }
                    dx = invSqrt - basicSqrt;
                    if (dx / basicSqrt > result.max)
                    {
                        result.max = dx / basicSqrt;
                        result.xmax = *(double*)&temp;
                        steplimith = step;
                    }
                    k = k + step;
                    temp = temp + step;
                }
            }
            step = 1000000000;
            while (step > 1)
            {
                {
                    double convMin = result.xmin;
                    LimithA = *(UInt64*)&convMin - steplimith;
                    LimithB = *(UInt64*)&convMin + steplimith;
                }
                //Step 2 refinement of MAX-
                step /= 10;
                temp = LimithA;
                while (temp < LimithB)
                {
                    x = *(double*)&temp;
                    basicSqrt = 1f / Math.Sqrt(x);
                    {
                        double xhalf = 0.5 * x;
                        UInt64 j = *(UInt64*)(&x);
                        j = 0x5fe6eb50c7b537a9 - (j >> 1);
                        x = *(double*)&j;
                        if (property1 != 0)
                        {
                            double c = xhalf * x * x;
                            x = x * (property1 - c * (2.5 - 1.5 * c));
                        }
                        if (property2 != 0)
                            x = x * (property2 - xhalf * x * x);
                        if (property3 != 0)
                            x = x * (property3 - xhalf * x * x);
                        invSqrt = x;
                    }
                    dx = invSqrt - basicSqrt;
                    if (dx / basicSqrt < result.min)
                    {
                        result.min = dx / basicSqrt;
                        result.xmin = *(double*)&temp;
                        steplimith = step;
                    }
                    k = k + step;
                    temp = temp + step;
                }
            }
            return result;
        }
    }
}
