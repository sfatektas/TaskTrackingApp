#pragma checksum "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccb2eac923452345929f1f84a023f25f5727507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserManagment), @"mvc.1.0.view", @"/Views/Admin/UserManagment.cshtml")]
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
#line 1 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\_ViewImports.cshtml"
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccb2eac923452345929f1f84a023f25f5727507", @"/Views/Admin/UserManagment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22affdcb49678f5888102fd3fb4565885c1ce254", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_UserManagment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUserListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<a class=""btn btn-sm btn-success float-right"">Create</a>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Ad</th>
            <th scope=""col"">Soyad</th>
            <th scope=""col"">Kullanıcı Adı</th>
            <th scope=""col"">Degree</th>
            <th scope=""col"">Email</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>#</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
               Write(item.DegreeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-sm btn-danger\">Remove</a></td>\r\n                <td><a class=\"btn btn-sm btn-primary\">Update</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\SEFA$$\Desktop\TaskTracking\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\Admin\UserManagment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUserListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
