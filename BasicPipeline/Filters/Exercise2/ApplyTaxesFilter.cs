using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise3;

namespace BasicPipeline.Filters.Exercise2
{
    public class ApplyTaxesFilter : Filter<Order>
    {
        protected override void Execute(Order data)
        {
            data.TotalPrice *= 1.25;
        }
    }
}