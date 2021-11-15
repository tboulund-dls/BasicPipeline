using System;
using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise3;

namespace BasicPipeline.Filters.Exercise2
{
    public class PrintInvoiceFilter : Filter<Order>
    {
        protected override void Execute(Order data)
        {
            Console.WriteLine($"The total price for the order {data.Number} is {data.TotalPrice}");
        }
    }
}