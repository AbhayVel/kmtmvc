using System.Collections.Generic;
namespace ConsoleAppFirst {
public class Class1   {  
public void Execute() {  
WriteLines(<!DOCTYPE html>)
WriteLines()
WriteLines(<html lang="en" xmlns="http://www.w3.org/1999/xhtml">)
WriteLines(<head>)
WriteLines(    <meta charset="utf-8" />)
WriteLines(    <title></title>)
WriteLines(</head>)
WriteLines(<body>)
WriteLines()
WriteLines(    <div>)
WriteLines(        <label for="name">Name</label>)
WriteLines()
WriteLines(        <input type="text" id="name" value="@Model.Subject" />)
WriteLines(    </div>)
WriteLines()
WriteLines()
WriteLines(    <div>)
WriteLines(        <label for="subject">Subject</label>)
WriteLines()
WriteLines(        <input type="text" id="subject" value="@Model.Subject" />)
WriteLines(    </div>)
WriteLines()
WriteLines()
WriteLines(    @if(i==2){)
WriteLines()
WriteLines(    <div>)
WriteLines(        <label for="age">Age</label>)
WriteLines()
WriteLines(        <input type="text" id="age" value="@Model.Age" />)
WriteLines(        <inupt type="checkbox" />)
WriteLines(    </div>)
WriteLines()
WriteLines(    } else {)
WriteLines(    <div>)
WriteLines(        <label for="age">Age</label>)
WriteLines()
WriteLines(        <input type="text" id="age" value="@Model.Age" />)
WriteLines(    </div>)
WriteLines(    )
WriteLines(    })
WriteLines(</body>)
WriteLines(</html>)
} } }  
