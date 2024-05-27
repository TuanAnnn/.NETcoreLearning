using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace api.Models;

[Table("Stocks")]
public class Stock
{
    public int Id { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal Purchase { set; get; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal LastDiv { set; get; }

    public string Industry { get; set; } = string.Empty;
    
    public long MarketCap { set; get; }

    public List<Comment> Comments { get; set; } = new List<Comment>();
}