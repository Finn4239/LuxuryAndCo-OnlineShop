namespace LuxuryAndCo.OnlineShop.Models;

public class PDPViewModel
{
    public string Brand { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public List<string> ImageUrls { get; set; } = new List<string>();
    
}