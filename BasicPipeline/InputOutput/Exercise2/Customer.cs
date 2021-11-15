namespace BasicPipeline.InputOutput.Exercise3
{
    public class Customer
    {
        public string Name { get; set; }
        public double DiscountPercentage { get; set; }

        public Customer(string name, double discountPercentage)
        {
            Name = name;
            DiscountPercentage = discountPercentage;
        }
    }
}