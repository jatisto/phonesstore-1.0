#pragma checksum "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3378cb4db7f87be422ef4c7dd277a18c0a110303"
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
#line 1 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\_ViewImports.cshtml"
using MyFirstMVC;

#line default
#line hidden
#line 2 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\_ViewImports.cshtml"
using MyFirstMVC.Models;

#line default
#line hidden
#line 1 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
#line 2 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
using MyFirstMVC.Controllers;

#line default
#line hidden
#line 3 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
using MyFirstMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3378cb4db7f87be422ef4c7dd277a18c0a110303", @"/Views/Phones/Index.cshtml")]
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
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(131, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(182, 11, true);
            WriteLiteral("\r\n<br/>\r\n\r\n");
            EndContext();
#line 15 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
 using (Html.BeginForm("Index", "Phones", FormMethod.Get))

{
    

#line default
#line hidden
            BeginContext(263, 28, false);
#line 18 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
Write(Html.Label("Name", "Модель"));

#line default
#line hidden
            EndContext();
            BeginContext(298, 32, false);
#line 19 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
Write(Html.TextBox("name", Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(334, 60, true);
            WriteLiteral("    <select name=\"companyId\" class=\"form-control\">\r\n        ");
            EndContext();
            BeginContext(394, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404a4dad5c024910804f83826670cf94", async() => {
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
            BeginContext(411, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
         foreach (Company comp in Model.Companies)
        {
            if (Model.Company != null && Model.Company.Id == comp.Id)
            {

#line default
#line hidden
            BeginContext(562, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(578, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a85e04c8c742e988de8c932d04560a", async() => {
                BeginContext(624, 9, false);
#line 27 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                                                        Write(comp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
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
            BeginContext(642, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(692, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(708, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba4b8497972448ada56a50083931cc63", async() => {
                BeginContext(734, 9, false);
#line 31 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                                    Write(comp.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 31 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
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
            BeginContext(752, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(780, 29, true);
            WriteLiteral("\r\n        \r\n\r\n    </select>\r\n");
            EndContext();
            BeginContext(811, 52, true);
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-success\"/>\r\n");
            EndContext();
            BeginContext(1022, 57, true);
            WriteLiteral("    <select name=\"Rating\" class=\"form-control\">\r\n        ");
            EndContext();
            BeginContext(1079, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69fbe99560ec440bb7a30a610a219872", async() => {
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
            BeginContext(1096, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1340, 15, true);
            WriteLiteral("    </select>\r\n");
            EndContext();
#line 53 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1358, 13, true);
            WriteLiteral("\r\n\r\n<br/>\r\n\r\n");
            EndContext();
#line 58 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
 using (Html.BeginForm("Index", "Phones", FormMethod.Get))

{

#line default
#line hidden
            BeginContext(1436, 44, true);
            WriteLiteral("    <table class=\"table table-bordered\">\r\n\r\n");
            EndContext();
#line 63 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
         foreach (Phone p in Model.Phones)
        {

#line default
#line hidden
            BeginContext(1535, 40, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1576, 6, false);
#line 67 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
               Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 51, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1633, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47368add8c784fc08368c4b14825263f", async() => {
                BeginContext(1727, 15, false);
#line 70 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
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
#line 70 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
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
            BeginContext(1746, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1816, 7, false);
#line 74 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
               Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1823, 31, true);
            WriteLiteral(" $ <br>\r\n\r\n                    ");
            EndContext();
            BeginContext(1856, 25, false);
#line 76 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
                Write(p.Price * ViewBag.RateKgs);

#line default
#line hidden
            EndContext();
            BeginContext(1882, 77, true);
            WriteLiteral(" сом\r\n\r\n                </td>\r\n                \r\n       \r\n            </tr>\r\n");
            EndContext();
#line 82 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1970, 18, true);
            WriteLiteral("\r\n\r\n    </table>\r\n");
            EndContext();
#line 86 "C:\home\Git_work\phonesstore-1.0\MyFirstMVC\MyFirstMVC\Views\Phones\Index.cshtml"
}

#line default
#line hidden
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
