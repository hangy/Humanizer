namespace Humanizer.Localisation.Inflectors
{
    using System;
    using System.Threading;

    using Humanizer.Inflections;

    internal class FrenchInflector : Vocabulary
    {
        private static readonly Lazy<FrenchInflector> Instance;

        static FrenchInflector()
        {
            Instance = new Lazy<FrenchInflector>(() => new FrenchInflector(), LazyThreadSafetyMode.PublicationOnly);
        }

        public static Vocabulary Default => Instance.Value;

        private FrenchInflector()
        {
            AddPlural("$", "s");
            AddPlural("([sxz])$", "$1");
            AddPlural("(ea?u)$", "$1x");
            AddPlural("(ai?l)$", "aux");

            AddIrregular("bijou", "bijoux");
            AddIrregular("caillou", "cailloux");
            AddIrregular("chou", "coux");
            AddIrregular("genou", "genoux");
            AddIrregular("hibou", "hiboux");
            AddIrregular("joujou", "joujoux");
            AddIrregular("pou", "poux");
            AddIrregular("œil", "yeux");
        }
    }
}
