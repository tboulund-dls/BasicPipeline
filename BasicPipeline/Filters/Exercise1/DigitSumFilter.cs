using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise1;

namespace BasicPipeline.Filters.Exercise1
{
    public class DigitSumFilter : Filter<LongNumber>
    {
        protected override void Execute(LongNumber data)
        {

            while (data.Result.ToString().Length > 1)
            {
                var digitSum = 0;
                foreach (var digit in data.Result.ToString())
                {
                    digitSum += int.Parse(digit.ToString());
                }

                data.Result = digitSum;
            }
        }
    }
}