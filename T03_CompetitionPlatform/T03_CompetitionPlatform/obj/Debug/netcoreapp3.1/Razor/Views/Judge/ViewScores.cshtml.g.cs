#pragma checksum "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c18c3f1b9a1340d8dcad4fed7f65078b36ab46e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Judge_ViewScores), @"mvc.1.0.view", @"/Views/Judge/ViewScores.cshtml")]
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
#line 1 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c18c3f1b9a1340d8dcad4fed7f65078b36ab46e", @"/Views/Judge/ViewScores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Judge_ViewScores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<T03_CompetitionPlatform.Models.CompetitionScoreViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Judge/_JudgeNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Judge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GradeCriterion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c18c3f1b9a1340d8dcad4fed7f65078b36ab46e5705", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c18c3f1b9a1340d8dcad4fed7f65078b36ab46e6774", async() => {
                WriteLiteral("\r\n   \r\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c18c3f1b9a1340d8dcad4fed7f65078b36ab46e7042", async() => {
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
                WriteLiteral("\r\n    \r\n\r\n\r\n\r\n    <h1 style=\"text-align:center; padding-top:30px;\">");
#nullable restore
#line 23 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                                                Write(ViewData["CompName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h3 style=\"text-align:center; padding-top:30px;\">");
#nullable restore
#line 24 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                                                Write(ViewData["CompetitorName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@":</h3>
    <h5 style=""text-align: center; padding-top:30px;""> Submission Grades</h5>
    <div class=""table-responsive"">
        <table class=""table table-bordered table-hover table-dark table-striped"">
            <thead>
                <tr>




                    <th>
                        CriteriaID


                    </th>

                    <th>
                        CriteriaName
                    </th>

                    <th>
                        Weightage
                    </th>

                    <th>
                        Score
                    </th>

");
#nullable restore
#line 52 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                     if (DateTime.Now < Convert.ToDateTime(ViewData["Compend"]))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th></th>\r\n");
#nullable restore
#line 55 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 64 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                 if (Model.ToList().Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CriteriaID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 74 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CriteriaName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 78 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Weightage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 82 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n\r\n\r\n");
#nullable restore
#line 87 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                             if (DateTime.Now < Convert.ToDateTime(ViewData["Compend"]))
                            {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c18c3f1b9a1340d8dcad4fed7f65078b36ab46e13551", async() => {
                    WriteLiteral("Grade");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-competitorID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                                                                                                                                WriteLiteral(item.CompetitorID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["competitorID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-competitorID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["competitorID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                                                                                                                                                                          WriteLiteral(item.CriteriaID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["criteriaid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-criteriaid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["criteriaid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                                                                                                                                                                                                                    WriteLiteral(item.CriteriaName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["criterianame"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-criterianame", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["criterianame"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                                                                                                                                                                                                                                                             WriteLiteral(item.Weightage);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["weightage"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-weightage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["weightage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 94 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 96 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span style=\"color:red\">No record found!</span>\r\n");
#nullable restore
#line 101 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Updated Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\ViewScores.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<T03_CompetitionPlatform.Models.CompetitionScoreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
