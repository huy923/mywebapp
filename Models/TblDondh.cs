namespace WebApplication4.Models;

public partial class TblDondh
{
    public int SoDh { get; set; }

    public DateTime? NgayDh { get; set; }

    public string? Manhacc { get; set; }

    public virtual TblNhacc? ManhaccNavigation { get; set; }

    public virtual ICollection<TblCtdondh> TblCtdondhs { get; set; } = new List<TblCtdondh>();

    public virtual ICollection<TblPnhap> TblPnhaps { get; set; } = new List<TblPnhap>();
}
