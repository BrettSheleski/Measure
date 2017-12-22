using Measure.Core;
using Measure.Metric;
using System;

namespace Measure.Imperial.Conversion.Metric
{
    public static class LengthConversions
    {
        const double FEET_PER_METER = 3.28084;

        public static Measure<Meter> ToMeters(this Measure<Foot> feet)
        {
            return new Measure<Meter>(feet.Scale * FEET_PER_METER);
        }
    }
}
