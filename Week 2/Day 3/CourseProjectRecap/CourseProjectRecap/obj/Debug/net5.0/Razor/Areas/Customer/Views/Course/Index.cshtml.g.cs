#pragma checksum "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adafa06ac64ed1fd0e729f4400be1b0fd5181f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Course_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Course/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0adafa06ac64ed1fd0e729f4400be1b0fd5181f3", @"/Areas/Customer/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15729dad4f120ac162070835fcba54b52c541dbc", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseProjectRecap.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml"
  
    Layout  = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"owl-slide-3 owl-carousel\">\r\n            \r\n");
#nullable restore
#line 11 "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""course-1-item"">
                    <figure class=""thumnail"">
                        <a href=""course-single.html""><img src=""academics-master/images/course_1.jpg"" alt=""Image"" class=""img-fluid""></a>
                        <div class=""price"">");
#nullable restore
#line 16 "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"category\">\r\n                            <h3>");
#nullable restore
#line 18 "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml"
                           Write(item.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>\r\n                    </figure>\r\n                    <div class=\"course-1-content pb-4\">\r\n                        <h2>");
#nullable restore
#line 21 "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml"
                       Write(item.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <div class=""rating text-center mb-3"">
                            <span class=""icon-star2 text-warning""></span>
                            <span class=""icon-star2 text-warning""></span>
                            <span class=""icon-star2 text-warning""></span>
                            <span class=""icon-star2 text-warning""></span>
                            <span class=""icon-star2 text-warning""></span>
                        </div>
                        <p class=""desc mb-4"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Similique accusantium ipsam.</p>
                        <p><a href=""course-single.html"" class=""btn btn-primary rounded-0 px-4"">Kursa Kayıt Ol</a></p>
                    </div>
                </div>
");
#nullable restore
#line 33 "C:\Users\asus\source\repos\CourseProjectRecap\CourseProjectRecap\Areas\Customer\Views\Course\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n            \r\n\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseProjectRecap.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
