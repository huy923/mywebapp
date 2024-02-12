namespace WebApplication4.Models;

public partial class TblVattu
{
    public string MaVtu { get; set; } = null!;

    public string? TenVtu { get; set; }

    public string? Dvtinh { get; set; }

    public int? Dongia { get; set; }

    public virtual ICollection<TblCtdondh> TblCtdondhs { get; set; } = new List<TblCtdondh>();

    public virtual ICollection<TblCtpnhap> TblCtpnhaps { get; set; } = new List<TblCtpnhap>();

    public virtual ICollection<TblCtpxuat> TblCtpxuats { get; set; } = new List<TblCtpxuat>();
}
