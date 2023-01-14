namespace CodeChallenges;

public class Challenges
{
    public long CountSimilarStringPairs(List<string> words)
    {
        long numberOfSimilarPairs = 0;
        var wordChars = new Dictionary<string, List<char>>();

        foreach (var word in words)
            wordChars[word] = word.ToCharArray().ToList();

        for (int i = 0; i < words.Count - 1; i++)
        {
            for (int j = i + 1; j < words.Count; j++)
            {
                var currentWord = words[i];
                var nextWord = words[j];

                var currentContainsAllCharsOfNext = wordChars[nextWord].All(c => currentWord.Contains(c));
                var nextContainsAllCharsOfCurrent = wordChars[currentWord].All(c => nextWord.Contains(c));

                var wordsAreSimilar = currentContainsAllCharsOfNext && nextContainsAllCharsOfCurrent;

                if (wordsAreSimilar)
                    numberOfSimilarPairs++;
            }
        }

        return numberOfSimilarPairs;
    }


    public List<string> GetRomanizedNumbers(List<int> numbers)
    {
        var romanizedNumbers = new List<string>();

        foreach (var number in numbers)
        {
            var romanizedLetters = GetRomanLetters(number);

            romanizedNumbers.Add(string.Join("", romanizedLetters));
        }

        return romanizedNumbers;
    }

    static List<string> GetRomanLetters(int inputNumber)
    {
        var finalRomanLetters = new List<string>();

        var numbers = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        var romanLetters = new List<string>
        {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",

            "X", "IX", "VIII", "VII", "VI",
            "V", "IV", "III", "II", "I"
        };

        var i = 0;
        while (inputNumber >= 1)
        {
            var aNumber = numbers[i];
            var romanLetter = romanLetters[i];

            if (inputNumber >= aNumber)
            {
                inputNumber -= aNumber;
                finalRomanLetters.Add(romanLetter);
            }
            else i++;
        }

        return finalRomanLetters;
    }
}
