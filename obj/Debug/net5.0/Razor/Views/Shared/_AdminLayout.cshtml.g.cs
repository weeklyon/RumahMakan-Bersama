#pragma checksum "D:\Kampus\semester 3\Pemrograman2\RumahMakan-Bersama\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f83849b0aa63c81d650d56a454dc0f5a896fc37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "D:\Kampus\semester 3\Pemrograman2\RumahMakan-Bersama\Views\_ViewImports.cshtml"
using RumahMakan_Bersama;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kampus\semester 3\Pemrograman2\RumahMakan-Bersama\Views\_ViewImports.cshtml"
using RumahMakan_Bersama.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f83849b0aa63c81d650d56a454dc0f5a896fc37", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281701dbb3367cf934fcdfaab26548f4528d6101", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/library/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/library/css/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-brand d-flex align-items-center justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f83849b0aa63c81d650d56a454dc0f5a896fc376403", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 291, "\"", 301, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>SB Admin 2 - Dashboard</title>\r\n\r\n    <!-- Custom fonts for this template-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f83849b0aa63c81d650d56a454dc0f5a896fc377340", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link\r\n        href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\"\r\n        rel=\"stylesheet\">\r\n\r\n    <!-- Custom styles for this template-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f83849b0aa63c81d650d56a454dc0f5a896fc378831", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f83849b0aa63c81d650d56a454dc0f5a896fc3710722", async() => {
                WriteLiteral("\r\n\r\n<!-- Page Wrapper -->\r\n<div id=\"wrapper\">\r\n\r\n    <!-- Sidebar -->\r\n    <ul class=\"navbar-nav bg-gradient-primary sidebar sidebar-dark accordion\" id=\"accordionSidebar\">\r\n\r\n        <!-- Sidebar - Brand -->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f83849b0aa63c81d650d56a454dc0f5a896fc3711218", async() => {
                    WriteLiteral("\r\n            <div class=\"sidebar-brand-icon rotate-n-15\">\r\n                <i class=\"fas fa-laugh-wink\"></i>\r\n            </div>\r\n            <div class=\"sidebar-brand-text mx-3\">SB Admin <sup>2</sup></div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <!-- Divider -->
        <hr class=""sidebar-divider my-0"">

        <!-- Nav Item - Dashboard -->
        <li class=""nav-item active"">
            <a class=""nav-link"" href=""index.html"">
                <i class=""fas fa-fw fa-tachometer-alt""></i>
                <span>Dashboard</span></a>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider"">

        <!-- Heading -->
        <div class=""sidebar-heading"">
            Interface
        </div>

        <!-- Nav Item - Pages Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo""
                aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Components</span>
            </a>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inn");
                WriteLiteral(@"er rounded"">
                    <h6 class=""collapse-header"">Custom Components:</h6>
                    <a class=""collapse-item"" href=""buttons.html"">Buttons</a>
                    <a class=""collapse-item"" href=""cards.html"">Cards</a>
                </div>
            </div>
        </li>

        <!-- Nav Item - Utilities Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities""
                aria-expanded=""true"" aria-controls=""collapseUtilities"">
                <i class=""fas fa-fw fa-wrench""></i>
                <span>Utilities</span>
            </a>
            <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities""
                data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Custom Utilities:</h6>
                    <a class=""collapse-item"" href=""utilities-colo");
                WriteLiteral(@"r.html"">Colors</a>
                    <a class=""collapse-item"" href=""utilities-border.html"">Borders</a>
                    <a class=""collapse-item"" href=""utilities-animation.html"">Animations</a>
                    <a class=""collapse-item"" href=""utilities-other.html"">Other</a>
                </div>
            </div>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider"">

        <!-- Heading -->
        <div class=""sidebar-heading"">
            Addons
        </div>

        <!-- Nav Item - Pages Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages""
                aria-expanded=""true"" aria-controls=""collapsePages"">
                <i class=""fas fa-fw fa-folder""></i>
                <span>Pages</span>
            </a>
            <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                <div class=""bg-w");
                WriteLiteral(@"hite py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Login Screens:</h6>
                    <a class=""collapse-item"" href=""login.html"">Login</a>
                    <a class=""collapse-item"" href=""register.html"">Register</a>
                    <a class=""collapse-item"" href=""forgot-password.html"">Forgot Password</a>
                    <div class=""collapse-divider""></div>
                    <h6 class=""collapse-header"">Other Pages:</h6>
                    <a class=""collapse-item"" href=""404.html"">404 Page</a>
                    <a class=""collapse-item"" href=""blank.html"">Blank Page</a>
                </div>
            </div>
        </li>

        <!-- Nav Item - Charts -->
        <li class=""nav-item"">
            <a class=""nav-link"" href=""charts.html"">
                <i class=""fas fa-fw fa-chart-area""></i>
                <span>Charts</span></a>
        </li>

        <!-- Nav Item - Tables -->
        <li class=""nav-item"">
            <a class=""nav-lin");
                WriteLiteral(@"k"" href=""tables.html"">
                <i class=""fas fa-fw fa-table""></i>
                <span>Tables</span></a>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider d-none d-md-block"">

        <!-- Sidebar Toggler (Sidebar) -->
        <div class=""text-center d-none d-md-inline"">
            <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
        </div>

        <!-- Sidebar Message -->
        <div class=""sidebar-card"">
            <img class=""sidebar-card-illustration mb-2"" src=""img/undraw_rocket.svg""");
                BeginWriteAttribute("alt", " alt=\"", 6030, "\"", 6036, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            <p class=""text-center mb-2""><strong>SB Admin Pro</strong> is packed with premium features, components, and
                more!</p>
            <a class=""btn btn-success btn-sm"" href=""https://startbootstrap.com/theme/sb-admin-pro"">Upgrade to Pro!</a>
        </div>

    </ul>
</div>

        <!-- End of Sidebar -->

        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">
            <div class=""container"">
                <main role=""main"" class=""pb-3"">
                    ");
#nullable restore
#line 162 "D:\Kampus\semester 3\Pemrograman2\RumahMakan-Bersama\Views\Shared\_AdminLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </main>
            </div>
            <!-- Footer -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Your Website 2020</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->
        </div>
        <!-- End of Content Wrapper -->
    </div>
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>
    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
        aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <button cl");
                WriteLiteral(@"ass=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin-2.min.js""></script>

    <!-- Page level plugins -->
    <script src=""ve");
                WriteLiteral("ndor/chart.js/Chart.min.js\"></script>\r\n\r\n    <!-- Page level custom scripts -->\r\n    <script src=\"js/demo/chart-area-demo.js\"></script>\r\n    <script src=\"js/demo/chart-pie-demo.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
