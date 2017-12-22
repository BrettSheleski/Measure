using Measure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Measure.Metric
{
    public class Liter : IMeasureInfo<IVolume>
    {
        public string Name => "Liter";

        public string PluralName => "Liters";

        public string Abbreviation => "L";
    }
}