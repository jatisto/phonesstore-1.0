#pragma checksum "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c6d2be6753094ea94721a9ca4f557c3615393d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phones_Index), @"mvc.1.0.view", @"/Views/Phones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phones/Index.cshtml", typeof(AspNetCore.Views_Phones_Index))]
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
#line 1 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\_ViewImports.cshtml"
using MyFirstMVC;

#line default
#line hidden
#line 2 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\_ViewImports.cshtml"
using MyFirstMVC.Models;

#line default
#line hidden
#line 1 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
#line 2 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
using MyFirstMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c6d2be6753094ea94721a9ca4f557c3615393d", @"/Views/Phones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e482ba3a3f35fa61a70b3eb85ec3953dd559789", @"/Views/_ViewImports.cshtml")]
    public class Views_Phones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Phones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(151, 11, true);
            WriteLiteral("\r\n<br/>\r\n\r\n");
            EndContext();
#line 14 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
 using (Html.BeginForm("Index", "Phones", FormMethod.Get))

{
    

#line default
#line hidden
            BeginContext(232, 28, false);
#line 17 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
Write(Html.Label("Name", "Модель"));

#line default
#line hidden
            EndContext();
            BeginContext(267, 32, false);
#line 18 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
Write(Html.TextBox("name", Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(307, 60, true);
            WriteLiteral("    <select name=\"companyId\" class=\"form-control\">\r\n        ");
            EndContext();
            BeginContext(367, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc873aff1a5d4cc5b251e001c11c7604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
         foreach (Company comp in Model.Companies)
        {
            if (Model.Company != null && Model.Company.Id == comp.Id)
            {

#line default
#line hidden
            BeginContext(535, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(551, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9252768fe33d4222ab313402a6175198", async() => {
                BeginContext(597, 9, false);
#line 26 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                                                        Write(comp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 26 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                   WriteLiteral(comp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(665, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(681, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5010cbaa82fd4a2a970b85b524e83b6a", async() => {
                BeginContext(707, 9, false);
#line 30 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                                    Write(comp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 30 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                   WriteLiteral(comp.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(725, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(753, 15, true);
            WriteLiteral("    </select>\r\n");
            EndContext();
            BeginContext(770, 52, true);
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-success\"/>\r\n");
            EndContext();
#line 36 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(825, 11, true);
            WriteLiteral("\r\n<br/>\r\n\r\n");
            EndContext();
#line 40 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
 using (Html.BeginForm("Index", "Phones", FormMethod.Get))

{

#line default
#line hidden
            BeginContext(901, 44, true);
            WriteLiteral("    <table class=\"table table-bordered\">\r\n\r\n");
            EndContext();
#line 45 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
         foreach (Phone p in Model.Phones)
        {

#line default
#line hidden
            BeginContext(1000, 40, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1041, 6, false);
#line 49 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
               Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 66, true);
            WriteLiteral("</td>\r\n               \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1113, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2ff671694564ab08f912ae99c2da00b", async() => {
                BeginContext(1207, 15, false);
#line 52 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                                                                                                            Write(p.Company?.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-companyId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                                                                                       WriteLiteral(p.CompanyId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["companyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-companyId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["companyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1226, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1296, 7, false);
#line 56 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
               Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 31, true);
            WriteLiteral(" $ <br>\r\n\r\n                    ");
            EndContext();
            BeginContext(1336, 25, false);
#line 58 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                Write(p.Price * ViewBag.RateKgs);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 52, true);
            WriteLiteral(" сом\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 63 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1425, 18, true);
            WriteLiteral("\r\n\r\n    </table>\r\n");
            EndContext();
#line 67 "M:\MailCloudW\Git repo mail\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1446, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
