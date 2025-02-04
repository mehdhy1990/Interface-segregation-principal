namespace InterfaceSegregation;

public class CanonPrinter : IMultiFunction
{
    //this device has only abitliy to print
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
      
    }

    public void ScanPhoto()
    {
       
    }

    public void Fax()
    {
        
    }

    public void InternetFax()
    {
       
    }
}