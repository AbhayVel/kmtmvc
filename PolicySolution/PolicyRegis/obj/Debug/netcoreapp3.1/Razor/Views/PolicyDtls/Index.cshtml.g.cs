#pragma checksum "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a8a14b7ded8a4599c242d6c7e3f254caf6ff46"
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
#line 1 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
using PolicyModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a8a14b7ded8a4599c242d6c7e3f254caf6ff46", @"/Views/PolicyDtls/Index.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
  
    PolicySearch policySearch = ViewBag.policySearch as PolicySearch;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3a8a14b7ded8a4599c242d6c7e3f254caf6ff464480", async() => {
                WriteLiteral(@" 

    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js""></script>
    <style>
         input[type=text] {
            width: 10%;
            padding: 8px 8px;
            margin: 2px 0;
            box-sizing: border-box;
            border: 1px solid #ccc;
            -webkit-transition: 0.5s;
            transition: 0.5s;
            outline: none;
            
        }

            input[type=text]:focus {
                border: 3px solid #555;
            }
        .header {
            background-color: #f1f1f1;
            padding: 20px;
            text-align: center;
        }

        .footer {
            background-color: #f1f1f1;
            padding: 20px;
            text-align: center;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"header\">\r\n    <h1>Policy Search </h1>\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3a8a14b7ded8a4599c242d6c7e3f254caf6ff466521", async() => {
                WriteLiteral("\r\n    <div>\r\n        <table>\r\n            <thead> \r\n        <div>\r\n            <label for=\"id\">\r\n                         Rec id\r\n            </label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <input type=\"text\" name=\"RecIDSearch\"");
                BeginWriteAttribute("value", " value=\"", 1500, "\"", 1533, 1);
#nullable restore
#line 54 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1508, policySearch.RecIDSearch, 1508, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" /><br />

                </div>
                <br />
            </thead>
            <thead>
        <div>
            <label for=""id"">
                        Customer Id
                    </label>
            <input type=""text"" name=""CustomerIDSearch""");
                BeginWriteAttribute("value", " value=\"", 1804, "\"", 1838, 1);
#nullable restore
#line 64 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1812, policySearch.CustIDSearch, 1812, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" /><br />

                </div>
                <br />
            </thead>
            <thead>
        <div>
            <label for=""id"">
                          Policyname 
            </label>
            <input type=""text"" name=""Policyname""");
                BeginWriteAttribute("value", " value=\"", 2097, "\"", 2129, 1);
#nullable restore
#line 74 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2105, policySearch.Policyname, 2105, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n        </div><br />\r\n            </thead>\r\n        </table>\r\n\r\n        <input type=\"hidden\" name=\"OrderBy\" id=\"OrderBy\"");
                BeginWriteAttribute("value", " value=\"", 2263, "\"", 2292, 1);
#nullable restore
#line 80 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2271, policySearch.OrderBy, 2271, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"ColumnName\" id=\"ColumnName\"");
                BeginWriteAttribute("value", " value=\"", 2360, "\"", 2392, 1);
#nullable restore
#line 81 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2368, policySearch.ColumnName, 2368, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CurrentPage\" id=\"CurrentPage\"");
                BeginWriteAttribute("value", " value=\"", 2462, "\"", 2495, 1);
#nullable restore
#line 82 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2470, policySearch.CurrentPage, 2470, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n        <button id=\"btnSubmit\" type=\"submit\">Search</button>\r\n        <button id=\"btnpage1\" class=\"btn btn-outline-success\" type=\"submit\" formaction=\"/PolicyDtls/page1\" formmethod=\"get\">page1</button>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n\r\n<table class=\"w3-table w3-table-all\">\r\n    <thead>\r\n        <tr>\r\n            <th><a onclick=\"sortData(\'id\')\"");
            BeginWriteAttribute("href", " href=\"", 2845, "\"", 2915, 2);
            WriteAttributeValue("", 2852, "/policydtls/index?columnName=RecID&orderBy=", 2852, 43, true);
#nullable restore
#line 96 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2895, ViewData["orderBy"], 2895, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Id </a></th>\r\n            <th><a onclick=\"sortData(\'CustID\')\"");
            BeginWriteAttribute("href", " href=\"", 2979, "\"", 3050, 2);
            WriteAttributeValue("", 2986, "/policydtls/index?columnName=CustID&orderBy=", 2986, 44, true);
#nullable restore
#line 97 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3030, ViewData["orderBy"], 3030, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Customer ID </a></th>\r\n            \r\n            <th>Policyname</th>\r\n            <th>PolicyStatus</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 106 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 109 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.RecID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 110 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.CustID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 111 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.Policyname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 112 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PolicyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 115 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 120 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         if (policySearch.CurrentPage == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3624, "\"", 3673, 3);
            WriteAttributeValue("", 3634, "pageChange(", 3634, 11, true);
#nullable restore
#line 123 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3645, policySearch.CurrentPage, 3645, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3672, ")", 3672, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 127 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3882, "\"", 3934, 3);
            WriteAttributeValue("", 3892, "pageChange(", 3892, 11, true);
#nullable restore
#line 131 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3903, policySearch.CurrentPage -1, 3903, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3933, ")", 3933, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 135 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 137 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         for (int i = 1; i <= policySearch.PageCount; i++)
        {
            if (i == policySearch.CurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"active\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 4255, "\"", 4279, 3);
            WriteAttributeValue("", 4265, "pageChange(", 4265, 11, true);
#nullable restore
#line 141 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4276, i, 4276, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4278, ")", 4278, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 141 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 142 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("onclick", " onclick=\"", 4373, "\"", 4397, 3);
            WriteAttributeValue("", 4383, "pageChange(", 4383, 11, true);
#nullable restore
#line 145 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4394, i, 4394, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4396, ")", 4396, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 145 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 146 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 151 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
         if (policySearch.CurrentPage == policySearch.PageCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4566, "\"", 4613, 3);
            WriteAttributeValue("", 4576, "pageChange(", 4576, 11, true);
#nullable restore
#line 154 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4587, policySearch.CurrentPage, 4587, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4612, ")", 4612, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 158 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4818, "\"", 4870, 3);
            WriteAttributeValue("", 4828, "pageChange(", 4828, 11, true);
#nullable restore
#line 162 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4839, policySearch.CurrentPage +1, 4839, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4869, ")", 4869, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 166 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
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

</script>
<div class=""footer"">
    <footer>
        <div class=""spinner-border text-muted""></div>
        <div class=""spinner-border text-primary""></div>
        <div cla");
            WriteLiteral(@"ss=""spinner-border text-success""></div>
        <div class=""spinner-border text-info""></div>
        <div class=""spinner-border text-warning""></div>
        <div class=""spinner-border text-danger""></div>
        <div class=""spinner-border text-secondary""></div>
        <div class=""spinner-border text-dark""></div>
        <div class=""spinner-border text-light""></div>
    </footer>
</div>");
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
