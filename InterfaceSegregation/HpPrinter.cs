﻿namespace InterfaceSegregation;

public class HpPrinter : IMultiFunction
{
    //this machine doesn't have abitlity to send fax
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
      
    }

    public void InternetFax()
    {
       
    }
}