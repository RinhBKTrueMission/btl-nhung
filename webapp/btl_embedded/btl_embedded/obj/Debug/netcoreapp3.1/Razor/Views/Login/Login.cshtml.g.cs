#pragma checksum "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a897c3fda10c1da73831c35d2df15ee53700ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a897c3fda10c1da73831c35d2df15ee53700ba", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ab31c713cdb5bcd971ced9affa37dff94a06bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SignIn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return CallSignIn()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sign-in-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SignUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return CallSignUp()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sign-up-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Login\Login.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a897c3fda10c1da73831c35d2df15ee53700ba6209", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <script src=""https://kit.fontawesome.com/64d58efce2.js""
            crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""/Login/style.css"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"" charset=""utf-8""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.bundle.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/paho-mqtt/1.0.1/mqttws31.js"" type=""text/javascript""></script>
    <title>H??? th???ng theo d??i s???c kh???e ??i???n t???</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a897c3fda10c1da73831c35d2df15ee53700ba7955", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"forms-container\">\r\n            <div class=\"signin-signup\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a897c3fda10c1da73831c35d2df15ee53700ba8350", async() => {
                    WriteLiteral(@"
                    <h2 class=""title"">????ng nh???p</h2>
                    <div class=""input-field"">
                        <i class=""fas fa-user""></i>
                        <input type=""text"" name=""userName"" placeholder=""Username"" />
                    </div>
                    <div class=""input-field"">
                        <i class=""fas fa-lock""></i>
                        <input type=""password"" name=""passWord"" placeholder=""Password"" />
                    </div>
                    <input type=""submit"" value=""LOGIN"" class=""btn solid"" />
                    <div id=""report0"" style=""margin:10px;font-size:16px;color:red""></div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a897c3fda10c1da73831c35d2df15ee53700ba10831", async() => {
                    WriteLiteral(@"
                    <h2 class=""title"">????ng k??</h2>
                    <div class=""input-field"">
                        <i class=""fas fa-user""></i>
                        <input type=""text"" placeholder=""Username"" name=""userName"" id=""userName"" />
                    </div>
                    <div class=""input-field"">
                        <i class=""fas fa-envelope""></i>
                        <input type=""email"" placeholder=""Email"" name=""email"" id=""email"" />
                    </div>
                    <div class=""input-field"">
                        <i class=""fas fa-lock""></i>
                        <input type=""password"" placeholder=""Password"" name=""passWord"" id=""passWord"" />
                    </div>
                    <input type=""submit"" class=""btn"" value=""REGISTER"" />
                    <div id=""report"" style=""margin:10px;font-size:16px;color:red""></div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <script type=\"text/javascript\">\r\n            function CallSignUp() {\r\n                var form = $(\"#SignUp\");\r\n                $.ajax({\r\n                     type: \"POST\",\r\n                     url: \"");
#nullable restore
#line 60 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Login\Login.cshtml"
                      Write(Url.Action("SignUpFunc", "Login"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                     data: {account: form.serialize()},
                     datatype: ""json"",
                     //contentType: ""application/json; charset=utf-8"",
                     success: function (response) {
                         var data = JSON.parse(response);
                         $(""#report"").html(data);
                     }

                });
                return false;
            }

            function CallSignIn() {
                  var form = $(""#SignIn"");
                $.ajax({
                     type: ""POST"",
                     url: """);
#nullable restore
#line 77 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Login\Login.cshtml"
                      Write(Url.Action("LoginInfo", "Login"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: {
                        checkId: form.serialize(),
                    },
                     datatype: ""json"",
                     //contentType: ""application/json; charset=utf-8"",
                     success: function (response) {
                         var data1 = JSON.parse(response);
                         if (data1.length == 36) {

                             $(""#report0"").html(data);
                         } else{

                              location.replace(""");
#nullable restore
#line 90 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Login\Login.cshtml"
                                           Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")
                         }

                    },
                    error: function (response) {
                        alert(JSON.parse(response));
                    }

                });
                return false;
            }
            function LoginTo() {
                  $.ajax({
                     type: ""GET"",
                     url: """);
#nullable restore
#line 104 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Login\Login.cshtml"
                      Write(Url.Action("Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                     //contentType: ""application/json; charset=utf-8"",
                      success: function () {

                      }

                });
                return false;
            }
        </script>
        <div class=""panels-container"">
            <div class=""panel left-panel"">
                <div class=""content"">
                    <h3>H??? th???ng theo d??i s???c kh???e ??i???n t???</h3>
                    <p>
                        H??? th???ng cung c???p d???ch v??? theo d??i c??c ch??? s??? s???c kh???e c???a c??c b???nh nh??n m???c Covid-19 ??i???u tr??? t???i
                    </p>
                    <button class=""btn transparent"" id=""sign-up-btn"">
                        ????ng k??
                    </button>
                </div>
                <img src=""/Login/img/doctor.png"" class=""image""");
                BeginWriteAttribute("alt", " alt=\"", 5488, "\"", 5494, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
            <div class=""panel right-panel"">
                <div class=""content"">
                    <h3>H??? th???ng theo d??i s???c kh???e ??i???n t???</h3>
                    <p>
                        H??? th???ng cung c???p d???ch v??? theo d??i c??c ch??? s??? s???c kh???e c???a c??c b???nh nh??n m???c Covid-19 ??i???u tr??? t???i
                    </p>
                    <button class=""btn transparent"" id=""sign-in-btn"">
                        ????ng nh???p
                    </button>
                </div>
                <img src=""/Login/img/doctor.png"" class=""image""");
                BeginWriteAttribute("alt", " alt=\"", 6067, "\"", 6073, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <script src=\"/Login/app.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
