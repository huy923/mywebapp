namespace WebApplication4.Models;

public partial class TblPxuat
{
    public string SoPx { get; set; } = null!;

    public DateTime? Ngayxuat { get; set; }

    public virtual ICollection<TblCtpxuat> TblCtpxuats { get; set; } = new List<TblCtpxuat>();
}
