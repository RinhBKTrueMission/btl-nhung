#pragma checksum "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9699909a844869f853766f13769f369c83fe0fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\_ViewImports.cshtml"
using btl_embedded;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\_ViewImports.cshtml"
using btl_embedded.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9699909a844869f853766f13769f369c83fe0fa5", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ab31c713cdb5bcd971ced9affa37dff94a06bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<btl_embedded.Models.Patient>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("url_change"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updatePat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
  
    var mykq = 0;
    var mykq1 = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
     foreach (var item in Model.resultdates.ToArray())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
         if (item.result == false)
        {
            mykq += 1;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
     
    mykq1 = Model.resultdates.Count() - mykq;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>

    <div class=""top-details"" style=""display:flex;"">

        <div class=""nav_avt"">
            <button type=""button"" style=""border-block-color:aliceblue;"" data-toggle=""modal"" data-target=""#myModal""><i class=""fas fa-edit""></i></button>

            <!-- Modal -->
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9699909a844869f853766f13769f369c83fe0fa57861", async() => {
                WriteLiteral(@"
                <div class=""modal fade"" id=""myModal"" role=""dialog"">
                    <div class=""modal-dialog"">

                        <!-- Modal content-->
                        <div class=""modal-content"">
                            <div class=""modal-header"">

                                <h4 class=""modal-title"">Url Image</h4>
                                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                            </div>
                            <div class=""modal-body"">
                                <input type=""text"" name=""urlAvt"" class=""form-control mb-2"" />
                            </div>
                            <div class=""modal-footer"">
                                <button type=""submit"" id=""thaydoi"" class=""btn btn-default"" data-dismiss=""modal"">Ok</button>
                            </div>
                        </div>

                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <div>\r\n                <img id=\"avt_img\" style=\"width:150px;height:225px\"");
            BeginWriteAttribute("src", " src=\"", 1825, "\"", 1844, 1);
#nullable restore
#line 53 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 1831, Model.urlAvt, 1831, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div style=\"margin-left:10px;color: #6A5ACD;\">\r\n                <strong>PatientId: ");
#nullable restore
#line 56 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                              Write(Html.DisplayFor(model => model.patientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9699909a844869f853766f13769f369c83fe0fa511323", async() => {
                WriteLiteral(@"
            <div class=""nav-info"">

                <div class=""modal_body"">
                    <div class=""row1"">
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""firstName"">Tên</label>
                            <input name=""firstName"" class=""form-control mb-2"" type=""text"" id=""firstName""");
                BeginWriteAttribute("value", " value=\"", 2520, "\"", 2570, 1);
#nullable restore
#line 66 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 2528, Html.DisplayFor(model => model.firstName), 2528, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                        </div>
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""lastName"">Họ</label>
                            <input name=""lastName"" class=""form-control mb-2"" type=""text"" id=""lastName""");
                BeginWriteAttribute("value", " value=\"", 2865, "\"", 2914, 1);
#nullable restore
#line 70 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 2873, Html.DisplayFor(model => model.lastName), 2873, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                        </div>
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""CCCD"">Căn cước công dân</label>
                            <input name=""CCCD"" class=""form-control mb-2"" type=""text"" id=""CCCD""");
                BeginWriteAttribute("value", " value=\"", 3212, "\"", 3257, 1);
#nullable restore
#line 74 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 3220, Html.DisplayFor(model => model.CCCD), 3220, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                        </div>
                    </div>
                    <div class=""row1"">
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""gender"">Giới tính</label>
                            <input name=""gender"" class=""form-control mb-2"" type=""text"" id=""gender""");
                BeginWriteAttribute("value", " value=\"", 3621, "\"", 3668, 1);
#nullable restore
#line 80 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 3629, Html.DisplayFor(model => model.gender), 3629, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                        </div>
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""birth"">Ngày sinh</label>
                            <input name=""birth"" class=""form-control mb-2"" type=""date"" id=""birth""");
                BeginWriteAttribute("value", " value=\"", 3961, "\"", 4007, 1);
#nullable restore
#line 84 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 3969, Html.DisplayFor(model => model.birth), 3969, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" />
                        </div>
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""phoneNumber"">Số điện thoại</label>
                            <input name=""phoneNumber"" class=""form-control mb-2"" type=""text"" id=""phoneNumber""");
                BeginWriteAttribute("value", " value=\"", 4322, "\"", 4374, 1);
