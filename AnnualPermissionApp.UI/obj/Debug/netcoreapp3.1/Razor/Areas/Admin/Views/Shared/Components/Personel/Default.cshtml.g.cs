#pragma checksum "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f547d7f5ab38649df38f810c2e75223b681267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AnnualPermissionApp.DTO.Shared.Components.Personel.Areas_Admin_Views_Shared_Components_Personel_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Personel/Default.cshtml")]
namespace AnnualPermissionApp.DTO.Shared.Components.Personel
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
#line 2 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\_ViewImports.cshtml"
using AnnualPermissionApp.UI.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f547d7f5ab38649df38f810c2e75223b681267", @"/Areas/Admin/Views/Shared/Components/Personel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d58ceccdb582277f9060f7a361c8818465e7a3e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Personel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PermissionDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"card mb-3\">\r\n  <div class=\"row g-0\">\r\n   \r\n    <div class=\"col-md-4 my-auto\">\r\n     <h5 class=\"card-title text-center display-6\">KALAN TOPLAM İZİN SAYISI</h5>\r\n     <p class=\"display-1 text-center \">");
#nullable restore
#line 10 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                  Write(Model.TotalRemains);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n      <div class=\"card-body\">\r\n      \r\n            \r\n        \r\n\r\n        <ul class=\"list-group list-group-flush\">\r\n          <li class=\"list-group-item\"><strong>Geçen yıl izin hakkı :</strong>");
#nullable restore
#line 19 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                        Write(Model.LastPermission);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</li>\r\n          <li class=\"list-group-item\"><strong>Geçen yıl kullandığı izinler :</strong>");
#nullable restore
#line 20 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                                Write(Model.LastYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\r\n          <li class=\"list-group-item\"><strong>Geçen yıldan kalan izinler :</strong>");
#nullable restore
#line 21 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                              Write(Model.RemainsLastYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\r\n             <li class=\"list-group-item\"><strong>Bu yıl izin hakkı :</strong>");
#nullable restore
#line 22 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                        Write(Model.ThisPermission);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</li>\r\n          <li class=\"list-group-item\"><strong>Bu yıl kullandığı izinler :</strong>");
#nullable restore
#line 23 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                             Write(Model.ThisYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\r\n          <li class=\"list-group-item\"><strong>Bu yıldan kalan izinler :</strong>");
#nullable restore
#line 24 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                           Write(Model.RemainsThisYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\r\n         <li class=\"list-group-item\"><strong>Kalan Toplam İzin Hakkı :</strong>");
#nullable restore
#line 25 "C:\Users\EMRE\Desktop\AnnualPermission\AnnualPermissionApp.UI\Areas\Admin\Views\Shared\Components\Personel\Default.cshtml"
                                                                          Write(Model.TotalRemains);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\r\n        </ul>\r\n\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PermissionDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
