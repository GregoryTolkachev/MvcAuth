namespace MvcAuth.Models
{
    public class Stock
    {
        public uint StockId { get; set; }

        public uint Count{get;set;}

        public string Location {get;set;}

        public virtual Product Product{get;set;}
    }
}