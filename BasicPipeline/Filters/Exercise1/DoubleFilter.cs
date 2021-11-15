using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise1;

namespace BasicPipeline.Filters.Exercise1
{
    public class DoubleFilter : Filter<LongNumber>
    {
        protected override void Execute(LongNumber data)
        {
            data.Result *= 2;
        }
    }
}