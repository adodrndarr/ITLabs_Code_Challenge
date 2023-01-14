using CodeChallenges;

namespace Code_Challenge_Test
{
    public class Tests
    {
        static Challenges instance = new Challenges();

        [Test]
        public void CanCountSimilarStringPairs()
        {
            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "abaca", "cba"
            }), Is.EqualTo(1));

            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "abaca", "bcd"
            }), Is.EqualTo(0));

            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "aba", "cba"
            }), Is.EqualTo(0));

            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "aba", "cba"
            }), Is.EqualTo(0));

            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "xyz", "foo", "of"
            }), Is.EqualTo(1));

            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "aba", "abaca", "baab", "cba"
            }), Is.EqualTo(2));

            Assert.That(instance.CountSimilarStringPairs(new List<string>
            {
                "abab", "aaaaab", "bbbba"
            }), Is.EqualTo(3));
        }

        [Test]
        public void CanConvertToRomanNumbers()
        {
            Assert.That(instance.GetRomanizedNumbers(new List<int>
            {
                1, 49, 23
            }), Is.EqualTo(new List<string> { "I", "XLIX", "XXIII" }));

            Assert.That(instance.GetRomanizedNumbers(new List<int>
            {
                1, 2, 3, 4, 5
            }), Is.EqualTo(new List<string> { "I", "II", "III", "IV", "V" }));

            Assert.That(instance.GetRomanizedNumbers(new List<int>
            {
                75, 80, 99, 100, 50
            }), Is.EqualTo(new List<string> { "LXXV", "LXXX", "XCIX", "C", "L" }));

            Assert.That(instance.GetRomanizedNumbers(new List<int>
            {
                739
            }), Is.EqualTo(new List<string> { "DCCXXXIX" }));

            Assert.That(instance.GetRomanizedNumbers(new List<int>
            {
                1000, 345, 691
            }), Is.EqualTo(new List<string> { "M", "CCCXLV", "DCXCI" }));
        }

    }
}