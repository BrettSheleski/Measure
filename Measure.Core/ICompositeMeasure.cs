using System;

namespace Measure.Core
{
    public interface ICompositeMeasure : IMeasure
    {
        
    }

    public interface ICompositeMeasure<T1, T2> : ICompositeMeasure 
        where T1 : IMeasure 
        where T2 : IMeasure
    {
        T1 Measure1 { get; }
        T2 Measure2 { get; }
    }
}
