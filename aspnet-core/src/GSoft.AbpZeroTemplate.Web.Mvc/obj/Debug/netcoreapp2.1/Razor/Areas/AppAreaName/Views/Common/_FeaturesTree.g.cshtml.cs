#pragma checksum "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_FeaturesTree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cef03a4ef31f10dbecc5bcd24ed319a494b74e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Common__FeaturesTree), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Common/_FeaturesTree.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Common/_FeaturesTree.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Common__FeaturesTree))]
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
#line 1 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_FeaturesTree.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cef03a4ef31f10dbecc5bcd24ed319a494b74e4", @"/Areas/AppAreaName/Views/Common/_FeaturesTree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b1e16907496b203fba5485cd552517620edae5", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Common__FeaturesTree : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<IFeatureEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 32, true);
            WriteLiteral("<div class=\"feature-tree\">\r\n    ");
            EndContext();
            BeginContext(129, 112, false);
#line 4 "E:\Nam 3\HKII\CNPMCS\Zero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Common\_FeaturesTree.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_FeaturesTreeItem.cshtml", new FeatureTreeItemModel(Model, null)));

#line default
#line hidden
            EndContext();
            BeginContext(241, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IFeatureEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
