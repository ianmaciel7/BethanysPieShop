namespace BethanysPieShop.Models
{
    public class PieGiftOrder
    {
        public int PieGiftOrderId { get; set; }
        public Pie Pie { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}