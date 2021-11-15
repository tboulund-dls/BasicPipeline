using System;
using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise3;

namespace BasicPipeline.Filters.Exercise2
{
    public class ApplyDiscountFilter : Filter<Order>
    {
        protected override void Execute(Order data)
        {
            if (data.Customer.DiscountPercentage > 100)
            {
                Console.WriteLine("ERROR! Cannot apply a discount greater than 100%.");
            }
            else
            {
                data.TotalPrice -= data.TotalPrice * (data.Customer.DiscountPercentage / 100);
            }
        }
    }
}