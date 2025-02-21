#pragma checksum "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\MyAccount\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "790d8e6d64c1ffd978f2a13ca6e547ce87d56163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MyAccount_ChangePassword), @"mvc.1.0.view", @"/Areas/Admin/Views/MyAccount/ChangePassword.cshtml")]
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
#line 1 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\MyAccount\ChangePassword.cshtml"
using Cornea.Application.Services.Users.Queries.FindUsers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\MyAccount\ChangePassword.cshtml"
using Cornea.Common.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790d8e6d64c1ffd978f2a13ca6e547ce87d56163", @"/Areas/Admin/Views/MyAccount/ChangePassword.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_MyAccount_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultDto<ResultFindUsersService>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\MyAccount\ChangePassword.cshtml"
  
    ViewData["Title"] = "ChangePassword";
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
                <h4><i class=""icon-arrow-left52 position-left""></i> <span class=""text-semibold"">Datatables</span> - Select</h4>
                <a class=""heading-elements-toggle""><i class=""icon-more""></i></a>
            </div>
            <div class=""heading-elements"">
                <div class=""heading-btn-group"">
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-bars-alt text-primary""></i><span>Statistics</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calculator text-primary""></i> <span>Invoices</span></a>
                    <a href=""#"" class=""btn btn-link btn-float text-size-small has-text legitRipple""><i class=""icon-calendar5 text-primary""></i> <span>Schedule</spa");
            WriteLiteral(@"n></a>
                </div>
            </div>
        </div>
        <div class=""breadcrumb-line breadcrumb-line-component"">
            <a class=""breadcrumb-elements-toggle""><i class=""icon-menu-open""></i></a>
            <ul class=""breadcrumb"">
                <li><a href=""index.html""><i class=""icon-home2 position-left""></i> Home</a></li>
                <li><a href=""datatable_extension_select.html"">Datatables</a></li>
                <li class=""active"">Select</li>
            </ul>
            <ul class=""breadcrumb-elements"">
                <li><a href=""#"" class=""legitRipple""><i class=""icon-comment-discussion position-left""></i> Support</a></li>
                <li class=""dropdown"">
                    <a href=""#"" class=""dropdown-toggle legitRipple"" data-toggle=""dropdown"">
                        <i class=""icon-gear position-left""></i>
                        Settings
                        <span class=""caret""></span>
                    </a>
                    <ul class=""dropdown-m");
            WriteLiteral(@"enu dropdown-menu-right"">
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
        <div class=""col-md-6"">
            <div class=""col-md-8 col-md-offset-8"">
                <div class=""panel panel-flat"">
                    <div class=""panel-heading"">
                        <div class=""heading-elements"">
                            <ul class=""icons-list"">
                                <li><a data-action=""reload""></a></li>
                            <");
            WriteLiteral(@"/ul>
                        </div>
                    </div>
                    <div class=""panel-body"">
                        <div class=""row"">
                            <div class=""col-md-10 col-md-offset-1"">
                                <div class=""text-center"">
                                    <div class=""icon-object border-success text-success""><i class=""icon-reset""></i></div>
                                    <h5 class=""content-group"">Change password <small class=""display-block"">All fields are required</small></h5>
                                </div>
                                <div class=""form-group has-feedback has-feedback-left"">
");
            WriteLiteral("                                    <input type=\"text\" readonly=\"readonly\" class=\"form-control\" id=\"UserName\" name=\"UserName\"");
            BeginWriteAttribute("value", " value=\"", 4192, "\"", 4220, 1);
#nullable restore
#line 74 "F:\DuratInstruments\Cornea\Cornea.Site\Areas\Admin\Views\MyAccount\ChangePassword.cshtml"
WriteAttributeValue("", 4200, Model.Data.UserName, 4200, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""form-control-feedback"">
                                        <i class=""icon-user-check""></i>
                                    </div>
                                </div>
                                <br />
                                <div class=""form-group has-feedback has-feedback-left"">
                                    <input type=""password"" class=""form-control"" id=""Password"" placeholder="" Enter your password"">
                                    <div class=""form-control-feedback"">
                                        <i class=""icon-user-lock""></i>
                                    </div>
                                </div>
                                <br />
                                <br />
                                <br />

                                <div class=""form-group has-feedback has-feedback-left"">
                                    <input type=""password"" placeholder=""Enter new password""");
            WriteLiteral(@" class=""form-control"" id=""NewPassword"">
                                    <div class=""form-control-feedback"">
                                        <i class=""icon-user-lock""></i>
                                    </div>
                                </div>
                                <br />
                                <div class=""form-group has-feedback has-feedback-left"">
                                    <input type=""password"" placeholder=""Repeat new password"" class=""form-control"" id=""ConfirmPassword"">
                                    <div class=""form-control-feedback"">
                                        <i class=""icon-user-lock""></i>
                                    </div>
                                </div>
                                <br />
                                <br />
                            </div>
                            <button onclick=""Save()"" class=""btn bg-teal-400 btn-block"">Save </button>
                        </div>
        ");
            WriteLiteral(@"            </div>
                </div>
            </div>
        </div>

    </div>
</div>

<script>
    function Save() {
        var CurrentPassword = $(""#Password"").val();
        var NewPassword = $(""#NewPassword"").val();
        var ConfirmPassword = $(""#ConfirmPassword"").val();
        if (NewPassword != ConfirmPassword) {
            swal(
                ""Warning!"",
                ""New password and confirm password must be same."",
                ""warning""
            );
        }
        var postData = {
            'CurrentPassword': CurrentPassword,
            'NewPassword': NewPassword,
            'ConfirmPassword': ConfirmPassword,

        };
        $.ajax({
            contentType: 'application/x-www-form-urlencoded',
            dataType: 'json',
            type: ""POST"",
            url: ""ChangePassword"",
            data: postData,
            success: function (data) {
                if (data.isSuccess == true) {
                    swal({
       ");
            WriteLiteral(@"                 title: ""Updated!"",
                        text: data.message,
                        type: ""success""
                    }, function () {
                        location.reload(true);
                        document.getElementById(""Password"").value = data.data.NewPassword;
                    });
                }
                else {
                    swal({
                        title: ""Warning!"",
                        text: data.message,
                        type: ""warning""
                    }, function () { location.reload(true); });
                }
            },
            error: function (request, status, error) {
                swal({
                    title: ""Warning!"",
                    text: request.responseText,
                    type: ""warning""
                }, function () { location.reload(true); });
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultDto<ResultFindUsersService>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
