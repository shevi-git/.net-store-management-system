

namespace Do;

/// <summary>
/// מוצר- record
/// </summary>
/// <param מספר מזהה יחודי="Id"></param>
/// <param מוצר="Name"></param>
/// <param קטגוריה="Category"></param>
/// <param מחיר="Price"></param>
/// <param כמות במלאי="CountStock"></param>

public record Product
    (
    int Id,
    string Name,
    Category Category,
    double Price,
    int CountStock
    )
{
    public Product(int id) : this()
    {
        this.Id = id;
    }
    public Product() : this(0, "", Category.ירקות, 0.0, 0)
    {

    }


}

