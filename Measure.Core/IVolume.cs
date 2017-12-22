using System;
using System.Collections.Generic;
using System.Text;

namespace Measure.Core
{
    public interface IVolume : ICompositeMeasure<IArea, ILength>
    {
        new IVolume ScaleBy(int scale);
        new IVolume ScaleBy(double scale);
    }
}
