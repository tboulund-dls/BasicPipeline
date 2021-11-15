using System.Linq;
using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise3;

namespace BasicPipeline.Filters.Exercise2
{
    public class SumOrderLinesFilter : Filter<Order>
    {
        protected override void Execute(Order data)
        {
            data.TotalPrice = data.Lines.Sum(l => l.Quantity * l.UnitPrice);
        }
    }
}