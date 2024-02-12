namespace WebApplication4.Models;

public partial class TblNhacc
{
    public string Manhacc { get; set; } = null!;

    public string? Tennhacc { get; set; }

    public string? Diachi { get; set; }

    public string? Dienthoai { get; set; }

    public virtual ICollection<TblDondh> TblDondhs { get; set; } = new List<TblDondh>();
}
