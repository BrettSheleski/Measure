using System.Collections.Generic;
using System.Text;

namespace Measure.Core
{
    public interface IMeasureInfo
    {
        string Name { get; }
        string PluralName { get; }
        string Abbreviation { get; }
    }

    public interface IMeasureInfo<T> : IMeasureInfo
        where T : IMeasure
    {
    }
}