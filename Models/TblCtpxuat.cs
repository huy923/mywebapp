namespace WebApplication4.Models;

public partial class TblCtpxuat
{
    public string SoPx { get; set; } = null!;

    public string MaVtu { get; set; } = null!;

    public int? Slxuat { get; set; }

    public virtual TblVattu MaVtuNavigation { get; set; } = null!;

    public virtual TblPxuat SoPxNavigation { get; set; } = null!;
}
