namespace BasicPipeline.InputOutput.Exercise3
{
    public class OrderLine
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public OrderLine(string description, int quantity, double unitPrice)
        {
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}