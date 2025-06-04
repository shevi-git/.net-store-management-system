

namespace Do;


/// <summary>
/// מבצע-record
/// </summary>
/// <param מספר מזהה יחודי="NumIdentify"></param>
/// <param מספר מזהה של המוצר="NumIdentifyProduct"></param>
/// <param כמות נדרשת לקבלת המבצע="CountForSale"></param>
/// <param  מחיר כולל במבצע="PriceInSale"></param>
/// <param האם המבצע מיועד לכלל הלקוחות="AllCustomers"></param>
/// <param תאריך תחילת המבצע="DateStartSale"></param>
/// <param תאריך סיום המבצע="DateEndSale"></param>
public record Sale
    (
    int NumIdentify,
    int NumIdentifyProduct,
    int CountForSale,
    int PriceInSale,
    bool AllCustomers,
    DateTime DateStartSale,
    DateTime DateEndSale
    )
{
    //בנאי ברירת מחדל ע"מ לקדם את המספר מזהה יחודי אוטומטי
    public Sale() : this(0,0, 0, 0, false, DateTime.MinValue, DateTime.MinValue)
    {
        
    }
    
    public Sale(int NumIdentify):this()
    {
        this.NumIdentify = NumIdentify;
    }

   
    
}