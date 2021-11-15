using System.Linq;
using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise0;

namespace BasicPipeline.Filters.Exercise0
{
    public class CountVowelsFilter : Filter<StringStatistics>
    {
        private char[] vowels = new[] { 'A', 'E', 'I', 'O', 'U', 'Y' };

        protected override void Execute(StringStatistics data)
        {
            data.NumberOfVowels = data.InputString.ToUpper().Count(s => vowels.Contains(s));
        }
    }
}