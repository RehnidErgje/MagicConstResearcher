using System;
using System.IO;

namespace MagicConstResearcher
{
    abstract public class AbstractResearcher
    {
        public double property1 { get; protected set; }
        public double property2 { get; protected set; }
        public double property3 { get; protected set; }
        protected int ready;
        protected UInt64 count =100086;
        abstract public ResearchResult GetResult(float _a, float _b, double p1, double p2 , double p3 = 0);
        public static AbstractResearcher CreateReasearch(string method)
        {
            Type T = Type.GetType("MagicConstResearcher.ResearchMethod." + method);
            return (AbstractResearcher)Activator.CreateInstance(T);
        }
        public int GetResearchProgress()
        {
            return ready/((int)count / 100);
        }
    }
}
