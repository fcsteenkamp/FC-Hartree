#pragma checksum "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f49172740e496b7c18e6ff498dd3238931dbaca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\FC\source\repos\Hartree\Hartree\Views\_ViewImports.cshtml"
using Hartree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FC\source\repos\Hartree\Hartree\Views\_ViewImports.cshtml"
using Hartree.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f49172740e496b7c18e6ff498dd3238931dbaca5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0a1cd742748cd4ee4652c3edd6ddf75876d769", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://cdn.jsdelivr.net/npm/chart.js@3.7.1/dist/chart.min.js""></script>

<div class=""text-center"">
    <div class=""container"">

        <div class=""alert alert-primary"" role=""alert"">
            My Holdings
        </div>
        <h2>Opening Balance: ");
#nullable restore
#line 13 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                        Write(Model.OpeningValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>Closing Balance: ");
#nullable restore
#line 14 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                        Write(Model.ClosingValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

        <div class=""row"">
            <div class=""col"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""table-dark"" colspan=""3"">Instrument Performance Data</th>
                        </tr>
                        <tr>
                            <th class=""table-dark"" scope=""col"">#</th>
                            <th class=""table-dark"" scope=""col"">Date</th>
                            <th class=""table-dark"" scope=""col"">Value</th>
                        </tr>
                    </thead>

");
#nullable restore
#line 30 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                     for (int i = 0, counter = 1; i < Model.PerfData.Count; i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                         if (Model.PerfData[i].ClassId == 1)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 36 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                               Write(Model.PerfData[i].Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                               Write(Model.PerfData[i].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"

                            counter++;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
            <div class=""col"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""table-dark"" colspan=""3"">Holdings Data</th>
                        </tr>
                        <tr>
                            <th class=""table-dark"" scope=""col"">#</th>
                            <th class=""table-dark"" scope=""col"">Date</th>
                            <th class=""table-dark"" scope=""col"">Value</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 58 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                     for (int i = 0, counter = 1; i < Model.PerfData.Count; i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                         if (Model.PerfData[i].ClassId == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 63 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                               Write(Model.PerfData[i].Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                               Write(Model.PerfData[i].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"

                            counter++;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
        <div class=""row"">
            <canvas id=""myChart"" width=""900"" height=""400""></canvas>
        </div>
    </div>
</div>

<script>
    const ctx = document.getElementById('myChart').getContext('2d');

    var dataObject = ");
#nullable restore
#line 83 "C:\Users\FC\source\repos\Hartree\Hartree\Views\Home\Index.cshtml"
                Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";


    var PerfData = dataObject.perfData.filter(function (el) {
        return el.classId == 1;
    });

    var HoldingsData = dataObject.perfData.filter(function (el) {
        return el.classId == 2;
    });

    var OpenCloseData = [];
    var OpenValue = { date: HoldingsData[0].date, value: dataObject.openingValue };
    var CloseValue = { date: HoldingsData[HoldingsData.length-1].date, value: dataObject.closingValue };
    OpenCloseData.push(OpenValue);
    OpenCloseData.push(CloseValue);


    const myChart = new Chart(ctx, {
        type: 'line',
        data: {
            datasets: [
                {
                    label: ""Instrument Performance Data"",
                    data: PerfData,
                    //backgroundColor: ""rgba(225,0,0,0.4)"",
                    borderColor: ""rgba(91,144,188,1)"", // The main line color
                    //borderCapStyle: 'square',
                },
                {
                    label: ""Holdings Data"",
           ");
            WriteLiteral(@"         data: HoldingsData,
                    borderColor: ""rgba(171,171,171,1)"", // The main line color
                    //borderCapStyle: 'square',
                },
                {
                    label: ""Opening/Closing"",
                    data: OpenCloseData,
                    showLine: false,
                    borderColor: ""red"", // The main line color
                    pointRadius: 10
                    //borderCapStyle: 'square',
                }]
        },
        options: {
            parsing: {
                xAxisKey: 'date',
                yAxisKey: 'value'
            }
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
