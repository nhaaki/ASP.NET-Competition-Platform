#pragma checksum "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fdad9986165d0f427fe711b06e2b7163e2380bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RemoveJudges), @"mvc.1.0.view", @"/Views/Admin/RemoveJudges.cshtml")]
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
#line 1 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fdad9986165d0f427fe711b06e2b7163e2380bc", @"/Views/Admin/RemoveJudges.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RemoveJudges : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<T03_CompetitionPlatform.Models.AdminJudgeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Admin/_AdminNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveJudges", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center; align-content:center; align-items:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
  
    ViewData["Title"] = "RemoveJudges";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Edited this 27/6/202111 8pm  Delete Judges Function-->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fdad9986165d0f427fe711b06e2b7163e2380bc7440", async() => {
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
            WriteLiteral("\r\n\r\n<h4 class=\"PageTitle\" style=\"margin-top: 70px; font-size:200%; text-align:center;\">RemoveJudges</h4>\r\n\r\n<hr />\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 18 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["MissingInput1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 20 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["Duplicate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 22 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["WrongInterest"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 24 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["CompetitionNull"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 26 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["JudgeNull"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 28 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["RecordNotFound"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 30 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                                                                      Write(TempData["EndDateExceeded"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 33 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
 if (Model.compList.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table id=""viewCompJudgeR"" class=""table table-striped table-bordered table-hover table-dark"">
            <thead class=""thead-dark"">
                <tr style=""text-align:center; align-content:center; align-items:center;"">
                    <th>JudgeID</th>
                    <th>JudgeName</th>
                    <th>AreaInterestID</th>
                    <th>CompetitionID</th>
                    <th>CompetitionName</th>
                    <th>Remove</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 48 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                 foreach (var compJudge in Model.compJudgeList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"text-align:center; align-content:center; align-items:center;\">\r\n");
#nullable restore
#line 51 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                     foreach (var judge in Model.judgeList)
                    {
                        if (judge.JudgeID == compJudge.JudgeID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 55 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                       Write(judge.JudgeID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                       Write(judge.JudgeName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                       Write(judge.AreaInterestID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                            Model.JudgeID = judge.JudgeID;
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                     foreach (var competitions in Model.compList)
                    {
                        if (competitions.CompetitionID == compJudge.CompetitionID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 65 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                           Write(competitions.CompetitionID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                           Write(competitions.CompetitionName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 67 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                            Model.CompetitionID = competitions.CompetitionID;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad9986165d0f427fe711b06e2b7163e2380bc16412", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad9986165d0f427fe711b06e2b7163e2380bc16699", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 73 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad9986165d0f427fe711b06e2b7163e2380bc18508", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 76 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompetitionID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fdad9986165d0f427fe711b06e2b7163e2380bc20581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 77 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompetitionID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad9986165d0f427fe711b06e2b7163e2380bc22561", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 78 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompetitionID);

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
                WriteLiteral("\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad9986165d0f427fe711b06e2b7163e2380bc24300", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 80 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JudgeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fdad9986165d0f427fe711b06e2b7163e2380bc26367", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 81 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JudgeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad9986165d0f427fe711b06e2b7163e2380bc28345", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 83 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JudgeID);

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
                WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <input type=\"submit\" value=\"Remove\" class=\"btn btn-danger\" />\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n    </div>\r\n");
#nullable restore
#line 98 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"

}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red\">No competition record found!</span>\r\n");
#nullable restore
#line 104 "C:\Users\nhaak\Source\Repos\web2021apr_p0_t(2)\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\RemoveJudges.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<T03_CompetitionPlatform.Models.AdminJudgeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
