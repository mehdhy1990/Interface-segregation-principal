namespace InterfaceSegregation;

public class XeroxWorkCenter : IMultiFunction
{
    //this is a poor design for an Interface
    public void Print()
    {
        throw new NotImplementedException();
    }

    public void GetPrintDetail()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }

    public void ScanPhoto()
    {
        throw new NotImplementedException();
    }

    public void Fax()
    {
        throw new NotImplementedException();
    }

    public void InternetFax()
    {
        throw new NotImplementedException();
    }
}