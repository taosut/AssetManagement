#pragma checksum "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\Modals\Empty\_Empty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a17003b5cba6f0254c7141a54b1c2919497e00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Common_Modals_Empty__Empty), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Common/Modals/Empty/_Empty.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Common/Modals/Empty/_Empty.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Common_Modals_Empty__Empty))]
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
#line 1 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\Modals\Empty\_Empty.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a17003b5cba6f0254c7141a54b1c2919497e00", @"/Areas/AppAreaName/Views/Common/Modals/Empty/_Empty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b1e16907496b203fba5485cd552517620edae5", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Common_Modals_Empty__Empty : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 117, false);
#line 2 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\Modals\Empty\_Empty.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel("MODAL HEADER")));

#line default
#line hidden
            EndContext();
            BeginContext(191, 65, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    TODO: Modal Content\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(257, 92, false);
#line 8 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\Modals\Empty\_Empty.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(349, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
