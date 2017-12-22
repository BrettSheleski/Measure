namespace Measure.Core
{
    public interface IMeasure
    {
        IMeasure ScaleBy(int scale);
        IMeasure ScaleBy(double scale);
        double Scale { get; }

        ICompositeMeasure Times(IMeasure measure);
    }
}
