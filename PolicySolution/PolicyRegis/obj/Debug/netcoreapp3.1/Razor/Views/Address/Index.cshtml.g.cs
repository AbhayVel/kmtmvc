#pragma checksum "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a132cfc1bdc3c4edfb2b41e34a5e03419ce0024b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Index), @"mvc.1.0.view", @"/Views/Address/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
using PolicyModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a132cfc1bdc3c4edfb2b41e34a5e03419ce0024b", @"/Views/Address/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1eaaf0428292e942010eaa94f937adde0591e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Address_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/address/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
  
    AddressSearch addressSearch = ViewBag.addressSearch as AddressSearch;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a132cfc1bdc3c4edfb2b41e34a5e03419ce0024b4357", async() => {
                WriteLiteral("\r\n    <div>\r\n        <div >\r\n            <label for=\"id\">\r\n                Id\r\n            </label>\r\n            <input type=\"text\" name=\"RecIDSearch\"");
                BeginWriteAttribute("value", " value=\"", 324, "\"", 358, 1);
#nullable restore
#line 14 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 332, addressSearch.RecIDSearch, 332, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        </div>\r\n        <div>\r\n            <label for=\"id\">\r\n                Id\r\n            </label>\r\n            <input type=\"text\" name=\"CustomerIDSearch\"");
                BeginWriteAttribute("value", " value=\"", 523, "\"", 562, 1);
#nullable restore
#line 21 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 531, addressSearch.CustomerIDSearch, 531, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        </div>\r\n        <div>\r\n            <label for=\"id\">\r\n                Id\r\n            </label>\r\n            <input type=\"text\" name=\"CustomerNameSearch\"");
                BeginWriteAttribute("value", " value=\"", 729, "\"", 770, 1);
#nullable restore
#line 28 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 737, addressSearch.CustomerNameSearch, 737, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        </div>\r\n\r\n        <input type=\"hidden\" name=\"OrderBy\" id=\"OrderBy\"");
                BeginWriteAttribute("value", " value=\"", 852, "\"", 882, 1);
#nullable restore
#line 32 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 860, addressSearch.OrderBy, 860, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"ColumnName\" id=\"ColumnName\"");
                BeginWriteAttribute("value", " value=\"", 950, "\"", 983, 1);
#nullable restore
#line 33 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 958, addressSearch.ColumnName, 958, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CurrentPage\" id=\"CurrentPage\"");
                BeginWriteAttribute("value", " value=\"", 1053, "\"", 1087, 1);
#nullable restore
#line 34 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 1061, addressSearch.CurrentPage, 1061, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n      \r\n        \r\n        <button id=\"btnSubmit\" type=\"submit\">Search</button>\r\n    </div>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"w3-table w3-table-all\">\r\n    <thead>\r\n        <tr>\r\n            <th><a onclick=\"sortData(\'id\')\"");
            BeginWriteAttribute("href", " href=\"", 1309, "\"", 1373, 2);
            WriteAttributeValue("", 1316, "/address/index?columnName=id&orderBy=", 1316, 37, true);
#nullable restore
#line 46 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 1353, ViewData["orderBy"], 1353, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Id</a> </th>\r\n            <th><a onclick=\"sortData(\'CustomerID\')\"");
            BeginWriteAttribute("href", " href=\"", 1440, "\"", 1512, 2);
            WriteAttributeValue("", 1447, "/address/index?columnName=CustomerID&orderBy=", 1447, 45, true);
#nullable restore
#line 47 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 1492, ViewData["orderBy"], 1492, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Customer Id</a></th>\r\n            <th> <a onclick=\"sortData(\'CustomerName\')\"");
            BeginWriteAttribute("href", " href=\"", 1590, "\"", 1664, 2);
            WriteAttributeValue("", 1597, "/address/index?columnName=CustomerName&orderBy=", 1597, 47, true);
#nullable restore
#line 48 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 1644, ViewData["orderBy"], 1644, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Customer</a></th>\r\n            <th> Address</th>\r\n            <th> PinCOde</th>\r\n            <th> STate</th>\r\n        </tr>\r\n    </thead>\r\n\r\n     <tbody>\r\n\r\n");
#nullable restore
#line 57 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td> ");
#nullable restore
#line 59 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
            Write(item.RecID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>  ");
#nullable restore
#line 60 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
             Write(item.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 61 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
            Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 62 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
             Write(item.Address1 +"," +item.Address2 +","+
            item.Address3);

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n            </td>\r\n             <td> ");
#nullable restore
#line 65 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
             Write(item.Pincode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td> ");
#nullable restore
#line 66 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
              Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n");
#nullable restore
#line 68 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
        }         

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 73 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
         if(addressSearch.CurrentPage==1)   {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2367, "\"", 2417, 3);
            WriteAttributeValue("", 2377, "pageChange(", 2377, 11, true);
#nullable restore
#line 75 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 2388, addressSearch.CurrentPage, 2388, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2416, ")", 2416, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 79 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2608, "\"", 2661, 3);
            WriteAttributeValue("", 2618, "pageChange(", 2618, 11, true);
#nullable restore
#line 81 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 2629, addressSearch.CurrentPage -1, 2629, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2660, ")", 2660, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 85 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n");
#nullable restore
#line 87 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
         for(int i=1;i<=addressSearch.PageCount;i++){
            if(i==addressSearch.CurrentPage){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"active\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 2958, "\"", 2982, 3);
            WriteAttributeValue("", 2968, "pageChange(", 2968, 11, true);
#nullable restore
#line 89 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 2979, i, 2979, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2981, ")", 2981, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 89 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 90 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
            }    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("onclick", " onclick=\"", 3053, "\"", 3077, 3);
            WriteAttributeValue("", 3063, "pageChange(", 3063, 11, true);
#nullable restore
#line 91 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 3074, i, 3074, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3076, ")", 3076, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 91 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 92 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
            }
           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        \r\n");
#nullable restore
#line 97 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
         if(addressSearch.CurrentPage==addressSearch.PageCount)    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3262, "\"", 3310, 3);
            WriteAttributeValue("", 3272, "pageChange(", 3272, 11, true);
#nullable restore
#line 99 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 3283, addressSearch.CurrentPage, 3283, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3309, ")", 3309, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                <span aria-hidden=\"true\">&raquo;</span>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 103 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3485, "\"", 3538, 3);
            WriteAttributeValue("", 3495, "pageChange(", 3495, 11, true);
#nullable restore
#line 105 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
WriteAttributeValue("", 3506, addressSearch.CurrentPage +1, 3506, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3537, ")", 3537, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 109 "D:\SarthakMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Address\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"       
    </ul>
</nav>

<script>

    function pageChange(currentPage){
        event.preventDefault();       
       var cp= $(""#CurrentPage"").val();
                   debugger;
        if (cp == currentPage){
            return;
        }

        $(""#CurrentPage"").val(currentPage);
        $(""#btnSubmit"").click();
    }

    function sortData(columnName){
        event.preventDefault();
         var orderBy= $(""#OrderBy"").val();

         if(orderBy=='desc'){
            orderBy = 'asc'
         }   else {
            orderBy = 'desc'
         }

        $(""#OrderBy"").val(orderBy)
        $(""#ColumnName"").val(columnName)

        $(""#btnSubmit"").click();
    }

</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Address>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
