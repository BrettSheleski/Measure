using Measure.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Measure.Imperial
{
    public struct SquareFoot : IMeasureInfo<IArea>
    {
        public string Name => "Square Foot";

        public string PluralName => "Square Feet";

        public string Abbreviation => "ft^2";
    }
}
