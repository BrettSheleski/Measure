using System;

namespace Measure.Core
{
    public interface IMeasure<T> : IMeasure
        where T : IMeasureInfo
    {
        T MeasureType { get; }
    }

    public struct Measure<T> : IMeasure<T>
        where T : IMeasureInfo
    {
        public Measure(double scale)
        {
            this.Scale = scale;

            MeasureType = default(T);
        }

        public T MeasureType { get; }

        public double Scale { get; }

        public static Measure<T> One { get; } = new Measure<T>(1);

        public Measure<T> ScaleBy(int scale)
        {
            return this.ScaleBy((double)scale);
        }

        public Measure<T> ScaleBy(double scale)
        {
            return new Measure<T>(this.Scale * scale);
        }

        public CompositeMeasure<Measure<T>, IMeasure> Times(IMeasure measure)
        {
            return new CompositeMeasure<Measure<T>, IMeasure>(this, measure);
        }

        public CompositeMeasure<Measure<T>, T, Measure<T2>, T2> Times<T2>(Measure<T2> measure)
            where T2 : IMeasureInfo
        {
            return new CompositeMeasure<Measure<T>, T, Measure<T2>, T2>(this, measure);
        }


        public static Measure<T> operator *(double scale, Measure<T> measure)
        {
            return measure.ScaleBy(scale);
        }

        public static Measure<T> operator *(int scale, Measure<T> measure)
        {
            return measure.ScaleBy(scale);
        }

        public static Measure<T> operator *(Measure<T> measure, int scale)
        {
            return measure.ScaleBy(scale);
        }
        
        public static Measure<T> operator *(Measure<T> measure, double scale)
        {
            return measure.ScaleBy(scale);
        }

        public static CompositeMeasure<Measure<T>, IMeasure> operator *(Measure<T> measure, IMeasure other)
        {
            return measure.Times(other);
        }
        
        public static Measure<T> operator /(Measure<T> measure, int scale)
        {
            return measure.ScaleBy(1.0 / scale);
        }

        public static Measure<T> operator /(Measure<T> measure, double scale)
        {
            return measure.ScaleBy(1.0 / scale);
        }

        public override string ToString()
        {
            // 1ft
            // 2m
            return $"{Scale}{MeasureType.Abbreviation}";
        }

        #region IMeasure Interface

        double IMeasure.Scale
        {
            get { return this.Scale; }
        }
        
        IMeasure IMeasure.ScaleBy(int scale)
        {
            return this.ScaleBy(scale);
        }

        IMeasure IMeasure.ScaleBy(double scale)
        {
            return this.ScaleBy(scale);
        }

        ICompositeMeasure IMeasure.Times(IMeasure measure)
        {
            return this.Times(measure);
        }

        #endregion
    }
}
