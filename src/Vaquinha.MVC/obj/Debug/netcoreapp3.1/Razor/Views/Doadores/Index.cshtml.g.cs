#pragma checksum "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f985e4db93a6cc340553ffa409c52d53e06e27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doadores_Index), @"mvc.1.0.view", @"/Views/Doadores/Index.cshtml")]
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
#line 1 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\_ViewImports.cshtml"
using Vaquinha.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\_ViewImports.cshtml"
using Vaquinha.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f985e4db93a6cc340553ffa409c52d53e06e27", @"/Views/Doadores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02e3e1f708194b12af526d02b17c9487e8f1a0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Doadores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vaquinha.Domain.ViewModels.DoadorViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \n");
#nullable restore
#line 4 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
  
    ViewData["Title"] = "Doadores";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h3>Veja quem já doou!</h3>\n    <hr />\n</div>\n\n\n<table class=\"table table-striped table-bordered text-center\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MensagemApoio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoTempo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
         if (Model.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 38 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 41 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MensagemApoio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        <span>");
#nullable restore
#line 44 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                         Write(item.Valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 47 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DescricaoTempo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 50 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td colspan=\"4\">\n                    <center> <span class=\"text-center\">Ainda não houveram doações. Seja você o primeiro!</span></center>\n                </td>\n            </tr>\n");
#nullable restore
#line 59 "C:\Users\est_ab1214210\Downloads\dotnet-vaquinha-tests-master\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vaquinha.Domain.ViewModels.DoadorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
