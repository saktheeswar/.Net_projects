#pragma checksum "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a75b0be5e9a2c3af871658e706d83931c406c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_contro_tableview), @"mvc.1.0.view", @"/Views/contro/tableview.cshtml")]
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
#line 1 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\_ViewImports.cshtml"
using Student_Registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\_ViewImports.cshtml"
using Student_Registration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a75b0be5e9a2c3af871658e706d83931c406c3", @"/Views/contro/tableview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84dc40b6aff53fa24f2522ffb6d794d5833b2bcf", @"/Views/_ViewImports.cshtml")]
    public class Views_contro_tableview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student_Registration.Models.Domain.STUDENT>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>VIEW DETAILS </h1>
    <table class=""table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>NAME</th>
                <th>PLACE</th>
                <th>DEPARTMENT</th>
                <th>UPDATE</th>
                <button onclick=""window.print()"" style=""margin-left"">Print this page</button>
                <div>
                    <br >
                </div>
                




            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
             foreach(var STUDENT in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
               Write(STUDENT.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
               Write(STUDENT.NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
               Write(STUDENT.PLACE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
               Write(STUDENT.DEPARTMENT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href =\"", 826, "\"", 858, 2);
            WriteAttributeValue("", 834, "/contro/view/", 834, 13, true);
#nullable restore
#line 32 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
WriteAttributeValue("", 847, STUDENT.ID, 847, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">view</a></td>\r\n               \r\n                \r\n              \r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\saktheeshwaran.m\source\repos\Student_Registration\Student_Registration\Views\contro\tableview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student_Registration.Models.Domain.STUDENT>> Html { get; private set; }
    }
}
#pragma warning restore 1591