#pragma checksum "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8859d69ff8a04ec9227f454f1e4c90463f69a44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\_ViewImports.cshtml"
using apppracticando;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\_ViewImports.cshtml"
using apppracticando.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8859d69ff8a04ec9227f454f1e4c90463f69a44", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab222ce3204e326d1857ed57e26438244735136f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n//");
#nullable restore
#line 19 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
   if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No existen Fails para mostrar :( </p>\r\n");
#nullable restore
#line 22 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n");
#nullable restore
#line 27 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
         foreach (var Fail in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 text-center\">\r\n\r\n                <h2><a href=\"#\"> ");
#nullable restore
#line 31 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
                            Write(Fail.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                <p>");
#nullable restore
#line 32 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
              Write(Fail.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 643, "\"", 659, 1);
#nullable restore
#line 33 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
WriteAttributeValue("", 649, Fail.Foto, 649, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"img-fluid\" />\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\robin\Desktop\APPPRACTICANDO\apppracticando\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fail>> Html { get; private set; }
    }
}
#pragma warning restore 1591