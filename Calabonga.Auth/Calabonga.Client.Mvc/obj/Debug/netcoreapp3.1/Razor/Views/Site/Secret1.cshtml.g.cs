#pragma checksum "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220b1ab24e2da2bb2fbbf124ef1200e666a51896"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_Secret1), @"mvc.1.0.view", @"/Views/Site/Secret1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220b1ab24e2da2bb2fbbf124ef1200e666a51896", @"/Views/Site/Secret1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_Secret1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Calabonga.Client.Mvc.ViewModels.ClaimManager>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("62"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    body {
        background-color: #f1f1f1;
    }

    .content {
        width: 100%;
        padding: .5em;
        display: flex;
        flex-direction: row;
        font-family: sans-serif;
    }

    .column {
        flex: 1 1 0;
        margin: 0 2px;
    }

    .title {
        font-weight: bold;
        color: black;
        border: 1px solid #ccc;
        padding: 2px;
        margin: 1px;
        text-align: right;
        width: 7em;
        overflow: hidden;
        background-color: #fefefe;
        display: inline-block;
    }

    .value {
        color: black;
        border: 1px solid #ccc;
        padding: 1px 5px;
        margin: 1px;
        min-width: 20em;
        max-width: 20em;
        overflow: hidden;
        display: inline-block;
        color: #123ab8;
    }

    span {
        background-color: #fff;
    }

    h3 {
        padding: .5em;
        background-color: #cd37c3;
        color: white;
    }

        h3 ");
            WriteLiteral("b {\r\n            color: yellow;\r\n        }\r\n</style>\r\n\r\n<h1>Secret</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "220b1ab24e2da2bb2fbbf124ef1200e666a518965002", async() => {
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
            WriteLiteral("\r\n\r\n<p>\r\n    ");
#nullable restore
#line 66 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"content\">\r\n");
#nullable restore
#line 70 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"column\">\r\n\r\n            <h3>\r\n                ");
#nullable restore
#line 75 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>");
#nullable restore
#line 75 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
                         Write(item.Claims.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </h3>\r\n\r\n            <div>\r\n                <p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "220b1ab24e2da2bb2fbbf124ef1200e666a518967289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 80 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Token);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n\r\n");
#nullable restore
#line 85 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
             foreach (var claim in item.Claims)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"title\"");
            BeginWriteAttribute("title", " title=\"", 1680, "\"", 1699, 1);
#nullable restore
#line 87 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
WriteAttributeValue("", 1688, claim.Type, 1688, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
                                                   Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span>\r\n                <span class=\"value\"");
            BeginWriteAttribute("title", " title=\"", 1757, "\"", 1777, 1);
#nullable restore
#line 88 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
WriteAttributeValue("", 1765, claim.Value, 1765, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 88 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
                                                    Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n");
#nullable restore
#line 89 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 91 "D:\JS\React\Calabonga\Calabonga.Auth\Calabonga.Client.Mvc\Views\Site\Secret1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Calabonga.Client.Mvc.ViewModels.ClaimManager> Html { get; private set; }
    }
}
#pragma warning restore 1591
