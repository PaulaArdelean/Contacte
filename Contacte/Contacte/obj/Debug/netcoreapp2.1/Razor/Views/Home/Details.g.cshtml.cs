#pragma checksum "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33a4ffdb3b14a6a7b24a3e76d8d640fc1789ab1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "E:\NetIq\Contacte\Contacte\Contacte\Views\_ViewImports.cshtml"
using Contacte;

#line default
#line hidden
#line 2 "E:\NetIq\Contacte\Contacte\Contacte\Views\_ViewImports.cshtml"
using Contacte.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33a4ffdb3b14a6a7b24a3e76d8d640fc1789ab1", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13869e05884b25bc855e1375b61ebb9a3d498ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contacte.Models.Entities.Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 97, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(184, 24, false);
#line 12 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayName("Nume"));

#line default
#line hidden
            EndContext();
            BeginContext(208, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(252, 40, false);
#line 15 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(336, 27, false);
#line 18 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayName("Prenume"));

#line default
#line hidden
            EndContext();
            BeginContext(363, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(407, 41, false);
#line 21 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(492, 25, false);
#line 24 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(517, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(561, 37, false);
#line 27 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(642, 23, false);
#line 30 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayName("CNP"));

#line default
#line hidden
            EndContext();
            BeginContext(665, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(709, 35, false);
#line 33 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.CNP));

#line default
#line hidden
            EndContext();
            BeginContext(744, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(788, 36, false);
#line 36 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayName("Numar de telefon"));

#line default
#line hidden
            EndContext();
            BeginContext(824, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(868, 43, false);
#line 39 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(955, 26, false);
#line 42 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayName("Adresa"));

#line default
#line hidden
            EndContext();
            BeginContext(981, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1025, 39, false);
#line 45 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1112, 62, false);
#line 50 "E:\NetIq\Contacte\Contacte\Contacte\Views\Home\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", "Home", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1182, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d46d221c3194711abede5f62a49e117", async() => {
                BeginContext(1204, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1220, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contacte.Models.Entities.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
