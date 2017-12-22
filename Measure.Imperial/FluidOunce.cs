using Measure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Measure.Imperial
{
    public struct FluidOunce : IMeasureInfo<IArea>
    {
        public string Name => "Fluid Ounce";

        public string PluralName => $"{Name}s";

        public string Abbreviation => "fl oz";
    }
}
