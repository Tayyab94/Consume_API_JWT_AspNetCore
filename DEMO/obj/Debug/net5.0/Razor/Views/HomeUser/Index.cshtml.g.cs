#pragma checksum "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd64e01bf6f8812a121211240fda9793930bf422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeUser_Index), @"mvc.1.0.view", @"/Views/HomeUser/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd64e01bf6f8812a121211240fda9793930bf422", @"/Views/HomeUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018b1a0de0afdc4a0eb24412d3d514bb2a42bfd6", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DEMO.Models.Hero>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n    <h4>Hero</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 40 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 1165, "\"", 1216, 2);
            WriteAttributeValue("", 1172, "/HomeUser/UploadAcheivement?HeroId=", 1172, 35, true);
#nullable restore
#line 42 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
WriteAttributeValue("", 1207, Model.Id, 1207, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" > Upload Acheivement </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1255, "\"", 1297, 2);
            WriteAttributeValue("", 1262, "/HomeUser/HeroProfiles?id=", 1262, 26, true);
#nullable restore
#line 43 "C:\Users\Admin\source\repos\DEMO\DEMO\Views\HomeUser\Index.cshtml"
WriteAttributeValue("", 1288, Model.Id, 1288, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" > Complete Profile </a>\r\n    \r\n");
            WriteLiteral("\r\n</div>\r\n");
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
