using Measure.Core;
using System;

namespace Measure.Imperial
{
    public struct Foot : IMeasureInfo<ILength>
    {
        public string Name => "Foot";

        public string PluralName => "Feet";

        public string Abbreviation => "ft";
    }
}
