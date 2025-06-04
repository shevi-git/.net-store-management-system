

namespace Do;

/// <summary>
/// לקוח - record
/// </summary>
/// <param ת.ז="Tz"></param>
/// <param שם לקוח="NameCustomers"></param>
/// <param כתובת לקוח="Address"></param>
/// <param טלפון לקוח="Phone"></param>
public record Customer
    (
    int Tz,
    string NameCustomers,
    string Address,
    int Phone
    )
{
    public Customer():this(0,"","",0)
    {
        
    }

    public Customer(int Tz) : this()
    {
        this.Tz = Tz;
    }
}