#pragma checksum "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237a8a7d97cf7c753300b6cfe4debfe63539563d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Components_TasksComponent_Default), @"mvc.1.0.view", @"/Views/User/Components/TasksComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237a8a7d97cf7c753300b6cfe4debfe63539563d", @"/Views/User/Components/TasksComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22affdcb49678f5888102fd3fb4565885c1ce254", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Components_TasksComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUserTaskListDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ComplateTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
  
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table my-3"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Başlık</th>
            <th scope=""col"">Görev Tanımı</th>
            <th scope=""col"">Aciliyet</th>
            <th scope=""col"">İş Durumu</th>
            <th scope=""col"">Oluşturulma Zamanı</th>
            <th scope=""col"">Son Teslim Zamanı</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
                Write(++count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
               Write(item.AppTask.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
               Write(item.AppTask.Defination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
               Write(item.AppTask.Priortry.Defination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
               Write(item.TaskStatus.Defination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
               Write(item.AppTask.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
               Write(item.AppTask.EndDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
                 if (item.TaskStatusId == (int)TaskStatusType.GorevAlındı)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237a8a7d97cf7c753300b6cfe4debfe63539563d9253", async() => {
                WriteLiteral("Görevi Tamamla");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"

                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237a8a7d97cf7c753300b6cfe4debfe63539563d12094", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\SEFA$$\Desktop\KODLAMA\TaskTrackingApp\Select.TaskTrackingApp.UI\Views\User\Components\TasksComponent\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUserTaskListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591