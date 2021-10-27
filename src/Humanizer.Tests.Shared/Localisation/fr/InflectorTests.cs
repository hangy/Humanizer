//The Inflector class was cloned from Inflector (https://github.com/srkirkland/Inflector)

//The MIT License (MIT)

//Copyright (c) 2013 Scott Kirkland

//Permission is hereby granted, free of charge, to any person obtaining a copy of
//this software and associated documentation files (the "Software"), to deal in
//the Software without restriction, including without limitation the rights to
//use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
//the Software, and to permit persons to whom the Software is furnished to do so,
//subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
//FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
//COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
//IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Collections;
using System.Linq;
using System.Collections.Generic;

using Xunit;

namespace Humanizer.Tests.Localisation.fr
{
    [UseCulture("fr")]
    public class InflectorTests
    {
        public readonly IList<object[]> PluralTestData = new List<object[]>();

        [Theory]
        [ClassData(typeof(PluralTestSource))]
        public void Pluralize(string singular, string plural)
        {
            Assert.Equal(plural, singular.Pluralize());
        }

        [Theory]
        [ClassData(typeof(PluralTestSource))]
        public void PluralizeWordsWithUnknownPlurality(string singular, string plural)
        {
            Assert.Equal(plural, plural.Pluralize(false));
            Assert.Equal(plural, singular.Pluralize(false));
        }

        [Theory]
        [ClassData(typeof(PluralTestSource))]
        public void Singularize(string singular, string plural)
        {
            Assert.Equal(singular, plural.Singularize());
        }

        [Theory]
        [ClassData(typeof(PluralTestSource))]
        public void SingularizeWordsWithUnknownSingularity(string singular, string plural)
        {
            Assert.Equal(singular, singular.Singularize(false));
            Assert.Equal(singular, plural.Singularize(false));
        }
    }

    internal class PluralTestSource : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            return EnumerateValues().Select(t => new object[] { t.singular, t.plural }).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private static IEnumerable<(string singular, string plural)> EnumerateValues()
        {
            yield return ("jardin", "jardins");
            yield return ("voiture", "voitures");
            yield return ("hôtel", "hôtels");
            yield return ("fils", "fils");
            yield return ("voix", "voix");
            yield return ("nez", "nez");
            yield return ("chapeau", "chapeaux");
            yield return ("jeu", "jeux");
            yield return ("bijou", "bijoux");
            yield return ("caillou", "cailloux");
            yield return ("chou", "choux");
            yield return ("genou", "genoux");
            yield return ("hibou", "hiboux");
            yield return ("joujou", "joujoux");
            yield return ("pou", "poux");
            yield return ("journal", "journaux");
            yield return ("animal", "animaux");
            yield return ("travail", "travaux");
            yield return ("œil", "yeux");
        }
    }
}
