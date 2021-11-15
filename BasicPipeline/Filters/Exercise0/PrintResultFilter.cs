using System;
using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise0;

namespace BasicPipeline.Filters.Exercise0
{
    public class PrintResultFilter : Filter<StringStatistics>
    {
        protected override void Execute(StringStatistics data)
        {
            Console.WriteLine("Statistics for: " + data.InputString);
            Console.WriteLine("Number of vowels: " + data.NumberOfVowels);
            Console.WriteLine("Number of consonants: " + data.NumberOfConsonants);
            Console.WriteLine("Number of others: " + data.NumberOfOtherCharacters);
        }
    }
}