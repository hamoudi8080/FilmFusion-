#pragma checksum "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454b1c91533fd854ba9bd5aba95b50ae3fcb3a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\_ViewImports.cshtml"
using ProjectDotNetCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\_ViewImports.cshtml"
using ProjectDotNetCRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\_ViewImports.cshtml"
using ProjectDotNetCRUD.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454b1c91533fd854ba9bd5aba95b50ae3fcb3a59", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ff735c06a88f0b5d1d2244bb16b6f054b2f3ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
  
	ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\r\n\t<i class=\"bi bi-film\"></i>\r\n\tMovies\r\n</h2>\r\n\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454b1c91533fd854ba9bd5aba95b50ae3fcb3a595608", async() => {
                WriteLiteral("\r\n\t<i class=\"bi bi-plus\"></i> Add Movie\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"mt-4\">\r\n\r\n");
#nullable restore
#line 21 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
     if (Model == null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"alert alert-warning\" role=\"alert\">\r\n\t\t\t<i class=\"bi bi-exclamation-octagon\"></i>\r\n\t\t\tNo Movies found!\r\n\t\t</div>\r\n");
#nullable restore
#line 27 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"row\">\r\n");
#nullable restore
#line 31 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">\r\n                    <div class=\"card mb-3\">\r\n                        <div class=\"row no-gutters\">\r\n                            <div class=\"col-md-2 poster\"");
            BeginWriteAttribute("style", " style=\"", 984, "\"", 1075, 4);
            WriteAttributeValue("", 992, "background-image:", 992, 17, true);
            WriteAttributeValue(" ", 1009, "url(data:image\\/*;base64,", 1010, 26, true);
#nullable restore
#line 36 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1035, Convert.ToBase64String(movie.Poster), 1035, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1074, ")", 1074, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <div class=""col-md-10"">
                                <div class=""card-body d-flex flex-column justify-content-between h-100"">
                                    <div>
                                        <h5 class=""card-title"">");
#nullable restore
#line 40 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                          Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 40 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                                        Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                                        <p class=\"card-text text-justify\">");
#nullable restore
#line 41 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                                      Write(movie.Storeline.Length > 500 ? $"{movie.Storeline.Substring(0, 500)}..." : movie.Storeline);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""d-flex justify-content-between"">
                                        <p class=""card-text mb-0 mt-2"">
                                            <i class=""bi bi-star-fill text-warning""></i>
                                            <small class=""text-muted"">");
#nullable restore
#line 46 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                                 Write(movie.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        </p>\r\n                                        <div>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454b1c91533fd854ba9bd5aba95b50ae3fcb3a5910740", async() => {
                WriteLiteral("\r\n                                                <i class=\"bi bi-camera-reels\"></i>\r\n                                                Details\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                                          WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454b1c91533fd854ba9bd5aba95b50ae3fcb3a5913245", async() => {
                WriteLiteral("\r\n                                                <i class=\"bi bi-pencil\"></i>\r\n                                                Edit\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                                   WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 57 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
                                                                                                        Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <i class=""bi bi-trash""></i>
                                                Delete
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 68 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 70 "C:\DotNetCRUDProject\ProjectDotNetCRUD\ProjectDotNetCRUD\Views\Movies\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
