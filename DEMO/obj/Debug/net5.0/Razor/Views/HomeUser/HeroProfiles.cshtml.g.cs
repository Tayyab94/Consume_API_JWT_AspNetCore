#pragma checksum "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3cc201b7a7a534d71987e74562702ce3468be60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeUser_HeroProfiles), @"mvc.1.0.view", @"/Views/HomeUser/HeroProfiles.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\_ViewImports.cshtml"
using DEMO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\_ViewImports.cshtml"
using DEMO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3cc201b7a7a534d71987e74562702ce3468be60", @"/Views/HomeUser/HeroProfiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018b1a0de0afdc4a0eb24412d3d514bb2a42bfd6", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeUser_HeroProfiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DEMO.Models.Hero>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
  
    ViewData["Title"] = "HeroProfiles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 144, "\"", 195, 2);
            WriteAttributeValue("", 151, "/HomeUser/UploadAcheivement?HeroId=", 151, 35, true);
#nullable restore
#line 13 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
WriteAttributeValue("", 186, Model.Id, 186, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" > Upload Acheivement </a>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div>\r\n    <h4>Hero</h4>\r\n    <hr />\r\n    <dl>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        \r\n");
#nullable restore
#line 51 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
             foreach(var item in Model.Acheivements)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"col-lg-4\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h2 class=\"card-title\">");
#nullable restore
#line 56 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
                                      Write(item.AcheivementDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            <div class=\"card-body\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 1581, "", 1613, 1);
#nullable restore
#line 59 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
WriteAttributeValue("", 1586, Url.Content(item.PhotoURL), 1586, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" />\r\n            </div>\r\n        </div>\r\n      </div>\r\n");
#nullable restore
#line 63 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\HeroProfiles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DEMO.Models.Hero> Html { get; private set; }
    }
}
#pragma warning restore 1591
