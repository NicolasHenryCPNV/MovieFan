#pragma checksum "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80b2d72da8dfdd84b49d4adcb9af77cfc2b19325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__MyMovies), @"mvc.1.0.view", @"/Views/User/_MyMovies.cshtml")]
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
#line 1 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\_ViewImports.cshtml"
using MovieFan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\_ViewImports.cshtml"
using MovieFan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b2d72da8dfdd84b49d4adcb9af77cfc2b19325", @"/Views/User/_MyMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a84a7893621d9679de51dd87bb6685e682f103b", @"/Views/_ViewImports.cshtml")]
    public class Views_User__MyMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Films suivis</h4>\r\n<div class=\"row border\" style=\"background-color:#e5e2e2\">\r\n    <div class=\"col-2\">Titres</div>\r\n    <div class=\"col-2\">Note</div>\r\n    <div class=\"col-6\">Commentaires</div>\r\n</div>\r\n");
#nullable restore
#line 11 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml"
 foreach (UserLikeMovie ulm in Model.UserLikeMovie)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row border\">\r\n        <div class=\"col-2\">");
#nullable restore
#line 14 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml"
                      Write(ulm.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col-2\">");
#nullable restore
#line 15 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml"
                            for (int i = 0; i < ulm.Stars; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-star\" style=\"color:#ffd800;\"></i>");
#nullable restore
#line 15 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml"
                                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n        <div class=\"col-6\">");
#nullable restore
#line 16 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml"
                      Write(ulm.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 18 "D:\Documents\1. Ecole\Modules\ASP\MovieFan\MovieFan\MovieFan\Views\User\_MyMovies.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Users> Html { get; private set; }
    }
}
#pragma warning restore 1591