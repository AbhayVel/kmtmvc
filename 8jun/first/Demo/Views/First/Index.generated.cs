#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Demo;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/First/Index.cshtml")]
    public partial class _Views_First_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_First_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\First\Index.cshtml"
  
    ViewBag.Title = "Index";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Index</h2>\r\n\r\n<form");

WriteLiteral(" action=\"/home/save\"");

WriteLiteral(" method=\"get\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"Id\"");

WriteLiteral(">ID:</label>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"Id\"");

WriteLiteral(" id=\"email\"");

WriteAttribute("value", Tuple.Create(" value=\"", 235), Tuple.Create("\"", 252)
            
            #line 11 "..\..\Views\First\Index.cshtml"
, Tuple.Create(Tuple.Create("", 243), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 243), false)
);

WriteLiteral(">\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"FirstName\"");

WriteLiteral(">FirstName:</label>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"FirstName\"");

WriteLiteral(" id=\"FirstName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 428), Tuple.Create("\"", 452)
            
            #line 15 "..\..\Views\First\Index.cshtml"
        , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.FirstName
            
            #line default
            #line hidden
, 436), false)
);

WriteLiteral(">\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"LastName\"");

WriteLiteral(">LastName:</label>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"LastName\"");

WriteLiteral(" id=\"LastName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 626), Tuple.Create("\"", 649)
            
            #line 20 "..\..\Views\First\Index.cshtml"
      , Tuple.Create(Tuple.Create("", 634), Tuple.Create<System.Object, System.Int32>(Model.LastName
            
            #line default
            #line hidden
, 634), false)
);

WriteLiteral(">\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"Age\"");

WriteLiteral(">Age:</label>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"Age\"");

WriteLiteral(" name=\"Age\"");

WriteAttribute("value", Tuple.Create(" value=\"", 803), Tuple.Create("\"", 821)
            
            #line 25 "..\..\Views\First\Index.cshtml"
, Tuple.Create(Tuple.Create("", 811), Tuple.Create<System.Object, System.Int32>(Model.Age
            
            #line default
            #line hidden
, 811), false)
);

WriteLiteral(">\r\n    </div>\r\n    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">Submit</button>\r\n</form>\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
