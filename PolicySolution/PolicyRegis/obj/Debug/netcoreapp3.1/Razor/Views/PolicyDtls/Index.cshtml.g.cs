<<<<<<< HEAD
#pragma checksum "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a8a14b7ded8a4599c242d6c7e3f254caf6ff46"
=======
#pragma checksum "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b00242be99530592140a92421e8d3a372d72cab7"
>>>>>>> refs/remotes/origin/main
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
<<<<<<< HEAD
#line 1 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
=======
#line 1 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
>>>>>>> refs/remotes/origin/main
using PolicyRegis;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
=======
#line 2 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
>>>>>>> refs/remotes/origin/main
using PolicyRegis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 2 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
using PolicyModels;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a8a14b7ded8a4599c242d6c7e3f254caf6ff46", @"/Views/PolicyDtls/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00242be99530592140a92421e8d3a372d72cab7", @"/Views/PolicyDtls/Index.cshtml")]
>>>>>>> refs/remotes/origin/main
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
<<<<<<< HEAD
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
=======
>>>>>>> refs/remotes/origin/main
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 4 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 4 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
  
    PolicySearch policySearch = ViewBag.policySearch as PolicySearch;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
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
#line 54 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1508, policySearch.RecIDSearch, 1508, 25, false);
=======
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00242be99530592140a92421e8d3a372d72cab74385", async() => {
                WriteLiteral(@"
    <div class=""table-responsive"">


        <table class=""table"">
            <thead> 
        <div>
            <label for=""id"">
                         Rec id
            </label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type=""text"" name=""RecIDSearch""");
                BeginWriteAttribute("value", " value=\"", 474, "\"", 507, 1);
#nullable restore
#line 18 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 482, policySearch.RecIDSearch, 482, 25, false);
>>>>>>> refs/remotes/origin/main

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
<<<<<<< HEAD
                BeginWriteAttribute("value", " value=\"", 1804, "\"", 1838, 1);
#nullable restore
#line 64 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1812, policySearch.CustIDSearch, 1812, 26, false);
=======
                BeginWriteAttribute("value", " value=\"", 778, "\"", 812, 1);
#nullable restore
#line 28 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 786, policySearch.CustIDSearch, 786, 26, false);
>>>>>>> refs/remotes/origin/main

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
<<<<<<< HEAD
                BeginWriteAttribute("value", " value=\"", 2097, "\"", 2129, 1);
#nullable restore
#line 74 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2105, policySearch.Policyname, 2105, 24, false);
=======
                BeginWriteAttribute("value", " value=\"", 1071, "\"", 1103, 1);
#nullable restore
#line 38 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1079, policySearch.Policyname, 1079, 24, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n        </div><br />\r\n            </thead>\r\n        </table>\r\n\r\n        <input type=\"hidden\" name=\"OrderBy\" id=\"OrderBy\"");
<<<<<<< HEAD
                BeginWriteAttribute("value", " value=\"", 2263, "\"", 2292, 1);
#nullable restore
#line 80 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2271, policySearch.OrderBy, 2271, 21, false);
=======
                BeginWriteAttribute("value", " value=\"", 1237, "\"", 1266, 1);
#nullable restore
#line 44 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1245, policySearch.OrderBy, 1245, 21, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"ColumnName\" id=\"ColumnName\"");
<<<<<<< HEAD
                BeginWriteAttribute("value", " value=\"", 2360, "\"", 2392, 1);
#nullable restore
#line 81 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2368, policySearch.ColumnName, 2368, 24, false);
=======
                BeginWriteAttribute("value", " value=\"", 1334, "\"", 1366, 1);
#nullable restore
#line 45 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1342, policySearch.ColumnName, 1342, 24, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CurrentPage\" id=\"CurrentPage\"");
<<<<<<< HEAD
                BeginWriteAttribute("value", " value=\"", 2462, "\"", 2495, 1);
#nullable restore
#line 82 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2470, policySearch.CurrentPage, 2470, 25, false);
=======
                BeginWriteAttribute("value", " value=\"", 1436, "\"", 1469, 1);
#nullable restore
#line 46 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1444, policySearch.CurrentPage, 1444, 25, false);
>>>>>>> refs/remotes/origin/main

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
<<<<<<< HEAD
            BeginWriteAttribute("href", " href=\"", 2845, "\"", 2915, 2);
            WriteAttributeValue("", 2852, "/policydtls/index?columnName=RecID&orderBy=", 2852, 43, true);
#nullable restore
#line 96 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2895, ViewData["orderBy"], 2895, 20, false);
=======
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1889, 2);
            WriteAttributeValue("", 1826, "/policydtls/index?columnName=RecID&orderBy=", 1826, 43, true);
#nullable restore
#line 60 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 1869, ViewData["orderBy"], 1869, 20, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Id </a></th>\r\n            <th><a onclick=\"sortData(\'CustID\')\"");
<<<<<<< HEAD
            BeginWriteAttribute("href", " href=\"", 2979, "\"", 3050, 2);
            WriteAttributeValue("", 2986, "/policydtls/index?columnName=CustID&orderBy=", 2986, 44, true);
#nullable restore
#line 97 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3030, ViewData["orderBy"], 3030, 20, false);
=======
            BeginWriteAttribute("href", " href=\"", 1953, "\"", 2024, 2);
            WriteAttributeValue("", 1960, "/policydtls/index?columnName=CustID&orderBy=", 1960, 44, true);
#nullable restore
#line 61 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2004, ViewData["orderBy"], 2004, 20, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Customer ID </a></th>\r\n            \r\n            <th>Policyname</th>\r\n            <th>PolicyStatus</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 106 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 70 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
<<<<<<< HEAD
#line 109 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 73 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
                Write(item.RecID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
<<<<<<< HEAD
#line 110 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 74 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
                Write(item.CustID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
<<<<<<< HEAD
#line 111 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 75 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
                Write(item.Policyname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
<<<<<<< HEAD
#line 112 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 76 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
                Write(item.PolicyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 115 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 79 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
<<<<<<< HEAD
#line 120 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 84 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
         if (policySearch.CurrentPage == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
<<<<<<< HEAD
            BeginWriteAttribute("onclick", " onclick=\"", 3624, "\"", 3673, 3);
            WriteAttributeValue("", 3634, "pageChange(", 3634, 11, true);
#nullable restore
#line 123 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3645, policySearch.CurrentPage, 3645, 27, false);
=======
            BeginWriteAttribute("onclick", " onclick=\"", 2598, "\"", 2647, 3);
            WriteAttributeValue("", 2608, "pageChange(", 2608, 11, true);
#nullable restore
#line 87 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2619, policySearch.CurrentPage, 2619, 27, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 3672, ")", 3672, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 127 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
            WriteAttributeValue("", 2646, ")", 2646, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 91 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
<<<<<<< HEAD
            BeginWriteAttribute("onclick", " onclick=\"", 3882, "\"", 3934, 3);
            WriteAttributeValue("", 3892, "pageChange(", 3892, 11, true);
#nullable restore
#line 131 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3903, policySearch.CurrentPage -1, 3903, 30, false);
=======
            BeginWriteAttribute("onclick", " onclick=\"", 2856, "\"", 2908, 3);
            WriteAttributeValue("", 2866, "pageChange(", 2866, 11, true);
#nullable restore
#line 95 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 2877, policySearch.CurrentPage -1, 2877, 30, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 3933, ")", 3933, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 135 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
            WriteAttributeValue("", 2907, ")", 2907, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Previous\">\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 99 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 137 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 101 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
         for (int i = 1; i <= policySearch.PageCount; i++)
        {
            if (i == policySearch.CurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"active\"><a");
<<<<<<< HEAD
            BeginWriteAttribute("onclick", " onclick=\"", 4255, "\"", 4279, 3);
            WriteAttributeValue("", 4265, "pageChange(", 4265, 11, true);
#nullable restore
#line 141 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4276, i, 4276, 2, false);
=======
            BeginWriteAttribute("onclick", " onclick=\"", 3229, "\"", 3253, 3);
            WriteAttributeValue("", 3239, "pageChange(", 3239, 11, true);
#nullable restore
#line 105 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3250, i, 3250, 2, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 4278, ")", 4278, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 141 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
            WriteAttributeValue("", 3252, ")", 3252, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 105 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
<<<<<<< HEAD
#line 142 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 106 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
<<<<<<< HEAD
            BeginWriteAttribute("onclick", " onclick=\"", 4373, "\"", 4397, 3);
            WriteAttributeValue("", 4383, "pageChange(", 4383, 11, true);
#nullable restore
#line 145 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4394, i, 4394, 2, false);
=======
            BeginWriteAttribute("onclick", " onclick=\"", 3347, "\"", 3371, 3);
            WriteAttributeValue("", 3357, "pageChange(", 3357, 11, true);
#nullable restore
#line 109 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3368, i, 3368, 2, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 4396, ")", 4396, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 145 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
            WriteAttributeValue("", 3370, ")", 3370, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 109 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
<<<<<<< HEAD
#line 146 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 110 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 151 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
#line 115 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
         if (policySearch.CurrentPage == policySearch.PageCount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
<<<<<<< HEAD
            BeginWriteAttribute("onclick", " onclick=\"", 4566, "\"", 4613, 3);
            WriteAttributeValue("", 4576, "pageChange(", 4576, 11, true);
#nullable restore
#line 154 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4587, policySearch.CurrentPage, 4587, 25, false);
=======
            BeginWriteAttribute("onclick", " onclick=\"", 3540, "\"", 3587, 3);
            WriteAttributeValue("", 3550, "pageChange(", 3550, 11, true);
#nullable restore
#line 118 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3561, policySearch.CurrentPage, 3561, 25, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 4612, ")", 4612, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 158 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
            WriteAttributeValue("", 3586, ")", 3586, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 122 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
<<<<<<< HEAD
            BeginWriteAttribute("onclick", " onclick=\"", 4818, "\"", 4870, 3);
            WriteAttributeValue("", 4828, "pageChange(", 4828, 11, true);
#nullable restore
#line 162 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 4839, policySearch.CurrentPage +1, 4839, 30, false);
=======
            BeginWriteAttribute("onclick", " onclick=\"", 3792, "\"", 3844, 3);
            WriteAttributeValue("", 3802, "pageChange(", 3802, 11, true);
#nullable restore
#line 126 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
WriteAttributeValue("", 3813, policySearch.CurrentPage +1, 3813, 30, false);
>>>>>>> refs/remotes/origin/main

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 4869, ")", 4869, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 166 "D:\RajMVCNEW\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
=======
            WriteAttributeValue("", 3843, ")", 3843, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 130 "D:\abhay\Kmi89\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
>>>>>>> refs/remotes/origin/main
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
