#pragma checksum "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d78a7bdd112c94641f91a123b84ca48c9cbfdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Roles__CreateOrEditModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Roles/_CreateOrEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Roles/_CreateOrEditModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Roles__CreateOrEditModal))]
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
#line 1 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 2 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Authorization.Roles;

#line default
#line hidden
#line 3 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 4 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Roles;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d78a7bdd112c94641f91a123b84ca48c9cbfdf", @"/Areas/AppAreaName/Views/Roles/_CreateOrEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b1e16907496b203fba5485cd552517620edae5", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Roles__CreateOrEditModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<CreateOrEditRoleModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("RoleInformationsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(250, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(253, 190, false);
#line 7 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(Model.IsEditMode ? (L("EditRole") + ": " + Model.Role.DisplayName) : L("CreateNewRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(443, 262, true);
            WriteLiteral(@"

<div class=""modal-body"">

    <ul class=""nav nav-tabs  m-tabs-line"" role=""tablist"">
        <li class=""nav-item m-tabs__item"">
            <a href=""#RoleInformationsTab"" class=""nav-link m-tabs__link active"" data-toggle=""tab"" role=""tab"">
                ");
            EndContext();
            BeginContext(706, 19, false);
#line 14 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
           Write(L("RoleProperties"));

#line default
#line hidden
            EndContext();
            BeginContext(725, 194, true);
            WriteLiteral("\r\n            </a>\r\n        </li>\r\n        <li class=\"nav-item m-tabs__item\">\r\n            <a href=\"#PermissionsTab\" class=\"nav-link m-tabs__link\" data-toggle=\"tab\" role=\"tab\">\r\n                ");
            EndContext();
            BeginContext(920, 16, false);
#line 19 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
           Write(L("Permissions"));

#line default
#line hidden
            EndContext();
            BeginContext(936, 173, true);
            WriteLiteral("\r\n            </a>\r\n        </li>\r\n    </ul>\r\n\r\n\r\n    <div class=\"tab-content\">\r\n        <div class=\"tab-pane active\" id=\"RoleInformationsTab\" role=\"tabpanel\">\r\n            ");
            EndContext();
            BeginContext(1109, 1120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "394c8494020c421bb90cd4d6fbab0472", async() => {
                BeginContext(1190, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 29 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                 if (Model.IsEditMode)
                {

#line default
#line hidden
                BeginContext(1253, 50, true);
                WriteLiteral("                    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1303, "\"", 1325, 1);
#line 31 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1311, Model.Role.Id, 1311, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1326, 4, true);
                WriteLiteral("/>\r\n");
                EndContext();
#line 32 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                }

#line default
#line hidden
                BeginContext(1349, 86, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"RoleName\">");
                EndContext();
                BeginContext(1436, 13, false);
#line 35 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                                     Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(1449, 50, true);
                WriteLiteral("</label>\r\n                    <input id=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1499, "\"", 1577, 2);
                WriteAttributeValue("", 1507, "form-control", 1507, 12, true);
#line 36 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1519, Model.Role.DisplayName.IsNullOrEmpty() ? "" : " edited", 1519, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1578, 31, true);
                WriteLiteral(" type=\"text\" name=\"DisplayName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1609, "\"", 1640, 1);
#line 36 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1617, Model.Role.DisplayName, 1617, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1641, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1650, "\"", 1688, 1);
#line 36 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1662, Role.MaxDisplayNameLength, 1662, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1689, 241, true);
                WriteLiteral(">\r\n                </div>\r\n                \r\n                <div class=\"m-checkbox-list\">\r\n                    <label class=\"m-checkbox\">\r\n                        <input id=\"EditRole_IsDefault\" type=\"checkbox\" name=\"IsDefault\" value=\"true\" ");
                EndContext();
                BeginContext(1931, 59, false);
#line 41 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                                                                                                Write(Html.Raw(Model.Role.IsDefault ? "checked=\"checked\"" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(1990, 27, true);
                WriteLiteral(">\r\n                        ");
                EndContext();
                BeginContext(2018, 12, false);
#line 42 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                   Write(L("Default"));

#line default
#line hidden
                EndContext();
                BeginContext(2030, 116, true);
                WriteLiteral("\r\n                        <span></span>\r\n                    </label>\r\n                    <span class=\"help-block\">");
                EndContext();
                BeginContext(2147, 28, false);
#line 45 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                                        Write(L("DefaultRole_Description"));

#line default
#line hidden
                EndContext();
                BeginContext(2175, 47, true);
                WriteLiteral("</span>\r\n                </div>\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2229, 98, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"tab-pane\" id=\"PermissionsTab\" role=\"tabpanel\">\r\n            ");
            EndContext();
            BeginContext(2328, 78, false);
#line 51 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
       Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_PermissionTree.cshtml", Model));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 111, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"alert alert-warning\" style=\"margin-top: 30px;\">\r\n        <em>");
            EndContext();
            BeginContext(2518, 41, false);
#line 57 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
       Write(L("Note_RefreshPageForPermissionChanges"));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 29, true);
            WriteLiteral("</em>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2589, 92, false);
#line 61 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateOrEditRoleModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
