#pragma checksum "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7741e5b6b6660ef53c725e314120d74143df6dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageJudgesView), @"mvc.1.0.view", @"/Views/Admin/ManageJudgesView.cshtml")]
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
#line 1 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7741e5b6b6660ef53c725e314120d74143df6dcc", @"/Views/Admin/ManageJudgesView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageJudgesView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<T03_CompetitionPlatform.Models.AdminJudgeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Admin/_AdminNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveJudges", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageJudgesView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center; align-content:center; align-items:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
  
    ViewData["Title"] = "ManageJudgesView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Edited this 27/6/2021 8pm  Delete Judges Function-->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7741e5b6b6660ef53c725e314120d74143df6dcc7931", async() => {
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
            WriteLiteral(@"

<h4 class=""PageTitle"" style=""margin-top: 70px; font-size:200%; text-align:center;"">ManageJudgesView</h4>
<br />

<p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><b>Assign or remove judges to/from competitions</b></p>
<hr />
<br />
<p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><b><u>Competitions that require judges</u></b></p>
<hr />

<hr />
<p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><b><pre>");
#nullable restore
#line 25 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["MissingInput1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 27 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["Duplicate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 29 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["WrongInterest"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 31 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["CompetitionNull"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 33 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["JudgeNull"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 35 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["AlreadyAssigned"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><pre>");
#nullable restore
#line 37 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                                                      Write(TempData["EndDateExceeded"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></b></p>\r\n<hr />\r\n\r\n<p style=\"text-align: center;font-size: 175%;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc12674", async() => {
                WriteLiteral("Remove Judges");
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
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
 if (Model.compList.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table id=""viewCompJudge"" class=""table table-striped table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>AreaInterestID</th>
                    <th>CompetitionID</th>
                    <th>CompetitionName</th>
                    <th>Amount of Judges</th>
                    <th>Available Judges(ID)</th>
                    <th>Add</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 59 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                 foreach (var competitions in Model.compList)
                {
                    int countComp = 0;
                    bool foundInCompetitionJudge = false;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                     foreach (var competitionJudge in Model.compJudgeList)
                    {
                        if (competitionJudge.CompetitionID == competitions.CompetitionID)
                        {
                            countComp += 1;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 72 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                       Write(competitions.AreaInterestID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                       Write(competitions.CompetitionID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                       Write(competitions.CompetitionName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                       Write(countComp.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 77 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                             foreach (var judges in Model.judgeList)
                            {
                                if (judges.AreaInterestID == competitions.AreaInterestID)
                                {
                                    bool notFound = false;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                     foreach (var compJudges in Model.compJudgeList)
                                    {
                                        if (compJudges.JudgeID == judges.JudgeID)
                                        {
                                            notFound = true;
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                     

                                    if (notFound == false)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                   Write(judges.JudgeID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>   </p>\r\n");
#nullable restore
#line 94 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc19475", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc19766", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 100 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc21591", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 103 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompetitionID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7741e5b6b6660ef53c725e314120d74143df6dcc23355", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 104 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompetitionID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc25026", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 105 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CompetitionID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc26777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 107 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JudgeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7741e5b6b6660ef53c725e314120d74143df6dcc28535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 108 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JudgeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7741e5b6b6660ef53c725e314120d74143df6dcc30204", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 110 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JudgeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                </div>
                                <div class=""form-group"">
                                    <input type=""submit"" value=""Add"" class=""btn btn-primary"" />
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 120 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 126 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red\">No competition record found!</span>\r\n");
#nullable restore
#line 131 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b><u>Judges in database</u></b></p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 137 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
 if (Model.judgeList.Count > 0 && Model.areaList.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table id=""viewJudge"" class=""table table-striped table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>JudgeID</th>
                    <th>JudgeName</th>
                    <th>AreaInterestID</th>
                    <th>Area Name</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 151 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                 foreach (var item in Model.judgeList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 154 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                       Write(item.JudgeID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 155 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                       Write(item.JudgeName.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 156 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                         foreach (var areas in Model.areaList)
                        {
                            if (item.AreaInterestID == areas.AreaInterestID)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 160 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                               Write(areas.AreaInterestID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 161 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                               Write(areas.Name.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 162 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 165 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 171 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red\">No judge record found!</span>\r\n");
#nullable restore
#line 176 "C:\Users\Drake\Desktop\School\Web\week12wednesday\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\ManageJudgesView.cshtml"
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
