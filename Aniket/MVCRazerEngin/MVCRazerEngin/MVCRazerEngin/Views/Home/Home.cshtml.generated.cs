using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using MVCRazerEngin;


namespace KmiViews
{
    public partial class _Views_Home_Index_cshtml : KmiWebViewPage<MVCRazerEngin.Models.Employee>
    {
        public _Views_Home_Index_cshtml()
        {

        }
        public override void Execute()
        {
            WriteLiteral("<html><head>    <title></title>    <script></script></head><body>    <p><h2>Index</h2></p>    <table>        ");
            for (int i = 0; i <= 5; i++)
            {
                if (i == 2)
                {
                    WriteLiteral("<tr>                    <td  class=\"");
                    Write(i == 0 ? "a1" : "a2");
                    WriteLiteral(")\" >");
                    Write(i);
                    WriteLiteral("</td>                </tr>            ");

                }
                WriteLiteral("<tr>                <td>");
                Write(i + 1);
                WriteLiteral(")</td>            </tr>        ");

            }
            WriteLiteral("</table></body></html>");
        }
    }

}
