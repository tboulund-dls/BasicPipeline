namespace BasicPipeline.InputOutput.Exercise1
{
    public class LongNumber
    {
        public long Original { get; }
        public long Result { get; set; }

        public LongNumber(long value)
        {
            Original = value;
            Result = value;
        }
    }
}