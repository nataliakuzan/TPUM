using System.Xml.Serialization;

namespace ServerPresentation
{
    [XmlRoot("Product")]
    public class ProductDTO : ISerializable
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public int ProductQuantity { get; set; }

        public string ProductType { get; set; }

        public ProductDTO()
        {

        }

        public ProductDTO(int ID, string Name, float Price, int Qty, string Type)
        {
            ProductId = ID;
            ProductName = Name;
            ProductPrice = Price;
            ProductQuantity = Qty;
            ProductType = Type;
        }
    }
}
