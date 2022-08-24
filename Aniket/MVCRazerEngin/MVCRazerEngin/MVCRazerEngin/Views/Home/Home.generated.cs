using System.Text;
using System.Web.Mvc;

public partial class _Views_Home_Index_cshtml 
{
      StringBuilder sb=new StringBuilder("");

	public void WriteLiteral(string data)
	{
       sb.Append(data);
	}
 public _Views_Home_Index_cshtml()      
{
         
}
 public  void Execute()     
{
 WriteLiteral("<html><head>    <title></title>    <script></script></head><body>    <p><h2>Index</h2></p>    <table>        ");
for (int i = 0; i <= 5; i++)        
{
            if (i == 2)            
{
                WriteLiteral("<tr>                    <td  class=\"");
Write(i==0?"a1":"a2" );
WriteLiteral(")\" >");
Write(i);
WriteLiteral("</td>                </tr>            ");

}
            WriteLiteral("<tr>                <td>");
Write(i+1);
WriteLiteral(")</td>            </tr>        ");

}
    WriteLiteral("</table></body></html>");
}
}
