#pragma checksum "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Main\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "673d84a2c27403cce751ba91f4cbf80040a89efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Statistics), @"mvc.1.0.view", @"/Views/Main/Statistics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"673d84a2c27403cce751ba91f4cbf80040a89efd", @"/Views/Main/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ab31c713cdb5bcd971ced9affa37dff94a06bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Main_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Main\Statistics.cshtml"
  
    ViewData["Title"] = "Thongke";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(document).ready(function () {\r\n            $.ajax(\"");
#nullable restore
#line 7 "C:\Users\rinhb\source\repos\btl_embedded\btl_embedded\Views\Main\Statistics.cshtml"
               Write(Url.Action("thongke", "Main"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", {
                type: 'GET',  // http method             
                success: function (response) {
                    var data = JSON.parse(response);
                    BieuDo(data);

             },
            });
         function BieuDo(data) {

             var ctx = document.getElementById('myChart').getContext('2d');
             var chart = new Chart(ctx, {
                 // The type of chart we want to create
                 type: 'line',
                 // The data for our dataset
                 data: {
                     labels: [data[0].time, data[1].time, data[2].time, data[3].time, data[4].time, data[5].time, data[6].time],
                     datasets: [{
                         label: '???? kh???i',
                         backgroundColor: ""#F5DEB3"",
                         borderColor: ""#F5DEB3"",
                         data: [data[0].beginCovid, data[1].beginCovid, data[2].beginCovid, data[3].beginCovid, data[4].beginCovid, data[5].beginCovid, data");
            WriteLiteral(@"[6].beginCovid],
                         fill: false,
                     },
                     {
                         label: '??ang ??i???u tr???',
                         backgroundColor: ""#C92239"",
                         borderColor: ""#C92239"",
                         data: [data[0].endCovid, data[1].endCovid, data[2].endCovid, data[3].endCovid, data[4].endCovid, data[5].endCovid, data[6].endCovid],
                         fill: false,
                     }]
                 },
                 // Configuration options go here
                 options: {}
             });


         }

    });
</script>
<div style=""margin:0px 20px"">
    <canvas id=""myChart""></canvas>
</div>");
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
