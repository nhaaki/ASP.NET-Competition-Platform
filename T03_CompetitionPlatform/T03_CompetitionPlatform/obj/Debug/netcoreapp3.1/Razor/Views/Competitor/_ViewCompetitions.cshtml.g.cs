#pragma checksum "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ff087ae78b6c944038c01a9a2eef53b85fd32a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competitor__ViewCompetitions), @"mvc.1.0.view", @"/Views/Competitor/_ViewCompetitions.cshtml")]
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
#line 1 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ff087ae78b6c944038c01a9a2eef53b85fd32a", @"/Views/Competitor/_ViewCompetitions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Competitor__ViewCompetitions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<T03_CompetitionPlatform.Models.Competition>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayNameFor(model => model.CompetitionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaInterestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayNameFor(model => model.CompetitionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayNameFor(model => model.ResultReleasedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompetitionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayFor(modelItem => item.AreaInterestID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompetitionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.DisplayFor(modelItem => item.ResultReleasedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
           Write(Html.ActionLink("Join", "Join", new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Ng Hung Meng\Source\Repos\web2021apr_p0_t\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Competitor\_ViewCompetitions.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<T03_CompetitionPlatform.Models.Competition>> Html { get; private set; }
    }
}
#pragma warning restore 1591