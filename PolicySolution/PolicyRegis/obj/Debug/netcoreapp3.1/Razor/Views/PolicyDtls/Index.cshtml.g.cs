#pragma checksum "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30387329dc2f60fedd2a5b9a7d76d40e68e7269"
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
#line 1 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\_ViewImports.cshtml"
using PolicyRegis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
using PolicyModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30387329dc2f60fedd2a5b9a7d76d40e68e7269", @"/Views/PolicyDtls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1eaaf0428292e942010eaa94f937adde0591e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PolicyDtls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PolicyDtls>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""w3-table w3-table-all"">
    <thead>
        <tr>

            <th>  RecID</th>     
            <th>  CustID</th>
            <th>  PolicyStatus</th>
            <th>  ProductCode </th>
            <th> ProductType </th>
            <th> ProductName</th>
            <th>  PolicyTerm </th>
            <th> StartDt </th>
            <th> EndDt </th>
            <th> LOB </th>
            <th> PremiumAmt </th>
            <th> SumInsured </th>
            <th> AgtCode </th>
            <th>   ModeOfPremium</th>
            <th> PolIssuedt </th>
            <th> CurrentStatus </th>
            <th> AnnualPremium </th>
            <th> LastPremiumdt</th>
            <th> PremDueDt</th>
            <th> PREMIUM_PAYING_TERM </th>
            <th> Manager_Code </th>
            <th> OFFICE_CD </th>
            <th> CHANNEL_ID </th>
            <th> CreatedBy </th>
            <th>  CreatedDt </th>
            <th> UpdatedBy</th>
            <th>  UpdatedDt</th>
        <");
            WriteLiteral("/tr>\r\n</thead>\r\n\r\n<tbody>\r\n\r\n");
#nullable restore
#line 40 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n                <td> ");
#nullable restore
#line 43 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.RecID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 44 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.CustID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 45 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PolicyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 46 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 47 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.ProductType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 48 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 49 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 50 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PolicyTerm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 51 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.StartDt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 52 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.EndDt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 53 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.LOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 54 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PremiumAmt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 55 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.SumInsured);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 56 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.AgtCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 57 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.ModeOfPremium);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 58 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PolIssuedt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 59 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.CurrentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 60 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.AnnualPremium);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 61 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.LastPremiumdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 62 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PremDueDt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 63 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.PREMIUM_PAYING_TERM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 64 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.Manager_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 65 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.OFFICE_CD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 66 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.CHANNEL_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 67 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>  ");
#nullable restore
#line 68 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                 Write(item.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>  ");
#nullable restore
#line 69 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
                 Write(item.UpdatedDt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 71 "D:\MVCProject\kmtmvc\PolicySolution\PolicyRegis\Views\PolicyDtls\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>");
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