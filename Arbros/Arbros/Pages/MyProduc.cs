namespace MyProduct.Models
{
    public class MyProduc
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public decimal Precio { get; set; }

        public int Stock {  get; set; }

    }
}
