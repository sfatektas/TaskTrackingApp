#pragma checksum "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\TaskStatues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0b1234186bb1eb6d770855b773a00400785268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TaskStatues), @"mvc.1.0.view", @"/Views/Admin/TaskStatues.cshtml")]
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
#line 1 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0b1234186bb1eb6d770855b773a00400785268", @"/Views/Admin/TaskStatues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22affdcb49678f5888102fd3fb4565885c1ce254", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_TaskStatues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\TaskStatues.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3 class=""text-center"">Görev Durumları</h3>

<table class=""table my-3"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Görevi Alan Kullanıcı Adı</th>
            <th scope=""col"">Başlık</th>
            <th scope=""col"">Görev Tanımı</th>
            <th scope=""col"">Aciliyet</th>
            <th scope=""col"">İş Durumu</th>
            <th scope=""col"">Oluşturulma Zamanı</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>sfatketas</td>
            <td>Footer Link</td>
            <td>Footerda bulunan iconların linkleri düzenlenecek</td>
            <td>Düşük</td>
            <td>Devam Ediyor</td>
            <td>1 saat önce</td>
            <td><a class=""btn btn-warning"">Devam Ediyor</a></td>
        </tr>

        <tr>
            <td>2</td>
            <td>sfatketas</td>
            <td>User Controller</td>
            <td>Controller düzenlenecek</td>
           ");
            WriteLiteral(@" <td>Çok Acil</td>
            <td>Devam Ediyor</td>
            <td>7 saat önce</td>
            <td><a class=""btn btn-warning"">Devam Ediyor</a></td>
        </tr>

        <tr>
            <td>3</td>
            <td>sfatketas</td>
            <td>Navbar </td>
            <td>Footerda bulunan iconların linkleri düzenlenecek</td>
            <td>Düşük</td>
            <td>Tamamlandı</td>
            <td>16 saat önce</td>
            <td><a class=""btn btn-info"">Görevin Detaylarını Gör.</a></td>
        </tr>

    </tbody>
</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
