#pragma checksum "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81b51ba760d5328c018e5aa2fb3f298d181b92fe"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b51ba760d5328c018e5aa2fb3f298d181b92fe", @"/Views/ProjectDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BugTracker.Models.ProjectSettingsModel>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
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


<div id=""canvas-holder"" style=""width:40%"">
    <canvas id=""chart-area""></canvas>
</div>

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
                <d");
            WriteLiteral(@"iv class=""row align-items-center"">
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
            </div>
            <div class=""table-responsive"">
                <!-- Projects table -->
     ");
            WriteLiteral(@"           <table class=""table align-items-center table-flush"">
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
                            <td>Overdue</td>
                            <td>Today's</td>
                            <td>All Open</td>
                        </tr>
                        <tr>
         ");
            WriteLiteral(@"                   <td>Hung</td>
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
            </div>
            <div class=""table-responsive"">
                <!-- Projects table -->
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""");
            WriteLiteral(@"col"">Name</th>
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
                </table>
            </div>
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b51ba760d5328c018e5aa2fb3f298d181b92fe9875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 144 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b51ba760d5328c018e5aa2fb3f298d181b92fe11763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 145 "C:\Users\Hung\source\repos\BugTracker\BugTracker\Views\ProjectDashboard\Index.cshtml"
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
            WriteLiteral(@"

<script>
    var randomScalingFactor = function () {
        return Math.round(Math.random() * 100);
    };

    var config = {
        type: 'pie',
        data: {
            datasets: [{
                data: [
                    randomScalingFactor(),
                    randomScalingFactor(),
                    randomScalingFactor(),
                    randomScalingFactor(),
                    randomScalingFactor(),
                ],
                backgroundColor: [
                    window.chartColors.red,
                    window.chartColors.orange,
                    window.chartColors.yellow,
                    window.chartColors.green,
                    window.chartColors.blue,
                ],
                label: 'Dataset 1'
            }],
            labels: [
                'Red',
                'Orange',
                'Yellow',
                'Green',
                'Blue'
            ]
        },
        options: {
            res");
            WriteLiteral("ponsive: true\r\n        }\r\n    };\r\n\r\n    window.onload = function () {\r\n        var ctx = document.getElementById(\'chart-area\').getContext(\'2d\');\r\n        window.myPie = new Chart(ctx, config);\r\n    };\r\n    </Script>\r\n");
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
