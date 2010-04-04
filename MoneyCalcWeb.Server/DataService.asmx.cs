using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MoneyCalcWeb.Server
{
    /// <summary>
    /// Summary description for DataService
    /// </summary>
    [WebService(Namespace = "http://MoneyCalcWeb.Site/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public string HelloWorld()
        {

            

            if (Context.Request.Cookies["userID"] == null)
            {
                Context.Response.Cookies.Add(new HttpCookie("userID", "1"));
                return "Cookies is Empty";
            }
            else
            {
                var cookie = Context.Request.Cookies["userID"];
                cookie.Value = (Convert.ToInt32(cookie.Value) + 1).ToString();
                Context.Response.Cookies.Add(cookie);
                return string.Format("Cookies['userID'] = {0}", cookie.Value);
            }
        }
    }
}
