#pragma checksum "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c233da89416e9a29b89bb775e7d02dc5f97bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TradeNews.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml", typeof(TradeNews.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), null)]
namespace TradeNews.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\_ViewImports.cshtml"
using TradeNews.Areas.Identity;

#line default
#line hidden
#line 1 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using TradeNews.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using TradeNews.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c233da89416e9a29b89bb775e7d02dc5f97bab", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da2b99e8dbde71ce8d08dd9dd5df5405d5ea376", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0b2585540196f64f616f03c6b1a61c18e5e5df", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a74d80d68114c7393f36b0557470621efb9646e", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link-login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(101, 51, false);
#line 7 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(195, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 13 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
            BeginContext(343, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(390, 19, false);
#line 16 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                   Write(login.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(409, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 18 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
            BeginContext(523, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(547, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9836ca8142cb4c7085b553f4cfd92f75", async() => {
                BeginContext(616, 69, true);
                WriteLiteral("\r\n                            <div>\r\n                                ");
                EndContext();
                BeginContext(685, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "98af5bcf5d3c4cdf81b3bc15e95d91fc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(760, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(794, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b56f1f091664a27a2a18afe8d82d67c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 23 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(865, 79, true);
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 944, "\"", 1008, 7);
                WriteAttributeValue("", 952, "Remove", 952, 6, true);
                WriteAttributeValue(" ", 958, "this", 959, 5, true);
#line 24 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 963, login.LoginProvider, 964, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 984, "login", 985, 6, true);
                WriteAttributeValue(" ", 990, "from", 991, 5, true);
                WriteAttributeValue(" ", 995, "your", 996, 5, true);
                WriteAttributeValue(" ", 1000, "account", 1001, 8, true);
                EndWriteAttribute();
                BeginContext(1009, 78, true);
                WriteLiteral(">Remove</button>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1094, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1180, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1206, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 31 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1242, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1307, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 37 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#line 38 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(1381, 61, true);
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1442, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc5d0ec6cf8e47a9a88494d2828a20e2", async() => {
                BeginContext(1536, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 45 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1672, 104, true);
                WriteLiteral("                    <button id=\"link-login-button\" type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1776, "\"", 1798, 1);
#line 47 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1784, provider.Name, 1784, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1799, "\"", 1854, 6);
                WriteAttributeValue("", 1807, "Log", 1807, 3, true);
                WriteAttributeValue(" ", 1810, "in", 1811, 3, true);
                WriteAttributeValue(" ", 1813, "using", 1814, 6, true);
                WriteAttributeValue(" ", 1819, "your", 1820, 5, true);
#line 47 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1824, provider.DisplayName, 1825, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1846, "account", 1847, 8, true);
                EndWriteAttribute();
                BeginContext(1855, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1857, 20, false);
#line 47 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                                                                   Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1877, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 48 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(1907, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1952, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "D:\TradeNews\TradeNews\TradeNews\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
