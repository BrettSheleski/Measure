using Measure.Core;
using System;

namespace Measure.Metric
{
    public struct SquareMeter : IMeasureInfo<IArea>
    {
        public string Name => "Square Meter";

        public string PluralName => "Square Meters";

        public string Abbreviation => "m^2";
    }
}