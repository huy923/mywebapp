namespace WebApplication4.Models;

public partial class TblTonkho
{
    public string? Namthang { get; set; }

    public string? MaVtu { get; set; }

    public int? Tongnhap { get; set; }

    public int? Tongxuat { get; set; }

    public int? Sltonkho { get; set; }

    public virtual TblVattu? MaVtuNavigation { get; set; }
}
