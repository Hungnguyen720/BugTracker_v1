#pragma checksum "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c40575c17b2951d544f067edb785e52b0a1ec71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectDashboard_Index), @"mvc.1.0.view", @"/Views/ProjectDashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c40575c17b2951d544f067edb785e52b0a1ec71f", @"/Views/ProjectDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BugTracker.Models.ProjectSettingsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 10 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
    Write(item.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
}

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
        <div class=""col-xl-4"">
            <div class=""card shadow"">
                <div class=""card-header bg-transparent"">
                    <di");
            WriteLiteral(@"v class=""row align-items-center"">
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
                            <h3 class=""mb-0"">Team Status </h3>
                        </div>
                    </div>
               ");
            WriteLiteral(@" </div>
                <div class=""table-responsive"">
                    <!-- Projects table -->
                    <table class=""table align-items-center table-flush"">
                        <thead class=""thead-light"">
                            <tr>
                                <th scope=""col"">Users </th>
                                <th scope=""col""></th>
                                <th scope=""col"">Tasks</th>
                                <th scope=""col""></th>
                                <th scope=""col""></th>
                                <th scope=""col"">Bugs </th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td>Overdue</td>
                                <td>Today's</td>
                                <td>All Open</td>
                              ");
            WriteLiteral(@"  <td>Overdue</td>
                                <td>Today's</td>
                                <td>All Open</td>
                            </tr>
                            <tr>
                                <td>Hung</td>
                                <td>0</td>
                                <td>1</td>
                                <td>0</td>
                                <td>0</td>
                                <td>1</td>
                                <td>1</td>
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
                            <h3 class=""mb-0"">Overdue Work Items</h3>
                        </div>
                    </div>
          ");
            WriteLiteral(@"      </div>
                <div class=""table-responsive"">
                    <!-- Projects table -->
                    <table class=""table align-items-center table-flush"">
                        <thead class=""thead-light"">
                            <tr>
                                <th scope=""col"">Name</th>
                                <th scope=""col"">Type</th>
                                <th scope=""col"">Late by</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    bug1
                                </td>
                                <td>
                                    bug
                                </td>
                                <td>
                                    30 days
                                </td>
                            </tr>
                        </tbody>
            ");
            WriteLiteral("        </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BugTracker.Models.ProjectSettingsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591