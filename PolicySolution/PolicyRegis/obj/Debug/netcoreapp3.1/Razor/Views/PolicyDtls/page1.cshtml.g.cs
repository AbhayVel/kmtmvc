#pragma checksum "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\page1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1218f12969f279ec4aafe6d36c9506e0dfae9d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PolicyDtls_page1), @"mvc.1.0.view", @"/Views/PolicyDtls/page1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1218f12969f279ec4aafe6d36c9506e0dfae9d3a", @"/Views/PolicyDtls/page1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1eaaf0428292e942010eaa94f937adde0591e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PolicyDtls_page1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/PolicyDtls/save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1218f12969f279ec4aafe6d36c9506e0dfae9d3a4200", async() => {
                WriteLiteral(@"

    <link href=""e:\rajnewmvc\kmtmvc\policysolution\policyregis\views\policydtls\sty.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">

    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js""></script>
    <style>
        input[type=text] {
            width: 20%;
            padding: 10px 10px;
            margin: 2px 0;
            box-sizing: border-box;
            border: 2px solid #ccc;
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
   ");
                WriteLiteral("         padding: 20px;\r\n            text-align: center;\r\n        }\r\n\r\n    </style>\r\n");
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
            WriteLiteral("\r\n<div class=\"header\">\r\n    <h1>Policy Forms</h1>\r\n  \r\n</div>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1218f12969f279ec4aafe6d36c9506e0dfae9d3a6412", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1218f12969f279ec4aafe6d36c9506e0dfae9d3a6682", async() => {
                    WriteLiteral(@"

    <div class=""wrapper"" > 

          <div>
               <div>
                        <label for=""id"">
                        <h4>Rec ID</h4>
                        </label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input type=""text"" name=""RecID""");
                    BeginWriteAttribute("value", " value=\"", 1698, "\"", 1706, 0);
                    EndWriteAttribute();
                    WriteLiteral("placeholder=\"Enter your Rec-Id\" /><br /><br />\r\n                    ");
#nullable restore
#line 61 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\page1.cshtml"
               Write(Html.ValidationMessage("RecID"));

#line default
#line hidden
#nullable disable
                    WriteLiteral(";\r\n                    </div>\r\n                 <div>\r\n                         <label for=\"id\">\r\n                         <h4> Customer Id</h4>\r\n                         </label>\r\n                         <input type=\"text\" name=\"CustID\"");
                    BeginWriteAttribute("value", " value=\"", 2045, "\"", 2053, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Enter Your Customer ID\" /><br /><br />\r\n                    ");
#nullable restore
#line 68 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\page1.cshtml"
               Write(Html.ValidationMessage("CustID"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                 </div>\r\n                 <div>\r\n                          <label for=\"id\">\r\n                          <h4>  policy name </h4>\r\n                          </label>\r\n                           <input type=\"text\" name=\"Policyname\"");
                    BeginWriteAttribute("value", " value=\"", 2406, "\"", 2414, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Enter Your POLICY Name \" /><br /><br />\r\n                    ");
#nullable restore
#line 75 "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\page1.cshtml"
               Write(Html.ValidationMessage("Policyname"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                       </div>\r\n      \r\n                          \r\n                <button id=\"btnpage1\" class=\"btn btn-outline-success\" type=\"submit\">Save</button>\r\n                 </div>\r\n          </div>\r\n       \r\n");
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
                WriteLiteral(@"
<div class=""footer"">
    <footer>
        <div class=""spinner-border text-muted""></div>
        <div class=""spinner-border text-primary""></div>
        <div class=""spinner-border text-success""></div>
        <div class=""spinner-border text-info""></div>
        <div class=""spinner-border text-warning""></div>
        <div class=""spinner-border text-danger""></div>
        <div class=""spinner-border text-secondary""></div>
        <div class=""spinner-border text-dark""></div>
        <div class=""spinner-border text-light""></div>
    </footer>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
