using System;
using System.Collections.Generic;
using System.Text;
using Measure.Core;

namespace Measure.Metric
{
    public struct Newton : IMeasureInfo<IForce>
    {
        public string Name => "Newton";

        public string PluralName => $"{Name}s";

        public string Abbreviation => "N";
    }
}
