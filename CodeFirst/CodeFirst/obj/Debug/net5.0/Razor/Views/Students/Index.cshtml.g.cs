#pragma checksum "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207b83f6202b2748e36c47f5ff437b0b914d7063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207b83f6202b2748e36c47f5ff437b0b914d7063", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
  
    var Students = (List<StudentModel>)ViewData["Students"];//for the index action(Display all students)

   

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>This is Index Students</h1>\n\n\n");
            WriteLiteral(@"
<table class=""table"">
    <thead class=""thead-light"">
    <thead>

        <tr>
            <th>Id</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>Email</th>
            <th>Show</th>

        </tr>

    </thead>


    <tbody>

");
#nullable restore
#line 38 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
        foreach (var student in Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 41 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
           Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 42 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
           Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 43 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
           Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 44 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
           Write(student.Eamil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><button class=\"btn\"><a");
            BeginWriteAttribute("href", " href=\"", 850, "\"", 886, 2);
            WriteAttributeValue("", 857, "/students/details/", 857, 18, true);
#nullable restore
#line 45 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"
WriteAttributeValue("", 875, student.Id, 875, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Show</a></button></td>\n        </tr>\n");
#nullable restore
#line 47 "/Users/arwawanla/MVC/codeFirst/CodeFirst/CodeFirst/Views/Students/Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
