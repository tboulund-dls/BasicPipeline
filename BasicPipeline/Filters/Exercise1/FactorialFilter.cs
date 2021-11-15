using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise1;

namespace BasicPipeline.Filters.Exercise1
{
    public class FactorialFilter : Filter<LongNumber>
    {
        protected override void Execute(LongNumber data)
        {
            var result = data.Result;
            for (var i = data.Result - 1; i > 0; i--)
            {
                result *= i;
            }

            data.Result = result;
        }
    }
}