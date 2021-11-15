using System.Collections.Generic;

namespace BasicPipeline.InputOutput.Exercise3
{
    public class Order
    {
        public string Number { get; set; }
        public Customer Customer { get; set; }
        public List<OrderLine> Lines { get; set; } = new();
        public double? TotalPrice { get; set; }

        public Order(string number, Customer customer, params OrderLine[] orderLines)
        {
            Number = number;
            Customer = customer;
            Lines = new List<OrderLine>(orderLines);
        }
    }
}