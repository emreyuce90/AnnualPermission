#pragma checksum "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b27cd50c594459232f83eec3d525b1ff64d57a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Personel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Personel/Default.cshtml")]
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
#nullable restore
#line 1 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/_ViewImports.cshtml"
using AnnualPermissionApp.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/_ViewImports.cshtml"
using AnnualPermissionApp.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2b27cd50c594459232f83eec3d525b1ff64d57a", @"/Views/Shared/Components/Personel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604ea71934643de12542c78aebf1876b63533904", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Personel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PermissionDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<div class=\"card mb-3\">\n  <div class=\"row g-0\">\n   \n    <div class=\"col-md-4 my-auto\">\n     <h5 class=\"card-title text-center display-6\">KALAN TOPLAM İZİN SAYISI</h5>\n     <p class=\"display-1 text-center \">");
#nullable restore
#line 10 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                  Write(Model.TotalRemains);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <div class=\"col-md-8\">\n      <div class=\"card-body\">\n      \n            \n        \n\n        <ul class=\"list-group list-group-flush\">\n          <li class=\"list-group-item\"><strong>Geçen yıl izin hakkı :</strong>");
#nullable restore
#line 19 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                        Write(Model.LastPermission);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</li>\n          <li class=\"list-group-item\"><strong>Geçen yıl kullandığı izinler :</strong>");
#nullable restore
#line 20 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                                Write(Model.LastYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\n          <li class=\"list-group-item\"><strong>Geçen yıldan kalan izinler :</strong>");
#nullable restore
#line 21 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                              Write(Model.RemainsLastYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\n             <li class=\"list-group-item\"><strong>Bu yıl izin hakkı :</strong>");
#nullable restore
#line 22 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                        Write(Model.ThisPermission);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</li>\n          <li class=\"list-group-item\"><strong>Bu yıl kullandığı izinler :</strong>");
#nullable restore
#line 23 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                             Write(Model.ThisYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\n          <li class=\"list-group-item\"><strong>Bu yıldan kalan izinler :</strong>");
#nullable restore
#line 24 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                           Write(Model.RemainsThisYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\n         <li class=\"list-group-item\"><strong>Kalan Toplam İzin Hakkı :</strong>");
#nullable restore
#line 25 "/home/emre/Desktop/AnnualPermission/AnnualPermissionApp.UI/Views/Shared/Components/Personel/Default.cshtml"
                                                                          Write(Model.TotalRemains);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GÜN</span></li>\n        </ul>\n\n      </div>\n    </div>\n  </div>\n</div>\n\n");
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