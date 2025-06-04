

namespace Do;
[Serializable]
public class DalExist:Exception
{
    public DalExist(string messag):base(messag)
    {
        
    }
    public DalExist(string massage, Exception innerException) : base(massage, innerException) { }
}
[Serializable]
public class DalNotExist : Exception
{
    public DalNotExist(string messag) : base(messag)
    {

    }
    public DalNotExist(string massage, Exception innerException) : base(massage, innerException) { }
}


