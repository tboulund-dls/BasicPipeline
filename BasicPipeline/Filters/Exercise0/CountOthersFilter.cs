using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise0;

namespace BasicPipeline.Filters.Exercise0
{
    public class CountOthersFilter : Filter<StringStatistics>
    {
        protected override void Execute(StringStatistics data)
        {
            data.NumberOfOtherCharacters = data.InputString.Length - data.NumberOfConsonants - data.NumberOfVowels;
        }
    }
}