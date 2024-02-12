

namespace WebApplication4.Models;

public partial class TblCtpnhap
{
    public string SoPn { get; set; } = null!;

    public string MaVtu { get; set; } = null!;

    public int? Slnhap { get; set; }

    public virtual TblVattu MaVtuNavigation { get; set; } = null!;

    public virtual TblPnhap SoPnNavigation { get; set; } = null!;

    public static implicit operator TblCtpnhap(TblPnhap v)
    {
        throw new NotImplementedException();
    }
}
