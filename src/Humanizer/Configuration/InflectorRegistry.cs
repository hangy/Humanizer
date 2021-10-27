namespace Humanizer.Configuration
{
    using Humanizer.Inflections;
    using Humanizer.Localisation.Inflectors;

    internal class InflectorRegistry : LocaliserRegistry<IInflector>
    {
        public InflectorRegistry()
            : base(Vocabularies.Default)
        {
            Register("fr", (culture) => FrenchInflector.Default);
        }
    }
}
