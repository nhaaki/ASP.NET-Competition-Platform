#pragma checksum "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "215ed95fa531726cbfd294123fa483efbc82ce22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_ViewCompetitors), @"mvc.1.0.view", @"/Views/Guest/ViewCompetitors.cshtml")]
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
#line 1 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"215ed95fa531726cbfd294123fa483efbc82ce22", @"/Views/Guest/ViewCompetitors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Guest_ViewCompetitors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<T03_CompetitionPlatform.Models.CompSubmissionViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Guest/_GuestNavbar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/missingfile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<style>\r\n    .user_name {\r\n        font-size: 14px;\r\n        font-weight: bold;\r\n    }\r\n\r\n    .comments-list .media {\r\n        border-bottom: 1px dotted #ccc;\r\n    }\r\n</style>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "215ed95fa531726cbfd294123fa483efbc82ce226352", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ViewCompetitors</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "215ed95fa531726cbfd294123fa483efbc82ce227421", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "215ed95fa531726cbfd294123fa483efbc82ce227683", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <h1 style=\"text-align:center; padding-top:30px;\">");
#nullable restore
#line 28 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                                                Write(ViewData["CompName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h5 style=\"text-align: center; padding-top:30px;\">View submissions</h5>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
               Write(Html.DisplayNameFor(model => model.CompetitorID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
               Write(Html.DisplayNameFor(model => model.CompetitorName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
               Write(Html.DisplayNameFor(model => model.FileSubmitted));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
               Write(Html.DisplayNameFor(model => model.DateTimeFileUpload));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 51 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
             if (Model.ToList().Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CompetitorID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Salutation));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 60 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.CompetitorName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 63 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                             if (item.FileSubmitted != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("embed", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "215ed95fa531726cbfd294123fa483efbc82ce2213590", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1915, "~/images/", 1915, 9, true);
#nullable restore
#line 65 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
AddHtmlAttributeValue("", 1924, item.FileSubmitted, 1924, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 66 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "215ed95fa531726cbfd294123fa483efbc82ce2215878", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 70 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                       Write(Html.EditorFor(modelItem => item.DateTimeFileUpload, new { htmlAttributes = new { @class = "form-control", disabled = "disabled", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n                            ");
#nullable restore
#line 79 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                       Write(Html.ActionLink("View", "ViewCompetitorWork", new { competitorID = item.CompetitorID, competitionID = item.CompetitionID }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 83 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span style=\"color:red\">No record found!</span>\r\n");
#nullable restore
#line 88 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"container\">\r\n        <div class=\"row flex-nowrap justify-content-between align-items-center\">\r\n            <input type=\"button\" class=\"btn btn-info mx-auto\" value=\"View Comments\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3128, "\"", 3222, 3);
                WriteAttributeValue("", 3138, "location.href=\'", 3138, 15, true);
#nullable restore
#line 93 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\ViewCompetitors.cshtml"
WriteAttributeValue("", 3153, Url.Action("GuestComment", "Guest", new { id = ViewData["CompID"]}), 3153, 68, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3221, "\'", 3221, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<T03_CompetitionPlatform.Models.CompSubmissionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
