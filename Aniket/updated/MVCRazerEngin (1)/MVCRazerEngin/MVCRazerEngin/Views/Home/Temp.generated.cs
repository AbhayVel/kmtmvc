public partial class _Views_Home_Temp_cshtml : System.Web.Mvc.WebViewPage<MVCRazerEngin.Models.Employee> 
{
 public _Views_Home_Temp_cshtml()      
{
         
}
 public override void Execute()     
{
 \nWriteLiteral("<html>\r\n<head>\r\n    <title></title>\r\n    <script></script>\r\n</head>\r\n<body>\r\n    <p><h2>Index</h2></p>\r\n    ");
\n\nWriteLiteral("table>\r\n        ");
\nfor (int i = 0; i <= 5; i++)\r\n        
{
\r\n            \nWriteLiteral("<tr>\r\n                <td class=\"");
\nWrite(i==0?"a1":"a2" );
\nWriteLiteral(")\">");
\nWrite(i);
\nWriteLiteral("</td>\r\n            </tr>\r\n    <tr class=\"");
\nWrite(i==0?"a1":"a2" );
\nWriteLiteral(")\">\r\n        <td>");
\nWrite(i + 1);
\nWriteLiteral(")</td>\r\n    </tr>\r\n        ");
\n
}
\r\n    \nWriteLiteral("</table>\r\n</body>\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n");
\n}
}
