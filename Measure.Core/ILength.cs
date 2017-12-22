namespace Measure.Core
{
    public interface ILength : IMeasure
    {
        new ILength ScaleBy(int scale);
        new ILength ScaleBy(double scale);
        IArea Times(ILength length);
    }
}
