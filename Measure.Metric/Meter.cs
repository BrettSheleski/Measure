using Measure.Core;
using System;

namespace Measure.Metric
{
    public struct Meter : IMeasureInfo<ILength>
    {
        public string Name => "Meter";

        public string PluralName => "Meters";

        public string Abbreviation => "m";
    }
}