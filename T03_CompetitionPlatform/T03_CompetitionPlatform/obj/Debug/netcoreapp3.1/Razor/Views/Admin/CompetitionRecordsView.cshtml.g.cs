#pragma checksum "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0e4045d5b66cbb52b47bf63ee7d56477278b28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CompetitionRecordsView), @"mvc.1.0.view", @"/Views/Admin/CompetitionRecordsView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0e4045d5b66cbb52b47bf63ee7d56477278b28", @"/Views/Admin/CompetitionRecordsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CompetitionRecordsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<T03_CompetitionPlatform.Models.Competition>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Admin/_AdminNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCompetitionsView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCompetition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCompetition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
  
    ViewData["Title"] = "CompetitionRecordsView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Edited this 27/6/2021 8pm  Delete Judges Function-->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef0e4045d5b66cbb52b47bf63ee7d56477278b286071", async() => {
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
            WriteLiteral("\r\n\r\n<h4 class=\"PageTitle\" style=\"margin-top: 70px; font-size:200%; text-align:center;\">CompetitionRecords</h4>\r\n<br />\r\n\r\n<p style=\"text-align: center;font-size: 175%;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0e4045d5b66cbb52b47bf63ee7d56477278b287368", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n<span style=\"color:red;\">");
#nullable restore
#line 20 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                    Write(TempData["CompetitionDeleteMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n");
#nullable restore
#line 22 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
 if (Model.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"" >
        <table id=""viewStaff"" class=""table table-striped table-bordered"" >
            <thead class=""thead-dark"">
                <tr>
                    <th>CompetitionID</th>
                    <th>AreaInterestID</th>
                    <th>CompetitionName</th>
                    <th>StartDate</th>
                    <th>EndDate</th>
                    <th>ResultReleasedDate</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 38 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 41 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                       Write(item.CompetitionID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                       Write(item.AreaInterestID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                       Write(item.CompetitionName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                       Write(item.StartDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                       Write(item.EndDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                       Write(item.ResultReleasedDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0e4045d5b66cbb52b47bf63ee7d56477278b2812419", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                                                                                       WriteLiteral(item.CompetitionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0e4045d5b66cbb52b47bf63ee7d56477278b2814947", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                                                                                     WriteLiteral(item.CompetitionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 57 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red\">No record found!</span>\r\n");
#nullable restore
#line 61 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\CompetitionRecordsView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<T03_CompetitionPlatform.Models.Competition>> Html { get; private set; }
    }
}
#pragma warning restore 1591
