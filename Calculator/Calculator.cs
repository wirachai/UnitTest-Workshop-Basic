namespace Calculator
{
    public class Calculator
    {
        public decimal Current { get; set; }

        public void Add(decimal number)
        {
            Current += number;
        }
    }
}