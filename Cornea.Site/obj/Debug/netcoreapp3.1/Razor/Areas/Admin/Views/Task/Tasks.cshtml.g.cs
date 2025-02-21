#pragma checksum "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d953c37898a383e0d04f088835eaec2621aea8c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Task_Tasks), @"mvc.1.0.view", @"/Areas/Admin/Views/Task/Tasks.cshtml")]
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
#line 1 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
using Cornea.Application.Services.Task.Queries.GetTasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
using Cornea.Application.Services.Project.Queries.GetProjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
using Cornea.Application.Services.Users.Queries.GetUsers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d953c37898a383e0d04f088835eaec2621aea8c0", @"/Areas/Admin/Views/Task/Tasks.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Task_Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<ResultGetTasksDto, ResultGetProjecsDto, ResultGetUsersDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
  
    ViewData["Title"] = "Tasks";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
<div class=""content-wrapper"">
    <!-- Page header -->
    <div class=""page-header"">
        <div class=""page-header-content"">
            <div class=""page-title"">
                <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Tasks</span> - Tasks List</h4>
                <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
            </div>
            <div class=""heading-elements"">
                <div class=""heading-btn-group"">
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calendar5 text-primary""></i> <span>Schedule</span");
            WriteLiteral(@"></a>
                </div>
            </div>
        </div>
        <div class=""breadcrumb-line breadcrumb-line-component"">
            <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
            <ul class=""breadcrumb"">
                <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Home</a></li>
                <li><a href=""datatable_extension_select.html"">Tasks</a></li>
                <li class=""active"">Tasks List</li>
            </ul>
            <ul class=""breadcrumb-elements"">
                <li><a href=""#"" class=""legitRipple""><i class=""icon-comment-discussion position-left""></i> Support</a></li>
                <li class=""dropdown"">
                    <a href=""#"" class=""dropdown-toggle legitRipple"" data-toggle=""dropdown"">
                        <i class=""icon-gear position-left""></i>
                        Settings
                        <span class=""caret""></span>
                    </a>
                    <ul class=""dropdown-men");
            WriteLiteral(@"u dropdown-menu-right"">
                        <li><a href=""#""><i class=""icon-user-lock""></i> Account security</a></li>
                        <li><a href=""#""><i class=""icon-statistics""></i> Analytics</a></li>
                        <li><a href=""#""><i class=""icon-accessibility""></i> Accessibility</a></li>
                        <li class=""divider""></li>
                        <li><a href=""#""><i class=""icon-gear""></i> All settings</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
    <!-- /page header -->
    <!-- Content area -->
    <div class=""content"">
        <!-- Task manager table -->
        <div class=""panel panel-white"">
            <div class=""panel-heading"">
                <h6 class=""panel-title"">Task manager</h6>
                <div class=""heading-elements"">
                    <ul class=""icons-list"">
                        <li><a data-action=""reload""></a></li>
                    </ul>
                </div>
       ");
            WriteLiteral(@"     </div>

            <table class=""table tasks-list table-lg"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>ProjectName</th>
                        <th>Task Description</th>
                        <th>Priority</th>
                        <th>Status</th>
                        <th>Timeline</th>
                        <th>Assigned To</th>
                        <th class=""text-center"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 81 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                      
                        int counter = 1;
                        foreach (var data in Model.Item1.taskslist)
                        {
                            long? percent = 0;
                            int passedTime = (DateTime.Now - data.StartTime).Days;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>#");
#nullable restore
#line 88 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                            Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 89 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                           Write(data.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <div class=\"text-semibold\"><a data-id=");
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                                                 Write(data.Id);

#line default
#line hidden
#nullable disable
            BeginWriteAttribute("href", " href=\"", 4618, "\"", 4654, 2);
            WriteAttributeValue("", 4625, "DetailTask?searchKey=", 4625, 21, true);
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
WriteAttributeValue("", 4646, data.Id, 4646, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                                                                                               Write(data.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                                <div class=\"text-muted\">Grumbled ripely eternal sniffed the when hello less much..</div>\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 94 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                           Write(data.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 95 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                           Write(data.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <div class=\"progress progress-rounded\" id=\"h-center-basic\">\r\n");
#nullable restore
#line 98 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                     if (passedTime <= 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"progressbar-back-text\"> 0%</span>\r\n");
#nullable restore
#line 101 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                    }
                                                    else if (passedTime < data.Timeline)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"progressbar-back-text\">");
#nullable restore
#line 104 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                                                        Write((passedTime*100)/data.Timeline);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 105 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                        percent = (passedTime * 100) / data.Timeline;
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"progressbar-back-text\">100%</span>\r\n");
#nullable restore
#line 110 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                        percent = 100;
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"progress-bar progress-bar-info\"");
            BeginWriteAttribute("style", " style=\"", 6333, "\"", 6356, 3);
            WriteAttributeValue("", 6341, "width:", 6341, 6, true);
#nullable restore
#line 112 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
WriteAttributeValue("", 6347, percent, 6347, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6355, "%", 6355, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                                </div>\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 115 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                           Write(data.Owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                            <td class=\"text-center\">\r\n                                                <ul class=\"icons-list\">\r\n                                                    <li class=\"text-primary-600\"><a");
            BeginWriteAttribute("href", " href=\"", 7029, "\"", 7063, 2);
            WriteAttributeValue("", 7036, "EditTask?searchKey=", 7036, 19, true);
#nullable restore
#line 121 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
WriteAttributeValue("", 7055, data.Id, 7055, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-pencil7\"></i></a></li>\r\n                                                    <li class=\"text-danger-600\"><a data-id=");
#nullable restore
#line 122 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                                                                                      Write(data.Id);

#line default
#line hidden
#nullable disable
            BeginWriteAttribute("onclick", " onclick=\"", 7203, "\"", 7241, 3);
            WriteAttributeValue("", 7213, "deleteTask(String(", 7213, 18, true);
#nullable restore
#line 122 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
WriteAttributeValue("", 7231, data.Id, 7231, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7239, "))", 7239, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"><i class=\"icon-trash\"></i></a></li>\r\n                                                </ul>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 126 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\Task\Tasks.cshtml"
                            counter++;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- /Task manager table -->

    </div>
    <!-- /content area -->
</div>
<!-- /main content -->

<script>
    function deleteTask(searchKey) {
        // Advanced initialization
        swal({
            title: ""Are you sure?"",
            text: ""You will not be able to recover this imaginary file!"",
            type: ""warning"",
            showCancelButton: true,
            confirmButtonColor: ""#DD6B55"",
            confirmButtonText: ""Yes, delete it!"",
            closeOnConfirm: false,
            html: false
        }, function () {
            var postData = {
                'searchKey': searchKey,
            };
            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: ""POST"",
                url: ""deleteTask"",
                data: postData,
                success: function (data) {
                    if (data.i");
            WriteLiteral(@"sSuccess == true) {
                        swal({
                            title: ""Deleted!"",
                            text: ""Your imaginary file has been deleted."",
                            type: ""success""
                        }, function () { window.location.reload(); });

                    }
                }

            });

        });

    }
</script>

<script>
    function findTask(searchKey) {
        var postData = {
            'searchKey': searchKey,
        };
        $.ajax({
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            type: ""POST"",
            url: ""findTask"",
            data: postData,
            success: function (data) {
                if (data.isSuccess == true) {
                    document.getElementById(""ProjectName"").value = data.data.projectName;
                    document.getElementById(""Owner"").value = data.data.projectName;
                    $(""#TaskName"").text(data.dat");
            WriteLiteral(@"a.taskName);
                    document.getElementById(""Status"").value = data.data.taskName;
                    document.getElementById(""Priority"").value = data.data.taskName;
                    //document.getElementById(""Filedir"").value = data.data.filedir;
                    $(""#modal_form_horizontal"").modal('show');
                }
                else {

                    swal.fire(
                        'هشدار!',
                        data.message,
                        'warning'
                    );
                }
            },

            error: function (request, status, error) {
                swal.fire(
                    'هشدار!',
                    request.responseText,
                    'warning'
                );
            }
        });
    }
</script>

<script type=""text/javascript"">
    function performClick(elemId) {
        var elem = document.getElementById(elemId);
        if (elem && document.createEvent) {
            var evt =");
            WriteLiteral(" document.createEvent(\"MouseEvents\");\r\n            evt.initEvent(\"click\", true, false);\r\n            elem.dispatchEvent(evt);\r\n        }\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<ResultGetTasksDto, ResultGetProjecsDto, ResultGetUsersDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
