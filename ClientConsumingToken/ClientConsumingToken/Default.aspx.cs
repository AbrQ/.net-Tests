using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.AuthTokenSoapClient client = new ServiceReference1.AuthTokenSoapClient();

        ServiceReference1.SecuredTokenWebService securedToken = new ServiceReference1.SecuredTokenWebService
        {
            UserName = txtUsername.Text.Trim(),
            Password = txtPassword.Text.Trim()
    };
        string token = client.AuthenticationUser(securedToken);

        if (token == "Invalid Username or Password")
        {
            lblToken.Text = token;
        }
        else
        {
            lblToken.Text = token;
            securedToken.AuthenticationToken = token;
            lblHelloWorldResponse.Text = client.HelloWorld(securedToken);
        }

        lblHelloWorldResponse.Text = client.HelloWorld(securedToken);
    }
}