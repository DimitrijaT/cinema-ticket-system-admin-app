#pragma checksum "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b03d383e966b7c2c1747ebef9495c298733e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\_ViewImports.cshtml"
using CinemaTicketSystemAdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\_ViewImports.cshtml"
using CinemaTicketSystemAdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b03d383e966b7c2c1747ebef9495c298733e0a", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a607f60faf555d018608ef403061cbfc0ec4b09a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaTicketSystemAdminApp.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <a class=\"btn btn-success\">Order For: ");
#nullable restore
#line 11 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
                                     Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
     for (int i = 0; i < Model.TicketOrders.ToList().Count; i++)
    {
        var item = Model.TicketOrders.ElementAt(i).OrderedTicket;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 18rem; height: 30rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 665, "\"", 685, 1);
#nullable restore
#line 24 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
WriteAttributeValue("", 671, item.ImageUrl, 671, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 50%\" alt=\"Ticket\" />\r\n\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title\">");
#nullable restore
#line 27 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
                                          Write(item.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
                                        Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h5>Price: ");
#nullable restore
#line 29 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>");
#nullable restore
#line 30 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
                      Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"

            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 38 "C:\Users\dimit\source\repos\SixthSemester\ISHomework_CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\CinemaTicketSystemAdminApp\Views\Order\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaTicketSystemAdminApp.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
