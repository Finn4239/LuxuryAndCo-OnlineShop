namespace LuxuryAndCo.OnlineShop.Models;

public class FooterContentViewModel
{
    public string PageTitle
    { get; set; }
    
    public List<Section> Sections { get; set; } = new List<Section>();
}

public class Section
{
    public string Title { get; set; }   // h2
    public string Content { get; set; }
}