#pragma checksum "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e00f18193bc1a78c5e0b53e3e9ce95b4d9b6f837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index), @"mvc.1.0.view", @"/Views/Index.cshtml")]
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
#line 1 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\_ViewImports.cshtml"
using Requerimientos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\_ViewImports.cshtml"
using Requerimientos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e00f18193bc1a78c5e0b53e3e9ce95b4d9b6f837", @"/Views/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fbbd19645cf6fcb86d89a97a4baa36a12f6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Requerimientos.Models.History>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
 foreach (var history in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
Write(history.IdHistory);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 10 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
Write(history.IdEvent);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 11 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
Write(history.EventMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 12 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
Write(history.IdRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 13 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
Write(history.IdTecnicoArl);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 14 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Requerimientos.Models.History>> Html { get; private set; }
    }
}
#pragma warning restore 1591
