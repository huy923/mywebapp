namespace WebApplication4.Models;

public partial class TblPnhap
{
    public string SoPn { get; set; } = null!;

    public int? SoDh { get; set; }

    public DateTime? Ngaynhap { get; set; }

    public virtual TblDondh? SoDhNavigation { get; set; }

    public virtual ICollection<TblCtpnhap> TblCtpnhaps { get; set; } = new List<TblCtpnhap>();

    public static implicit operator TblPnhap(TblCtpnhap v)
    {
        throw new NotImplementedException();
    }
}
