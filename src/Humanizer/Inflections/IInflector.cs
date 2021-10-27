namespace Humanizer.Inflections
{
    public interface IInflector
    {
        string Pluralize(string word, bool inputIsKnownToBeSingular = true);

        string Singularize(string word, bool inputIsKnownToBePlural = true, bool skipSimpleWords = false);
    }
}
