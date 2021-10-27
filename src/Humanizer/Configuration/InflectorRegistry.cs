namespace Humanizer.Configuration
{
    using Humanizer.Inflections;

    internal class InflectorRegistry : LocaliserRegistry<IInflector>
    {
        public InflectorRegistry()
            : base(Vocabularies.Default)
        {
        }
    }
}
