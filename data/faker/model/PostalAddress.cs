public class PostalAddress
{
    // Conditional.
    public string? Dept { get; set; }
    public string? SubDept { get; set; }
    public string? Flr { get; set; }

    // Optional.
    public string? StrtNm { get; set; }
    public string? BldgNb { get; set; }
    public string? BldgNm { get; set; }
    public string? Room { get; set; }
    public string? TwnLctnNm { get; set; }
    public string? DstrctNm { get; set; }
    public string? CtrySubDvsn { get; set; }

    // Expected.
    public string? PstCd { get; set; }

    // Mandatory.
    public string? TwnNm { get; set; }
    public string? Ctry  { get; set; }
}