#nullable restore
#line 88 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 4330, Html.DisplayFor(model => model.phoneNumber), 4330, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row1"">
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""beginDate"">Ngày phát hiện F0</label>
                            <input name=""beginDate"" class=""form-control mb-2"" type=""date"" id=""beginDate""");
                BeginWriteAttribute("value", " value=\"", 4735, "\"", 4785, 1);
#nullable restore
#line 94 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 4743, Html.DisplayFor(model => model.beginDate), 4743, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""prosModel"">
                            <label style=""color: #6A5ACD;"" for=""address"">Địa chỉ</label>
                            <input name=""address"" class=""form-control mb-2"" type=""text"" id=""address""");
                BeginWriteAttribute("value", " value=\"", 5062, "\"", 5110, 1);
#nullable restore
#line 98 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 5070, Html.DisplayFor(model => model.address), 5070, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""prosModel"">
                            <input name=""update"" style="" background-color: #50C7C7; margin-top: 30px; width: 100px;margin-left:100px"" class=""form-control mb-2"" type=""submit"" value=""Cập nhật"" />
                        </div>
                    </div>
                </div>

            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <div style=\"color: #6A5ACD;\">\r\n        <strong>Tình trạng bệnh</strong>\r\n    </div>\r\n\r\n");
#nullable restore
#line 114 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
     if (Model.success == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""margin:0px 100px 0px 20px;display:flex"">
            <div style=""margin:0px 100px 0px 20px"">
                <input type=""radio"" id=""dt"" name=""success"" value=""false"">
                <label for=""success"">Đã khỏi</label><br>
            </div>
            <div>
                <input type=""radio"" id=""dt"" name=""success"" value=""true"" checked>
                <label for=""success"">Chưa khỏi</label><br>
            </div>
        </div>
");
#nullable restore
#line 126 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""display:flex;margin:0px 100px 0px 20px"">
            <div style=""margin:0px 100px 0px 20px"">
                <input type=""radio"" id=""dt"" name=""success"" value=""false"" checked>
                <label for=""success"">Đã khỏi</label><br>
            </div>
            <div>
                <input type=""radio"" id=""dt"" name=""success"" value=""true"">
                <label for=""success"">Chưa khỏi</label><br>
            </div>
        </div>
");
#nullable restore
#line 140 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div style=""display:flex;margin-left:10px"">
        <div class=""prosModel"" style=""margin-left:15px"">
            <label style=""color: #6A5ACD;"" for=""than_nhiet"">Thân nhiệt (độ C)</label>
            <input name=""than_nhiet"" class=""form-control mb-2"" type=""text"" id=""gender""");
            BeginWriteAttribute("value", " value=\"", 6918, "\"", 7005, 1);
#nullable restore
#line 146 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 6926, Model.resultHeath.ToArray()[Model.resultHeath.ToArray().Length-1].than_nhiet, 6926, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  readonly=""readonly"" />
        </div>
        <div class=""prosModel"" style=""margin-left:15px"">
            <label style=""color: #6A5ACD;"" for=""than_nhiet"">Nồng độ oxy trong máu (%)</label>
            <input name=""than_nhiet"" class=""form-control mb-2"" type=""text"" id=""gender""");
            BeginWriteAttribute("value", " value=\"", 7287, "\"", 7375, 1);
