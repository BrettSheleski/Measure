using System;

namespace Measure.Core
{
    public struct CompositeMeasure<T1, T2> : ICompositeMeasure<T1, T2>
        where T1 : IMeasure
        where T2 : IMeasure
    {
        public CompositeMeasure(T1 measure1, T2 measure2) : this(measure1, measure2, 1)
        {
        }

        public CompositeMeasure(T1 measure1, T2 measure2, double scale)
        {
            this.Measure1 = measure1;
            this.Measure2 = measure2;
            this.Scale = scale;
        }

        public T1 Measure1 { get; }
        public T2 Measure2 { get; }
        public double Scale { get; }

        public CompositeMeasure<T1, T2> ScaleBy(int scale)
        {
            return new CompositeMeasure<T1, T2>(Measure1, Measure2, this.Scale * scale);
        }

        public CompositeMeasure<T1, T2> ScaleBy(double scale)
        {
            return new CompositeMeasure<T1, T2>(Measure1, Measure2, this.Scale * scale);
        }

        public CompositeMeasure<CompositeMeasure<T1, T2>, IMeasure> Times(IMeasure measure)
        {
            return new CompositeMeasure<CompositeMeasure<T1, T2>, IMeasure>(this, measure);
        }

        public static CompositeMeasure<T1, T2> operator *(CompositeMeasure<T1, T2> measure, int scale)
        {
            return measure.ScaleBy(scale);
        }

        public static CompositeMeasure<T1, T2> operator *(CompositeMeasure<T1, T2> measure, double scale)
        {
            return measure.ScaleBy(scale);
        }

        public static CompositeMeasure<CompositeMeasure<T1, T2>, IMeasure> operator *(CompositeMeasure<T1, T2> measure, IMeasure other)
        {
            return measure.Times(other);
        }

        public static CompositeMeasure<T1, T2> operator /(CompositeMeasure<T1, T2> measure, int scale)
        {
            return measure.ScaleBy(1.0 / scale);
        }

        public static CompositeMeasure<T1, T2> operator /(CompositeMeasure<T1, T2> measure, double scale)
        {
            return measure.ScaleBy(1.0 / scale);
        }

        #region interface
        double IMeasure.Scale => Measure1.Scale * Measure2.Scale * Scale;

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

    public struct CompositeMeasure<M1, MT1, M2, MT2> : ICompositeMeasure<M1, M2>
        where M1 : IMeasure<MT1>
        where M2 : IMeasure<MT2>
        where MT1 : IMeasureInfo
        where MT2 : IMeasureInfo
    {
        public CompositeMeasure(M1 measure1, M2 measure2) : this(measure1, measure2, 1)
        {
        }

        public CompositeMeasure(M1 measure1, M2 measure2, double scale)
        {
            this.Measure1 = measure1;
            this.Measure2 = measure2;
            this.Scale = scale;
        }

        public M1 Measure1 { get; }
        public M2 Measure2 { get; }
        public double Scale { get; }

        public CompositeMeasure<M1, MT1, M2, MT2> ScaleBy(int scale)
        {
            return new CompositeMeasure<M1, MT1, M2, MT2>(Measure1, Measure2, this.Scale * scale);
        }

        public CompositeMeasure<M1, MT1, M2, MT2> ScaleBy(double scale)
        {
            return new CompositeMeasure<M1, MT1, M2, MT2>(Measure1, Measure2, this.Scale * scale);
        }

        public CompositeMeasure<CompositeMeasure<M1, MT1, M2, MT2>, IMeasure> Times(IMeasure measure)
        {
            return new CompositeMeasure<CompositeMeasure<M1, MT1, M2, MT2>, IMeasure>(this, measure);
        }

        public static CompositeMeasure<M1, MT1, M2, MT2> operator *(CompositeMeasure<M1, MT1, M2, MT2> measure, int scale)
        {
            return measure.ScaleBy(scale);
        }

        public static CompositeMeasure<M1, MT1, M2, MT2> operator *(CompositeMeasure<M1, MT1, M2, MT2> measure, double scale)
        {
            return measure.ScaleBy(scale);
        }

        public static CompositeMeasure<CompositeMeasure<M1, MT1, M2, MT2>, IMeasure> operator *(CompositeMeasure<M1, MT1, M2, MT2> measure, IMeasure other)
        {
            return measure.Times(other);
        }

        public static CompositeMeasure<M1, MT1, M2, MT2> operator /(CompositeMeasure<M1, MT1, M2, MT2> measure, int scale)
        {
            return measure.ScaleBy(1.0 / scale);
        }

        public static CompositeMeasure<M1, MT1, M2, MT2> operator /(CompositeMeasure<M1, MT1, M2, MT2> measure, double scale)
        {
            return measure.ScaleBy(1.0 / scale);
        }

        #region interface
        double IMeasure.Scale => Measure1.Scale * Measure2.Scale * Scale;

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

        public override string ToString()
        {
            return $"{Scale * Measure1.Scale * Measure2.Scale}{Measure1.MeasureType.Abbreviation}{Measure2.MeasureType.Abbreviation}";
        }
    }
}