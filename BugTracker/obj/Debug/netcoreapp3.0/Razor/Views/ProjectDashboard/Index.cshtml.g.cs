#pragma checksum "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5faf1f2185184861a380b02d52d10afd5ff7bfe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5faf1f2185184861a380b02d52d10afd5ff7bfe", @"/Views/ProjectDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BugTracker.Models.ProjectDashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Chart.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/utils.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
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
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-xl-6 mb-5 mb-xl-0"">
        <div class=""card bg-neutral shadow"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h2 class=""text-purple mb-0"">Task Status</h2>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <canvas id=""chart-area1""></canvas>
            </div>
        </div>
    </div>
    <div class=""col-xl-6 mb-5 mb-xl-0"">
        <div class=""card shadow bg-neutral"">
            <div class=""card-header bg-transparent"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h2 class=""text-purple mb-0"">Bug Status</h2>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <canvas id=""chart-area2""></canvas>
            </div>
  ");
            WriteLiteral(@"      </div>
    </div>
</div>
<div class=""row mt-5"">
    <div class=""col-xl-12 mb-5 mb-xl-0"">
        <div class=""card shadow"">
            <div class=""card-header border-0"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h3 class=""text-purple mb-0"">Team Status </h3>
                    </div>
                </div>
            </div>
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
                            <th scope=""col""></th");
            WriteLiteral(@">
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td></td>
                            <td>Overdue</td>
                            <td>Today's</td>
                            <td>All Open</td>
                            <td>Overdue</td>
                            <td>Today's</td>
                            <td>All Open</td>
                        </tr>
");
#nullable restore
#line 73 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
                         foreach (var item in Model.TeamTasksStatus)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 76 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
                               Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 77 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
                               Write(item.Overdue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 78 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
                               Write(item.Today);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 79 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
                               Write(item.Open);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td></td>\r\n                                <td></td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<div class=""row mt-5"">
    <div class=""col-xl-6"">
        <div class=""card shadow"">
            <div class=""card-header border-0"">
                <div class=""row align-items-center"">
                    <div class=""col"">
                        <h3 class=""text-purple mb-0"">Overdue Work Items</h3>
                    </div>
                </div>
            </div>
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
            ");
            WriteLiteral(@"                <td>
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
                </table>
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5faf1f2185184861a380b02d52d10afd5ff7bfe10237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 130 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5faf1f2185184861a380b02d52d10afd5ff7bfe12126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 131 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n    var configTaskStatus = {\r\n        type: \'pie\',\r\n        data: {\r\n            datasets: [{\r\n                data: [\r\n                    ");
#nullable restore
#line 139 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
               Write(Model.TaskOpen);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                    ");
#nullable restore
#line 140 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
               Write(Model.TaskClosed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                ],
                backgroundColor: [
                    window.chartColors.red,
                    window.chartColors.blue
                ],
                label: 'Dataset 1'
            }],
            labels: [
                'Task Open',
                'Task Closed'
            ]
        },
        options: {
            responsive: true
        }
    };

        var configBugStatus = {
        type: 'pie',
        data: {
            datasets: [{
                data: [
                    ");
#nullable restore
#line 163 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
               Write(Model.BugOpen);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                    ");
#nullable restore
#line 164 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
               Write(Model.BugClosed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                ],
                backgroundColor: [
                    window.chartColors.green,
                    window.chartColors.yellow
                ],
                label: 'Dataset 1'
            }],
            labels: [
                'Bug Open',
                'Bug Closed'
            ]
        },
        options: {
            responsive: true
        }
    };

    window.onload = function () {
        var ctx = document.getElementById('chart-area1').getContext('2d');
        window.myPie = new Chart(ctx, configTaskStatus);

        var ctx = document.getElementById('chart-area2').getContext('2d');
        window.myPie = new Chart(ctx, configBugStatus);

    };
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BugTracker.Models.ProjectDashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
