using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de AuthToken
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class AuthToken : System.Web.Services.WebService
{

    public SecuredTokenWebService SoapHeader;

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public string AuthenticationUser()
    {
        if (SoapHeader == null)
        {
            return "Please provide Username and Password";
        }
        if (string.IsNullOrEmpty(SoapHeader.UserName) || string.IsNullOrEmpty(SoapHeader.Password))
        {
            return "Please provide Username and Password";
        }

        //Check is user credential valid

        if (!SoapHeader.IsUserCredentialsValid(SoapHeader.UserName, SoapHeader.Password))
        {
            return "Invalid Username or Password";
        }

        //Create and store the AuthenticatedToken before returning it

        string token = Guid.NewGuid().ToString();
        HttpRuntime.Cache.Add(token, 
                              SoapHeader.UserName, 
                              null, 
                              System.Web.Caching.Cache.NoAbsoluteExpiration,
                              TimeSpan.FromMinutes(30),
                              System.Web.Caching.CacheItemPriority.NotRemovable,
                              null
                              );

        return token;
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public string HelloWorld()
    {
        if(SoapHeader == null)
        {
            return "Please call AuthenticationMethod() first";
        }
        if (!SoapHeader.IsUserCredentialsValid(SoapHeader))
        {
            return "Please call AuthenticationMethod() first";
        }
        return "Hello " + HttpRuntime.Cache[SoapHeader.AuthenticationToken];
    }

}
