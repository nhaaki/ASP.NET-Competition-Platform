#pragma checksum "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56042038a6788d5ee18b79002e733bf3326635f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Judge_ViewSubmission), @"mvc.1.0.view", @"/Views/Judge/ViewSubmission.cshtml")]
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
#line 1 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e56042038a6788d5ee18b79002e733bf3326635f", @"/Views/Judge/ViewSubmission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Judge_ViewSubmission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<T03_CompetitionPlatform.Models.CompetitionSubViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Judge/_JudgeNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GradeSubmission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Judge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
  
    ViewData["Title"] = "ViewSubmissions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e56042038a6788d5ee18b79002e733bf3326635f5484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>ViewSubmissions</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
 if (Model.subList.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"PageTitle\">View Branch</h4>\r\n");
            WriteLiteral(@"    <div class=""table-responsive"">
        <table id=""viewBranch"" class=""table table-striped table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>CompetitionID</th>
                    <th>CompetitiorID</th>
                    <th>VoteCount</th>
                    <th>Appeal</th>
                    <th>Ranking</th>
                    <th>DateTimeFileUpload</th>
                    <th>FileSubmitted</th>
                    <th></th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                 foreach (var item in Model.subList)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                   Write(item.CompetitionID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                   Write(item.CompetitorID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                   Write(item.VoteCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                     if (item.Appeal == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>-</td>\r\n");
#nullable restore
#line 42 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 45 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                       Write(item.Appeal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                     if (item.Ranking == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>-</td>\r\n");
#nullable restore
#line 54 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 57 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                       Write(item.Ranking);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 61 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                     if (item.DateTimeFileUpload == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>-</td>\r\n");
#nullable restore
#line 64 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 67 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                       Write(item.DateTimeFileUpload);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 68 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                     if (item.FileSubmitted == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>-</td>\r\n");
#nullable restore
#line 73 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                    }
                    else
                    {
                        string imageFileName = item.FileSubmitted + ".jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e56042038a6788d5ee18b79002e733bf3326635f14295", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2243, "~/images/", 2243, 9, true);
#nullable restore
#line 78 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
AddHtmlAttributeValue("", 2252, imageFileName, 2252, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 81 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                     foreach (var comp in Model.compList)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                         if (comp.EndDate < DateTime.Now && comp.CompetitionID == (int) ViewData["selectedCompNo"])
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e56042038a6788d5ee18b79002e733bf3326635f17046", async() => {
                WriteLiteral("Edit");
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
#line 91 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                                     WriteLiteral(item.CompetitorID);

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
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 93 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 115 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red\">No record found!</span>\r\n");
#nullable restore
#line 119 "C:\Users\Drake\Desktop\School\Web\week15probably\pulled28july\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewSubmission.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<T03_CompetitionPlatform.Models.CompetitionSubViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
