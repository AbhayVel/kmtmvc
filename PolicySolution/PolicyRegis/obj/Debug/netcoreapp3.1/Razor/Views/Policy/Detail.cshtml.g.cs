#pragma checksum "E:\RAJNEWMVC\kmtmvc\PolicySolution\PolicyRegis\Views\Policy\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a9837e11de81aa4191f8765ff8df7a73b769dea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Policy_Detail), @"mvc.1.0.view", @"/Views/Policy/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9837e11de81aa4191f8765ff8df7a73b769dea", @"/Views/Policy/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1eaaf0428292e942010eaa94f937adde0591e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Policy_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- header -->

<br>

<table style=""width:100% ;box-shadow: 0 10px 10px #bababa;height: 40px ; border: 0%;padding: 1px; "">
  <tr  >
    
    <h1 style=""text-align:center"">Policy Details</h1>
    
  </tr>
  </table>
  <br><div style=""box-shadow: 0 10px 10px #bababa;"">
  <div class=""w3-container w3-white""");
            BeginWriteAttribute("style", " style=", 319, "", 326, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <h2>Policy requirements</h2>
</div>
    <div style=""float:right;"" id=""Current_date"" class=""ABC""> 
      <br>
      <div style=""box-shadow: 0 3px 5px #bababa;"">
    <script >
        document.getElementById(""Current_date"").innerHTML=Date();
    </script>
    </div>
  </div>
  <div class=""cB""></div>
  <div style=""box-shadow: 0 3px 5px #bababa;

  ""> 
    <table style=""width:100%"" >
        <tr>
          <td> <input type=""text"" id=""fname1"" name=""name1""maxlength=""20"" placeholder=""Policy id""size=""27""><br><br></td>
          <td> <input type=""text"" id=""fname2"" name=""name2""maxlength=""20""placeholder=""First Name "" size=""27""><br><br></td>
          <td> <div class=""dropdown"">
            <button class=""btn btn-default dropdown-toggle"" style=""border-style:none"" type=""button"" data-toggle=""dropdown"">Select Gender
            <span class=""caret""></span></button>
            <ul class=""dropdown-menu"">
              <li><a href=""#"">Male</a></li>
              <li><a href=""#"">Female</a></li>
  ");
            WriteLiteral(@"            <li><a href=""#"">Other</a></li>
              <li class=""divider""></li>
              <li><a href=""#"">About Us</a></li>
            </ul><hr>
          </div></th>
        </tr>
        <tr>
          <td> <input type=""text"" id=""fname4"" placeholder=""Address""name=""name4""maxlength=""20"" size=""30""><br><br></td>
          <td> <input type=""text"" id=""fname5"" placeholder=""Phone Number""name=""name5""maxlength=""20"" size=""30""><br><br></td>
          <td> <input type=""text"" id=""fname6"" placeholder=""Email-Id""name=""name6""maxlength=""20"" size=""30""><br><br></td>
        </tr>

       
    </table>
  </div>
</div>
  
 <div style=""box-shadow: 0 10px 10px #bababa; "">
  <br><br>
    <button class=""collapsible"" style=""box-shadow: 1 5px 10px black; "">
      <h3> Vehicle Policy Details</h3>
        <div> <table class=""w3-table"" Height=""10px"">
          </table></div>
    </button>

    <div class=""content"" style=""box-shadow: 10px 10px black;"">
        <div class=""scrollmenu"">
            <table s");
            WriteLiteral(@"tyle=""width:100%"" >
                <tr>
                  <td> <input type=""text"" id=""fname1"" name=""name1""maxlength=""20"" placeholder=""Policy Number""size=""27""><br><br></td>
                  <td> <input type=""text"" id=""fname2"" name=""name2""maxlength=""20""placeholder=""Policy Effective date"" size=""27""><br><br></td>
                  <td> <div class=""dropdown"">
                    <button class=""btn btn-default dropdown-toggle"" style=""border-style:none"" type=""button"" data-toggle=""dropdown"">Vehicle type
                    <span class=""caret""></span></button>
                    <ul class=""dropdown-menu"">
                      <li><a href=""#"">Car</a></li>
                      <li><a href=""#"">Bike</a></li>
                      <li><a href=""#"">Rickshaw</a></li>
                      <li class=""divider""></li>
                      <li><a href=""#"">About Us</a></li>
                    </ul><hr>
                  </div></th>
                </tr>
                <tr>
                  <td> <input type");
            WriteLiteral(@"=""text"" id=""fname4"" placeholder=""Address""name=""name4""maxlength=""20"" size=""30""><br><br></td>
                  <td> <input type=""text"" id=""fname5"" placeholder=""Phone Number""name=""name5""maxlength=""20"" size=""30""><br><br></td>
                  <td> <input type=""text"" id=""fname6"" placeholder=""Email-Id""name=""name6""maxlength=""20"" size=""30""><br><br></td>
                </tr>
        
               
            </table>
           
      <script>
        var coll = document.getElementsByClassName(""collapsible"");
        var i;
        
        for (i = 0; i < coll.length; i++) {
          coll[i].addEventListener(""click"", function() {
            this.classList.toggle(""active"");
            var content = this.nextElementSibling;
            if (content.style.maxHeight){
              content.style.maxHeight = null;
            } else {
              content.style.maxHeight = content.scrollHeight + ""px"";
            } 
          });
        }
        </script>
        </div>
    </div></div>");
            WriteLiteral(@"
   <br><br>
   <div>
    <button class=""collapsible1""><h3>Vehicle Driver Details</h3>
        <div> <table class=""w3-table"" Height=""10px"">
            
          </table></div>
    </button>

    <div class=""content"" style=""box-shadow: 10px 10px black;"">
        <div class=""scrollmenu"">
            <table style=""width:100%"" >
                <tr></tr>
                  <td> <div class=""dropdown"">
                    <button class=""btn btn-default dropdown-toggle"" style=""border-style:none"" type=""button"" data-toggle=""dropdown"">Vehicle Status
                    <span class=""caret""></span></button>
                    <ul class=""dropdown-menu"">
                      <li><a href=""#"">Active</a></li>
                      <li><a href=""#"">InActive</a></li>
                     
                    </ul><hr>
                  </div></th>
                </tr>
                <tr>
                  <td> <input type=""text"" id=""fname4"" placeholder=""Vehicle_ID""name=""name4""maxlength=""20"" size=""30""");
            WriteLiteral(@"><br><br></td>
                  <td> <input type=""text"" id=""fname5"" placeholder=""Driver_ID""name=""name5""maxlength=""20"" size=""30""><br><br></td>
                  <td> <input type=""text"" id=""fname6"" placeholder=""Email-Id""name=""name6""maxlength=""20"" size=""30""><br><br></td>
                </tr>
        
               
            </table>
           
            <script>
        var coll = document.getElementsByClassName(""collapsible1"");
        var i;
        
        for (i = 0; i < coll.length; i++) {
          coll[i].addEventListener(""click"", function() {
            this.classList.toggle(""active"");
            var content = this.nextElementSibling;
            if (content.style.maxHeight){
              content.style.maxHeight = null;
            } else {
              content.style.maxHeight = content.scrollHeight + ""px"";
            } 
          });
        }
        </script>
        
    </div>

    </div>

   ");
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
