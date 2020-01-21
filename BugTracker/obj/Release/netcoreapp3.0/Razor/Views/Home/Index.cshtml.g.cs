#pragma checksum "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa639d6d8faad8d2d365b6de64693f6c9065b02"
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
#line 1 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa639d6d8faad8d2d365b6de64693f6c9065b02", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-8 mb-5 mb-xl-0"">
        <div class=""card bg-gradient-default shadow"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h6 class=""text-uppercase text-light ls-1 mb-1"">Overview</h6>
                        <h2 class=""text-white mb-0"">Sales value</h2>
                    </div>
                    <div class=""col"">
                        <ul class=""nav nav-pills justify-content-end"">
                            <li class=""nav-item mr-2 mr-md-0"" data-toggle=""chart"" data-target=""#chart-sales"" data-update='{""data"":{""datasets"":[{""data"":[0, 20, 10, 30, 15, 40, 20, 60, 60]}]}}' data-prefix=""$"" data-suffix=""k"">
                                <a href=""#"" class=""nav-link py-2 px-3 active"" data-toggle=""tab"">
                                    <span class=""d-none d-md-block"">Month</span>
                                    <span class=""d-md-none");
            WriteLiteral(@""">M</span>
                                </a>
                            </li>
                            <li class=""nav-item"" data-toggle=""chart"" data-target=""#chart-sales"" data-update='{""data"":{""datasets"":[{""data"":[0, 20, 5, 25, 10, 30, 15, 40, 40]}]}}' data-prefix=""$"" data-suffix=""k"">
                                <a href=""#"" class=""nav-link py-2 px-3"" data-toggle=""tab"">
                                    <span class=""d-none d-md-block"">Week</span>
                                    <span class=""d-md-none"">W</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Chart -->
                <div class=""chart"">
                    <!-- Chart wrapper -->
                    <canvas id=""chart-sales"" class=""chart-canvas""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div c");
            WriteLiteral(@"lass=""col-xl-4"">
        <div class=""card shadow"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h6 class=""text-uppercase text-muted ls-1 mb-1"">Performance</h6>
                        <h2 class=""mb-0"">Total orders</h2>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <!-- Chart -->
                <div class=""chart"">
                    <canvas id=""chart-orders"" class=""chart-canvas""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row mt-5"">
    <div class=""col-xl-8 mb-5 mb-xl-0"">
        <div class=""card shadow"">
            <div class=""card-header border-0"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h3 class=""mb-0"">Page visits</h3>
                    </div>
          ");
            WriteLiteral(@"          <div class=""col text-right"">
                        <a href=""#!"" class=""btn btn-sm btn-primary"">See all</a>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"">
                <!-- Projects table -->
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Page name</th>
                            <th scope=""col"">Visitors</th>
                            <th scope=""col"">Unique users</th>
                            <th scope=""col"">Bounce rate</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">
                                /argon/
                            </th>
                            <td>
                                4,569
                            </td>
   ");
            WriteLiteral(@"                         <td>
                                340
                            </td>
                            <td>
                                <i class=""fas fa-arrow-up text-success mr-3""></i> 46,53%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                /argon/index.html
                            </th>
                            <td>
                                3,985
                            </td>
                            <td>
                                319
                            </td>
                            <td>
                                <i class=""fas fa-arrow-down text-warning mr-3""></i> 46,53%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                /argon/charts.html
                            </th>
");
            WriteLiteral(@"                            <td>
                                3,513
                            </td>
                            <td>
                                294
                            </td>
                            <td>
                                <i class=""fas fa-arrow-down text-warning mr-3""></i> 36,49%
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                /argon/tables.html
                            </th>
                            <td>
                                2,050
                            </td>
                            <td>
                                147
                            </td>
                            <td>
                                <i class=""fas fa-arrow-up text-success mr-3""></i> 50,87%
                            </td>
                        </tr>
                        <tr>
                     ");
            WriteLiteral(@"       <th scope=""row"">
                                /argon/profile.html
                            </th>
                            <td>
                                1,795
                            </td>
                            <td>
                                190
                            </td>
                            <td>
                                <i class=""fas fa-arrow-down text-danger mr-3""></i> 46,53%
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class=""col-xl-4"">
        <div class=""card shadow"">
            <div class=""card-header border-0"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h3 class=""mb-0"">Social traffic</h3>
                    </div>
                    <div class=""col text-right"">
                        <a href=""#!"" class=""btn btn-sm btn");
            WriteLiteral(@"-primary"">See all</a>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"">
                <!-- Projects table -->
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Referral</th>
                            <th scope=""col"">Visitors</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">
                                Facebook
                            </th>
                            <td>
                                1,480
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">60%</span>
 ");
            WriteLiteral(@"                                   <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-danger"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                Facebook
                            </th>
                            <td>
                                5,480
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">70%</span>
                                    <div>
                                        <div clas");
            WriteLiteral(@"s=""progress"">
                                            <div class=""progress-bar bg-gradient-success"" role=""progressbar"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 70%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                Google
                            </th>
                            <td>
                                4,807
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">80%</span>
                                    <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradi");
            WriteLiteral(@"ent-primary"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                Instagram
                            </th>
                            <td>
                                3,678
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">75%</span>
                                    <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-info"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"" sty");
            WriteLiteral(@"le=""width: 75%;""></div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">
                                twitter
                            </th>
                            <td>
                                2,645
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""mr-2"">30%</span>
                                    <div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-warning"" role=""progressbar"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 30%;""></div>
                                        </div>
                  ");
            WriteLiteral("                  </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
