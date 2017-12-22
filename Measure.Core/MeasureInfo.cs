namespace Measure.Core
{
    public struct MeasureInfo<T> : IMeasureInfo<T>
        where T : IMeasure
    {
        public MeasureInfo(string name, string pluralName, string abbreviaion)
        {
            this.Name = name;
            this.PluralName = pluralName;
            this.Abbreviation = abbreviaion;
        }

        public string Name { get; }

        public string PluralName { get; }

        public string Abbreviation { get; }

        
    }
}
