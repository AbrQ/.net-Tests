using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SecuredTokenWebService
/// </summary>
public class SecuredTokenWebService : System.Web.Services.Protocols.SoapHeader
{

    public string UserName { get; set; }
    public string Password { get; set; }
    public string AuthenticationToken { get; set; }

    public bool IsUserCredentialsValid(string UserName, string Password)
    {
        if (UserName == "admin" && Password == "admin")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsUserCredentialsValid(SecuredTokenWebService SoapHeader)
    {
        if(SoapHeader == null)
        {
            return false;
        }

        //Exists token in cache?
        if (!string.IsNullOrEmpty(SoapHeader.AuthenticationToken))
        {
            return (HttpRuntime.Cache[SoapHeader.AuthenticationToken] != null);
        }

        return false;
    }
}