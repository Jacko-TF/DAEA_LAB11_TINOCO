namespace DAEA_LAB11_TINOCO.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string DocumentNumber { get; set; }
        public bool Active { get; set; } = true;
    }
}
