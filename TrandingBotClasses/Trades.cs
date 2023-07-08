namespace TrandingBotClasses
{
    public class Trade
    {
        public Guid TradeId { get; set; }
        public string symbol { get; set; }
        public int id { get; set; }
        public int orderId { get; set; }
        public decimal price { get; set; }
        public decimal qty { get; set; }
        public decimal quoteQty { get; set; }
        public decimal comission { get; set; }
        public string comissionAsset { get; set; }
        public decimal time { get; set; }

        public virtual CBinance Conta { get; set; }

        public Trade() { }


    }
}
