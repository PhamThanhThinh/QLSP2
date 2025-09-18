namespace QLSP2.Models
{
  public class Product
  {
    // thường thường dùng int
    //public int Id { get; set; }
    // dùng Guid
    // ví dụ: 123xxx-456abc...
    public Guid Id { get; set; }
    public string Name { get; set; }

    // giá - đô la - usd
    // ví dụ: 1usd, 1.5usd
    // c# double -> sql float
    public double Price { get; set; }

    // số lượng
    public int Quantity { get; set; }
  }
}
