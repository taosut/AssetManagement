#pragma checksum "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b5fff2501400aecb925b1c97bc41d8cc5c0ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TenantRegistration_RegisterResult), @"mvc.1.0.view", @"/Views/TenantRegistration/RegisterResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TenantRegistration/RegisterResult.cshtml", typeof(AspNetCore.Views_TenantRegistration_RegisterResult))]
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
#line 1 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b5fff2501400aecb925b1c97bc41d8cc5c0ba5", @"/Views/TenantRegistration/RegisterResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b1e16907496b203fba5485cd552517620edae5", @"/Views/_ViewImports.cshtml")]
    public class Views_TenantRegistration_RegisterResult : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<GSoft.AbpZeroTemplate.Web.Models.TenantRegistration.TenantRegisterResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
  
    ViewBag.DisableTenantChange = true;

#line default
#line hidden
            BeginContext(138, 4, true);
            WriteLiteral("<h4>");
            EndContext();
            BeginContext(143, 27, false);
#line 5 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
Write(L("SuccessfullyRegistered"));

#line default
#line hidden
            EndContext();
            BeginContext(170, 47, true);
            WriteLiteral(".</h4>\r\n<ul>\r\n    <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(218, 16, false);
#line 7 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                            Write(L("TenancyName"));

#line default
#line hidden
            EndContext();
            BeginContext(234, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(244, 17, false);
#line 7 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                                                      Write(Model.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(261, 40, true);
            WriteLiteral("</li>\r\n    <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(302, 9, false);
#line 8 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                            Write(L("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(311, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(321, 10, false);
#line 8 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(331, 40, true);
            WriteLiteral("</li>\r\n    <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(372, 13, false);
#line 9 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                            Write(L("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(385, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(395, 14, false);
#line 9 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                                                   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(409, 40, true);
            WriteLiteral("</li>\r\n    <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(450, 17, false);
#line 10 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                            Write(L("EmailAddress"));

#line default
#line hidden
            EndContext();
            BeginContext(467, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(477, 18, false);
#line 10 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                                                       Write(Model.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(495, 21, true);
            WriteLiteral("</li>\r\n</ul>\r\n<div>\r\n");
            EndContext();
#line 13 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
     if (Model.IsEmailConfirmationRequired)
    {

#line default
#line hidden
            BeginContext(568, 68, true);
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            ");
            EndContext();
            BeginContext(637, 70, false);
#line 16 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
       Write(L("ConfirmationMailSentPleaseClickLinkInTheEmail", Model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(707, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 18 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
    }

#line default
#line hidden
            BeginContext(732, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 19 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
     if (!Model.IsActive)
    {

#line default
#line hidden
            BeginContext(766, 68, true);
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            ");
            EndContext();
            BeginContext(835, 45, false);
#line 22 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
       Write(L("YourAccountIsWaitingToBeActivatedByAdmin"));

#line default
#line hidden
            EndContext();
            BeginContext(880, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 24 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
    }

#line default
#line hidden
            BeginContext(905, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 25 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
     if (!string.IsNullOrEmpty(Model.TenantLoginAddress))
    {

#line default
#line hidden
            BeginContext(971, 65, true);
            WriteLiteral("        <div class=\"alert alert-info\" role=\"alert\">\r\n            ");
            EndContext();
            BeginContext(1037, 32, false);
#line 28 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
       Write(L("TenantRegistrationLoginInfo"));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 22, true);
            WriteLiteral("<br />\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1123, 1);
#line 29 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
WriteAttributeValue("", 1098, Model.TenantLoginAddress, 1098, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1124, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1126, 24, false);
#line 29 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
                                           Write(Model.TenantLoginAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 22, true);
            WriteLiteral("</a>\r\n        </div>\r\n");
            EndContext();
#line 31 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\RegisterResult.cshtml"
    }

#line default
#line hidden
            BeginContext(1179, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSoft.AbpZeroTemplate.Web.Models.TenantRegistration.TenantRegisterResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
