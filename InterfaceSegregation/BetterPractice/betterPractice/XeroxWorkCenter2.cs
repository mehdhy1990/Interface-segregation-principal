namespace InterfaceSegregation.BetterPractice.betterPractice;

public class XeroxWorkCenter2 :IPrint,IScan,IFax
{
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