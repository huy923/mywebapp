
namespace WebApplication4.Models;

public partial class TblCtdondh
{
    public int SoDh { get; set; }

    public string MaVtu { get; set; } = null!;

    public int? Sldat { get; set; }

    public virtual TblVattu MaVtuNavigation { get; set; } = null!;

    public virtual TblDondh SoDhNavigation { get; set; } = null!;
}
