using System;
namespace api.Models;

public class Comment
{
    public int Id { set; get; }
    
    public string Title { set; get; } = string.Empty;

    public string Content { set; get; } = string.Empty;
    
    public DateTime CreatedOn { get; set; }= DateTime.Now;
    
    public int? StockId { get; set; }
    
    public Stock? Stock { set; get; }
}