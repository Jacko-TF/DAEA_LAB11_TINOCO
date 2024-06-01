namespace DAEA_LAB11_TINOCO.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }

        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        /*Llave foranea para customer*/
        public Customer Customer { get; set; }

        public int CustomerID { get; set; }
    }
}
