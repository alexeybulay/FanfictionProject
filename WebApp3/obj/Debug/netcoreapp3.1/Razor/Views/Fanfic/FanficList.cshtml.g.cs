#pragma checksum "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1534608966cf1ec0fca4a0592ec9568c9cd9c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fanfic_FanficList), @"mvc.1.0.view", @"/Views/Fanfic/FanficList.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\_ViewImports.cshtml"
using WebApp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\_ViewImports.cshtml"
using WebApp3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1534608966cf1ec0fca4a0592ec9568c9cd9c7", @"/Views/Fanfic/FanficList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0bcd4db72c0ab92d94eff75657b307fd4bd638", @"/Views/_ViewImports.cshtml")]
    public class Views_Fanfic_FanficList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp3.ViewModels.FanficTagViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fanfic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FanficList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
  
    ViewData["Title"] = "FanficList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1>Работы автора</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1534608966cf1ec0fca4a0592ec9568c9cd9c75417", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input class=""form-control"" name=""SearchUser"">
                <div class=""input-group-append"">
                    <button class=""btn btn-primary"" type=""submit"">Search</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <article class=\"all-browsers\">\r\n");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
             foreach (var fanfic in Model.FanficsTags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <article class=""browser"">
                    <div class=""content"">
                        <div class=""user-like-comment"">
                            <div class=""userpublish"">
                                <i class=""fa fa-user"" aria-hidden=""true"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1534608966cf1ec0fca4a0592ec9568c9cd9c78173", async() => {
                WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
                                                                                                                         Write(fanfic.Fanfic.ApplicationUser.Email);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</i>
                            </div>
                            <div class=""rating"">
                                <i class=""fa fa-star"" aria-hidden=""true""><b style=""color:gold""> 10 </b></i>
                            </div>
                            <div class=""likes"">
                                <i class=""fa fa-thumbs-up"" aria-hidden=""true""><b style=""color:yellowgreen""> 25 </b></i>
                            </div>
                            <div class=""comment"">
                                <i class=""fa fa-comments"" aria-hidden=""true""><b> 28 </b></i>
                            </div>
                        </div>
                        <div class=""namefanfic"">
                            <i class=""fa fa-book"" aria-hidden=""true"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1534608966cf1ec0fca4a0592ec9568c9cd9c710687", async() => {
                WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
                                                                                                                     Write(fanfic.Fanfic.NameFanfic);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</i>\r\n                            </div>\r\n                        <div class=\"desciption\">\r\n                            <i class=\"fa fa-pencil\" aria-hidden=\"true\"><b> Описание: </b> ");
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
                                                                                     Write(fanfic.Fanfic.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                        </div>\r\n                        <div class=\"tags\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1534608966cf1ec0fca4a0592ec9568c9cd9c713038", async() => {
                WriteLiteral("\r\n                            <i class=\"fa fa-tags\" aria-hidden=\"true\"><b> Метки: </b>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1534608966cf1ec0fca4a0592ec9568c9cd9c713385", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
                                                                                                                                                                Write(string.Join(", ", fanfic.Fanfic.FanficsTags.Select(ps => ps.Tag.TagTitle)));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
                                                                                                                                         WriteLiteral(fanfic.TagId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</i>\r\n                       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        <div class=\"timepublish\">\r\n                            <i class=\"fa fa-calendar\" aria-hidden=\"true\"><b> Дата публикации: </b> ");
#nullable restore
#line 52 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
                                                                                              Write(fanfic.Fanfic.DateTimePublish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                        </div>\r\n                    </div>\r\n                </article>\r\n");
#nullable restore
#line 56 "C:\Users\Administrator\source\repos\WebApp3 — копия (2) — копия — копия\WebApp3\Views\Fanfic\FanficList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </article>
    </div>
</div>

<style>
    * {
        color: #d8d4ca;
    }
    div .user-like-comment{
        display: inline-flex;
    }
    div .content{
        margin: 10px;
    }
    div .userpublish, .namefanfic, .name-user, .desciption, .rating, .likes, .comment, .tags, .timepublish{
        font-size: 21px;
    }
    div .desciption{
        display: block;
    }
    div .rating i{
        color: gold;
        padding-left: 15px;
    }
    div .likes i{
        color: yellowgreen;
        padding-left: 10px;
    }
    div .comment i {
        padding-left: 10px;
    }
          
    .all-browsers {

        margin: 0;
        padding: 5px;
        background-color: transparent;
    }

    .all-browsers > h1, .browser {
        margin: 10px;
        padding: 5px;
    }

    .browser {
        background: transparent;
        color: white;
        border: 1px solid #d8d4ca;
        border-left: 12px solid #f8084c;
        font-size: 18px;
   ");
            WriteLiteral(@" }
    article a, a:hover {
        color: #d8d4ca;
        text-decoration: underline;
    }
    

    .browser > h2, p {
        margin: 4px;
        font-size: 90%;

    }
    .word {
                
    }
    a.tag{
        background-color: lightblue;
        padding: 5px 7px;
    }
    a.tag:hover{
        background-color: rgb(141, 182, 195);
        text-decoration: none;
    }
</style>

<script src=""https://use.fontawesome.com/e41c36a5bb.js""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp3.ViewModels.FanficTagViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
