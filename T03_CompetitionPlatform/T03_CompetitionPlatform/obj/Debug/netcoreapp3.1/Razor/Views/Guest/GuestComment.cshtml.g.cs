#pragma checksum "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5344ae184a3b0564e38746a157f22f1724e8fb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_GuestComment), @"mvc.1.0.view", @"/Views/Guest/GuestComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5344ae184a3b0564e38746a157f22f1724e8fb0", @"/Views/Guest/GuestComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b42a61474eeeeb0379fcda10cfcc60d7ef9e8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Guest_GuestComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<T03_CompetitionPlatform.Models.Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Guest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 20px;color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewCompetitors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/guestLogout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/guesticon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:80px; max-height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
  
    ViewData["Title"] = "Guest Comment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5344ae184a3b0564e38746a157f22f1724e8fb07551", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <!-- jQuery library -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"">
    </script>
    <link rel=""stylesheet""
          href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"">
    <!-- Popper JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.1/umd/popper.min.js"">
    </script>
    <title>ViewCompetitorWork</title>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5344ae184a3b0564e38746a157f22f1724e8fb09009", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-md bg-dark navbar-dark fixed-top"">
        <!-- The brand(or icon) of the navbar -->
        <a class=""navbar-brand""
           style=""font-size:32px; font-weight:bold; color:darkorange;"">
            CJP
        </a>
        <!-- Toggle/collapsible Button, also known as hamburger button -->
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse""
                data-target=""#guestNavbar"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <!-- Links in the navbar, displayed as drop-down list when collapsed -->
        <div class=""collapse navbar-collapse"" id=""guestNavbar"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5344ae184a3b0564e38746a157f22f1724e8fb010074", async() => {
                    WriteLiteral("\r\n                        Home\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5344ae184a3b0564e38746a157f22f1724e8fb011522", async() => {
                    WriteLiteral("\r\n                        Go back\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                                                                       WriteLiteral(ViewData["CompID"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                                                                                                            WriteLiteral(ViewData["CompName"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </li>\r\n            </ul>\r\n\r\n            <ul class=\"navbar-nav ml-auto\">\r\n\r\n                <li class=\"nav-item\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5344ae184a3b0564e38746a157f22f1724e8fb015147", async() => {
                    WriteLiteral("\r\n                        Log Out\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </li>

            </ul>
        </div>
    </nav>
    <div class=""container"">
        <div class=""row flex-nowrap justify-content-between align-items-center"">
            <div class=""col-md-12 mx-auto"">
                <div class=""page-header"">
                    <h1><small class=""pull-right"">");
#nullable restore
#line 67 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                                             Write(Model.ToList().Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" comments</small></h1>\r\n                </div>\r\n                <div class=\"comments-list\">\r\n");
#nullable restore
#line 70 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                     if (Model.ToList().Count > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                         foreach (var c in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"media\">\r\n                                <p class=\"pull-right mr-3\" style=\"max-width:50px;\"><small>");
#nullable restore
#line 75 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                                                                                     Write(c.DateTimePosted);

#line default
#line hidden
#nullable disable
                WriteLiteral(".</small></p>\r\n                                <a");
                BeginWriteAttribute("class", " class=\"", 3028, "\"", 3036, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5344ae184a3b0564e38746a157f22f1724e8fb018732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </a>\r\n                                <div class=\"media-body ml-3 mb-3\">\r\n                                    <h6 class=\"media-heading user_name\">Guest</h6>\r\n                                    ");
#nullable restore
#line 81 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                               Write(c.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 84 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span style=\"color:red\">No record found!</span>\r\n");
#nullable restore
#line 89 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                    </div>
                </div>
            </div>       
                   
                    <div class=""container"">
                        <div class=""row flex-nowrap justify-content-between align-items-center"">
                            <input type=""button"" class=""btn btn-dark btn-lg mx-auto"" value=""Add a comment""");
                BeginWriteAttribute("onclick", " onclick=\"", 4057, "\"", 4151, 3);
                WriteAttributeValue("", 4067, "location.href=\'", 4067, 15, true);
#nullable restore
#line 98 "F:\1) Ngee Ann Poly\Year 2 Sem 1\Web Application Development\Assg Repo\T03_CompetitionPlatform\T03_CompetitionPlatform\Views\Guest\GuestComment.cshtml"
WriteAttributeValue("", 4082, Url.Action("PostComment", "Guest", new { id = ViewData["CompID"] }), 4082, 68, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4150, "\'", 4150, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<T03_CompetitionPlatform.Models.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
