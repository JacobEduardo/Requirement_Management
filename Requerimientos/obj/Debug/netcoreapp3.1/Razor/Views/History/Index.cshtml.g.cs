#pragma checksum "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\History\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3320cc6ea4c37201124ce93284ae079ad467fecb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_History_Index), @"mvc.1.0.view", @"/Views/History/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3320cc6ea4c37201124ce93284ae079ad467fecb", @"/Views/History/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fbbd19645cf6fcb86d89a97a4baa36a12f6466", @"/Views/_ViewImports.cshtml")]
    public class Views_History_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Requerimientos.Models.History>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\History\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-4"">
        Aqui va ptra cosa
    </div>
    <div class=""col-8"">

        <div class=""p-3"" style=""display: flex; justify-content: center; "">
            <button type=""button"" class=""btn btn-success"">Crear Requerimiento</button>
        </div>

        <div class=""p-3"">
            <h1>History</h1>
");
#nullable restore
#line 18 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\History\Index.cshtml"
             foreach (var history in Model)
            {
                if (history.IdTecnicoArl.ToString().Equals("4"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\History\Index.cshtml"
               Write(history.IdHistory.ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\History\Index.cshtml"
                                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 24 "C:\Users\Jacob\Desktop\Repos\Requirement_Management\Requerimientos\Views\History\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
