public partial class _Views_Home_Temp_cshtml : System.Web.Mvc.WebViewPage<MVCRazerEngin.Models.Employee> 
{
 public _Views_Home_Temp_cshtml()      
{
         
}
 public override void Execute()     
{
 WriteLiteral("<html><head>    <title></title>    <script></script></head><body>    <p><h2>Index</h2></p>    ");
Write(    );
WriteLiteral("<table>        ");
for (int i = 0; i <= 5; i++)        
{
            WriteLiteral("<tr>                <td>");
Write(i);
WriteLiteral("</td>            </tr>            <tr>                <td>");
Write((i + 1));
WriteLiteral("</td>            </tr>        ");

}
    WriteLiteral("</table></body></html>");
}
}
