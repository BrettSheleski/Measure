namespace Measure.Core
{
    public interface IArea : ICompositeMeasure<ILength, ILength>
    {
        new IArea ScaleBy(int scale);
        new IArea ScaleBy(double scale);
    }
}
