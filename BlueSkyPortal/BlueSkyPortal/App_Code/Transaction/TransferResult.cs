using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TransferResult
/// </summary>
public class TransferResult
{
    public string caller_contract_address { get; set; }
    public TransferWalletInfo result { get; set; }

}

public class TransferWalletInfo
{
    public string from { get; set; }
    public string to { get; set; }
    public long value { get; set; }
}