#nullable restore
#line 150 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 7295, Model.resultHeath.ToArray()[Model.resultHeath.ToArray().Length-1].nong_do_oxy, 7295, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  readonly=""readonly"" />
        </div>
        <div class=""prosModel"" style=""margin-left:15px"">
            <label style=""color: #6A5ACD;"" for=""than_nhiet"">Nhịp tim (nhịp/phút)</label>
            <input name=""than_nhiet"" class=""form-control mb-2"" type=""text"" id=""gender""");
            BeginWriteAttribute("value", " value=\"", 7652, "\"", 7737, 1);
#nullable restore
#line 154 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 7660, Model.resultHeath.ToArray()[Model.resultHeath.ToArray().Length-1].nhip_tim, 7660, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  readonly=\"readonly\" />\r\n        </div>\r\n    </div>\r\n    <div style=\"margin-left: 15px;\">\r\n        Thời gian lấy kết quả: ");
#nullable restore
#line 158 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                           Write(Model.resultHeath.ToArray()[Model.resultHeath.ToArray().Length-1].getSampleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <hr />
    <div class=""table_index"" style=""display:flex"">
        <div class=""table_left"">
            <div style=""margin-left: 15px; color: #6A5ACD;""><strong>Kết quả theo dõi</strong></div>
            <div style="" overflow-y: scroll; height: 200px;"">
                <table class=""table table-hover table-sm"" >
                    <thead>
                        <tr>
                            <th>Thời gian lấy kết quả</th>
                            <th>Nhịp tim (nhịp/phút)</th>
                            <th>Nồng độ Oxy trong máu (%)</th>
                            <th>Thân nhiệt (độ C)</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 175 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                           var lsthel = Model.resultHeath;
                            lsthel.Reverse();
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                         foreach (var item in lsthel.ToArray())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 181 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                               Write(item.getSampleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 182 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                               Write(item.nhip_tim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 183 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                               Write(item.nong_do_oxy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 184 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                               Write(item.than_nhiet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 186 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr><td colspan=\"5\"><strong>Tổng số: ");
#nullable restore
#line 187 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                                                        Write(Model.resultHeath.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></td></tr>
                    </tbody>
                </table>
            </div>

        </div>
        <div class=""table-right"" style=""margin-left:30px"">

            <div style=""margin-left: 15px;color: #6A5ACD;"">Kết quả xét nghiệm</div>

            <table class=""table table-hover table-sm"">
                <thead>
                    <tr>
                        <th>Thời gian lấy mẫu</th>
                        <th>Kết quả</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 205 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                     foreach (var item in Model.resultdates.ToArray())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 208 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                           Write(item.getSampleDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 209 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                           Write(item.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 211 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td colspan=\"5\"><strong>Tổng số: ");
#nullable restore
#line 212 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                                                    Write(Model.resultHeath.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td></tr>\r\n                    <tr>\r\n                        <td colspan=\"5\">\r\n                            <strong>\r\n                                Âm tính: ");
#nullable restore
#line 216 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                                    Write(mykq);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </strong>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"5\">\r\n                            <strong>\r\n                                Dương tính: ");
#nullable restore
#line 223 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                                       Write(mykq1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </strong>\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9699909a844869f853766f13769f369c83fe0fa530291", async() => {
                WriteLiteral(@"
        <div class=""report1"" style=""display:flex;margin-right:10px"">
            <div style=""display:block;"">
                <div><i class=""fas fa-book-reader""></i><strong style=""color: #6A5ACD;"">Đánh giá</strong> </div>
                <input id=""report"" name=""report""");
                BeginWriteAttribute("value", " value=\"", 11189, "\"", 11236, 1);
#nullable restore
#line 237 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
WriteAttributeValue("", 11197, Html.DisplayFor(model => model.report), 11197, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""width:300px;height:100px"" placeholder=""Enter you comment here""/>
            </div>

            <div class=""prosModel"">
                <input name=""update"" id=""reportUp"" style="" background-color: #50C7C7; margin-top: 70px; width: 100px;margin-left:100px;"" class=""form-control mb-2"" type=""submit"" value=""Cập nhật"" />
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</div>\r\n<div style=\"margin-top: 30px; background-color: #50C7C7;border-radius:5px;width:100px;height:30px\">\r\n    <i class=\"fas fa-arrow-left\"></i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9699909a844869f853766f13769f369c83fe0fa533374", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n\r\n        $(\"#thaydoi\").click(function () {\r\n\r\n            $.ajax(\"");
#nullable restore
#line 256 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
               Write(Url.Action("ChangeURL", "Main"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", {\r\n                type: \'POST\',  // http method\r\n                data: { img: JSON.stringify($(\'#url_change\').serializeArray()), id:");
#nullable restore
#line 258 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
                                                                              Write(Model.patientId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" }, // data to submit
                success: function (response) {
                    document.getElementById(""avt_img"").src = JSON.parse(response);
                    window.location.reload();
                    alert(""Thành công"");

                 },
            });

        });
        sub_mqtt_msg();
    });
      function sub_mqtt_msg() {
            // Send an MQTT message
            var mqtt_server = ""broker.hivemq.com"";
            var mqtt_port = 8000;

            client = new Paho.MQTT.Client(mqtt_server, mqtt_port, """");
            client.onMessageArrived = onMessageArrived;
            client.onMessageArrived = onMessageArrived;
            client.connect({ onSuccess: onConnect });

        }
        function onConnect() {
            client.subscribe(""demobtl1"");
        }
        function onMessageArrived(message) {
            var name = 'ketqua';
            var dataObject = {};
            dataObject[name] = message.payloadString;
");
            WriteLiteral("            $.ajax(\"");
#nullable restore
#line 289 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Home\Details.cshtml"
               Write(Url.Action("SetData", "Main"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", {\r\n                type: \'POST\',  // http method\r\n                data: dataObject, // data to submit\r\n                success: function () {\r\n                }\r\n            });\r\n");
            WriteLiteral("        }\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<btl_embedded.Models.Patient> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591