#pragma checksum "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "551b5be14e4de78efc26bde21cfd2685fc55371c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Judge_Rank), @"mvc.1.0.view", @"/Views/Judge/Rank.cshtml")]
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
#line 1 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551b5be14e4de78efc26bde21cfd2685fc55371c", @"/Views/Judge/Rank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Judge_Rank : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<T03_CompetitionPlatform.Models.CompSubmissionViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Judge/_JudgeNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rank", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
  
    ViewData["Title"] = "Rank";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "551b5be14e4de78efc26bde21cfd2685fc55371c5106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
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
            WriteLiteral("\r\n\r\n\r\n<h1 style=\"text-align:center; padding-top:30px;\">");
#nullable restore
#line 9 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                            Write(ViewData["CompName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h5 style=\"text-align: center; padding-top:30px;\">Rank Competitors</h5>\r\n\r\n\r\n\r\n\r\n<div class=\"table-responsive\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "551b5be14e4de78efc26bde21cfd2685fc55371c7206", async() => {
                WriteLiteral(@"

        <fieldset class=""FormContent"">
            <table class=""table table-bordered table-hover table-dark table-striped"">
                <thead class=""thead-dark"">
                    <tr style=""text-align:center; align-content:center; align-items:center;"">




                        <th>
                            CompetitorID
                        </th>

                        <th>Competitor Name</th>

                        <th>
                            Appeal
                        </th>
                        <th>
                            VoteCount
                        </th>

                        <th>Total Marks</th>
                        <th>
                            Ranking
                        </th>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 48 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                     for (int i = 0; i < Model.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                           Write(Model[i].CompetitorID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                           Write(Model[i].Salutation);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                                Write(Model[i].CompetitorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                             if (Model[i].Appeal != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 63 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                               Write(Model[i].Appeal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 65 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>-</td>\r\n");
#nullable restore
#line 69 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 71 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                           Write(Model[i].VoteCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 78 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                              
                                var marks = (List<double>)ViewData["totalmarks"];
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <td>");
#nullable restore
#line 82 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                           Write(marks[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                            <td>\r\n");
#nullable restore
#line 85 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                 if ((DateTime)ViewData["CompEnd"] > DateTime.Now )
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div>\r\n                                        \r\n                                        ");
#nullable restore
#line 89 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.EditorFor(m => m[i].Ranking));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "551b5be14e4de78efc26bde21cfd2685fc55371c13104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 90 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Ranking);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 96 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].CompetitionID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 102 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].CompetitorID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 108 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].FileSubmitted));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 114 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].DateTimeFileUpload));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 120 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].Appeal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 126 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].VoteCount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 134 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].Salutation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 140 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].CompetitorName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 146 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].CompetitionName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 152 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
                WriteLiteral("                                    <div>\r\n\r\n                                        ");
#nullable restore
#line 158 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                   Write(Html.HiddenFor(model => Model[i].EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 161 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                               Write(Model[i].Ranking);

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 171 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n        </fieldset>\r\n");
#nullable restore
#line 177 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
         if ((DateTime) ViewData["CompEnd"] > DateTime.Now )
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div>
                <div style=""width:91.31px; margin-left:auto; margin-top:20px; margin-right:auto"">
                    <input type=""submit"" value=""Finalise""
                           class=""btn btn-primary"" />
                </div>
            </div>
");
#nullable restore
#line 185 "C:\Users\Ng Hung Meng\Source\Repos\help\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Judge\Rank.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<T03_CompetitionPlatform.Models.CompSubmissionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
