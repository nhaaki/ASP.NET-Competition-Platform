#pragma checksum "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\AdminMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc1151a7109f3a7b4fc6d16b0414752b35fc6813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminMain), @"mvc.1.0.view", @"/Views/Admin/AdminMain.cshtml")]
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
#line 1 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using T03_CompetitionPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1151a7109f3a7b4fc6d16b0414752b35fc6813", @"/Views/Admin/AdminMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Admin/_AdminNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\AdminMain.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc1151a7109f3a7b4fc6d16b0414752b35fc68134039", async() => {
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

<!-- -->
<!--Start of containers -->

<div class=""container"">
    <div class=""row justify-content-md-center"">
        <div class=""col-md-auto"">
            <p style=""margin-top: 70px;
        font-family: Arial;
        font-size: 300%;
        text-align: center;"">Statistics</p>
        </div>
    </div>
</div>

<div class=""container-fluid"" style=""border: 2px;
     border-style: solid;
     border-color: black;
     padding: 8em 8em 8em 8em;>

    <div class=""row justify-content-center"">

        <div class=""col-md-auto"">
            <p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><u>Areas of Interest</u></p>

            <p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><b>");
#nullable restore
#line 31 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\AdminMain.cshtml"
                                                                             Write(TempData["areaCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></p>

        </div>
        <div class=""col-md-auto"">
            <p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><u>Competition Records</u></p>

            <p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><b>");
#nullable restore
#line 37 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\AdminMain.cshtml"
                                                                             Write(TempData["competitionCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n\r\n        </div>\r\n        <div class=\"col-md-auto\">\r\n            <p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><u>Amount of Judges</u></p>\r\n\r\n            <p class=\"text-center\" style=\"font-family: Arial;font-size: 150%;\"><b>");
#nullable restore
#line 43 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\AdminMain.cshtml"
                                                                             Write(TempData["judgesCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></p>

        </div>
        <div class=""col-md-auto"">
            <p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><u>Amount of Competitors</u></p>

            <p class=""text-center"" style=""font-family: Arial;font-size: 150%;""><b>");
#nullable restore
#line 49 "C:\Users\Drake\Desktop\WEBASSIGNMENT\wednesdaypull\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Admin\AdminMain.cshtml"
                                                                             Write(TempData["competitorsCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
