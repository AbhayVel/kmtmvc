#pragma checksum "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823d2db5eed713c2863ae2b3e03670045c691be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PolicyDtls_Index), @"mvc.1.0.view", @"/Views/PolicyDtls/Index.cshtml")]
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
#line 1 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
using PolicyModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823d2db5eed713c2863ae2b3e03670045c691be3", @"/Views/PolicyDtls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1eaaf0428292e942010eaa94f937adde0591e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PolicyDtls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PolicyDtls>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/policydtls/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
  
    PolicySearch policySearch = ViewBag.policySearch as PolicySearch;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823d2db5eed713c2863ae2b3e03670045c691be34365", async() => {
                WriteLiteral("\r\n    <div>\r\n        <div>\r\n            <label for=\"id\">\r\n                Rec Id\r\n            </label>\r\n            <input type=\"text\" name=\"RecIDSearch\"");
                BeginWriteAttribute("value", " value=\"", 329, "\"", 362, 1);
#nullable restore
#line 14 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 337, policySearch.RecIDSearch, 337, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        </div>\r\n        <div>\r\n            <label for=\"id\">\r\n                Customer Id\r\n            </label>\r\n            <input type=\"text\" name=\"CustomerIDSearch\"");
                BeginWriteAttribute("value", " value=\"", 536, "\"", 570, 1);
#nullable restore
#line 21 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 544, policySearch.CustIDSearch, 544, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        </div>\r\n        <div>\r\n            <label for=\"id\">\r\n                Policyname\r\n            </label>\r\n            <input type=\"text\" name=\"Policyname\"");
                BeginWriteAttribute("value", " value=\"", 737, "\"", 769, 1);
#nullable restore
#line 28 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 745, policySearch.Policyname, 745, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        </div>\r\n\r\n        <input type=\"hidden\" name=\"OrderBy\" id=\"OrderBy\"");
                BeginWriteAttribute("value", " value=\"", 851, "\"", 880, 1);
#nullable restore
#line 32 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 859, policySearch.OrderBy, 859, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"ColumnName\" id=\"ColumnName\"");
                BeginWriteAttribute("value", " value=\"", 948, "\"", 980, 1);
#nullable restore
#line 33 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 956, policySearch.ColumnName, 956, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CurrentPage\" id=\"CurrentPage\"");
                BeginWriteAttribute("value", " value=\"", 1050, "\"", 1083, 1);
#nullable restore
#line 34 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1058, policySearch.CurrentPage, 1058, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n        <button id=\"btnSubmit\" type=\"submit\">Search</button>\r\n    </div>\r\n\r\n\r\n");
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
            BeginWriteAttribute("href", " href=\"", 1291, "\"", 1361, 2);
            WriteAttributeValue("", 1298, "/policydtls/index?columnName=RecID&orderBy=", 1298, 43, true);
#nullable restore
#line 46 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1341, ViewData["orderBy"], 1341, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Id </a></th>\r\n            <th><a onclick=\"sortData(\'CustID\')\"");
            BeginWriteAttribute("href", " href=\"", 1425, "\"", 1496, 2);
            WriteAttributeValue("", 1432, "/policydtls/index?columnName=CustID&orderBy=", 1432, 44, true);
#nullable restore
#line 47 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1476, ViewData["orderBy"], 1476, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Customer ID </a></th>\r\n            \r\n            <th>Policyname</th>\r\n            <th>PolicyStatus</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 56 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 59 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.RecID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 60 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.CustID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 61 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.Policyname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 62 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PolicyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 65 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 70 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         if (policySearch.CurrentPage == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2070, "\"", 2119, 3);
            WriteAttributeValue("", 2080, "pageChange(", 2080, 11, true);
#nullable restore
#line 73 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2091, policySearch.CurrentPage, 2091, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2118, ")", 2118, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 77 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2328, "\"", 2380, 3);
            WriteAttributeValue("", 2338, "pageChange(", 2338, 11, true);
#nullable restore
#line 81 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2349, policySearch.CurrentPage -1, 2349, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2379, ")", 2379, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 85 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 87 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         for (int i = 1; i <= policySearch.PageCount; i++)
        {
            if (i == policySearch.CurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"active\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 2701, "\"", 2725, 3);
            WriteAttributeValue("", 2711, "pageChange(", 2711, 11, true);
#nullable restore
#line 91 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2722, i, 2722, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2724, ")", 2724, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 91 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 92 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("onclick", " onclick=\"", 2819, "\"", 2843, 3);
            WriteAttributeValue("", 2829, "pageChange(", 2829, 11, true);
#nullable restore
#line 95 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2840, i, 2840, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2842, ")", 2842, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 95 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 96 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 101 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         if (policySearch.CurrentPage == policySearch.PageCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3012, "\"", 3059, 3);
            WriteAttributeValue("", 3022, "pageChange(", 3022, 11, true);
#nullable restore
#line 104 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3033, policySearch.CurrentPage, 3033, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3058, ")", 3058, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 108 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3264, "\"", 3316, 3);
            WriteAttributeValue("", 3274, "pageChange(", 3274, 11, true);
#nullable restore
#line 112 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3285, policySearch.CurrentPage +1, 3285, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3315, ")", 3315, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 116 "D:\PolicySolution\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </ul>
</nav>

<script>

    function pageChange(currentPage) {
        event.preventDefault();
        var cp = $(""#CurrentPage"").val();
        debugger;
        if (cp == currentPage) {
            return;
        }

        $(""#CurrentPage"").val(currentPage);
        $(""#btnSubmit"").click();
    }
    //JS function to sort data
    function sortData(columnName) {
        event.preventDefault();     //cancels the event if it is cancelable,
        //meaning that the default action that belongs to the event will not occur.
        var orderBy = $(""#OrderBy"").val();

        if (orderBy == 'desc') {
            orderBy = 'asc'
        } else {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PolicyDtls>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
