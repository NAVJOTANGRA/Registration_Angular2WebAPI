using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Petroit.BuisnessLogic
{
    public class SessionCLass
    {

        string pSession = string.Empty;
        private HttpContext _executingPage;

        public SessionCLass()
        {

           
            var context = new HttpContextWrapper(HttpContext.Current);
            var rd = context.Request.RequestContext.RouteData;
            string controller = rd.GetRequiredString("controller");

            pSession = controller;
            _executingPage = HttpContext.Current;
        }
        public string SessionID
        {
            get
            {
                return _executingPage.Session.SessionID.ToString();
            }

        }
        public Int64 ProjectId
        {
            get
            {
                if (_executingPage.Session["ProjectId"] != null)
                {
                    return (Int64)_executingPage.Session["ProjectId"];
                }
                else { return 1; }
            }
            set { _executingPage.Session["ProjectId"] = value; }
        }
    }
}