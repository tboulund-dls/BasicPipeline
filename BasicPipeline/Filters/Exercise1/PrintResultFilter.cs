using System;
using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise1;

namespace BasicPipeline.Filters.Exercise1
{
    public class PrintResultFilter : Filter<LongNumber>
    {
        protected override void Execute(LongNumber data)
        {
            Console.WriteLine($"The result of the input {data.Original} is {data.Result}");
        }
    }
}