#pragma checksum "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
#line 1 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f319f1c7e7f8897f7fafa50fe612e3aef97501", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("foto de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EditarPerfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deslogar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sair"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
  
    ViewData["Title"] = "Instadev G6 | Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"info\">\r\n    <div class=\"info-container\">\r\n        <div class=\"info-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e6393", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 171, "~/img/perfil/", 171, 13, true);
#nullable restore
#line 8 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 184, ViewBag.UserLogado.Foto, 184, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"info-text\">\r\n                <div class=\"username\">\r\n                    <h1>");
#nullable restore
#line 11 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
                   Write(ViewBag.UserLogado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div>
                <div class=""info-numbers"">
                    <p>0 publicações</p>
                    <p>128 seguindo</p>
                    <p>214 seguidores</p>
                </div>
                <div class=""description"">
                    <p><strong>");
#nullable restore
#line 19 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
                          Write(ViewBag.UserLogado.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                    <div class=\"options\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e8921", async() => {
                WriteLiteral("Editar perfil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e10596", async() => {
                WriteLiteral("Sair");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<div class=""menu-posts"">
    <div class=""menu-profile"">
        <div class=""menu-text"">
            <img src=""./img/img-perfil/squares.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1233, "\"", 1239, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <p>Publicações</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<article id=\"posts\">\r\n    <div class=\"posts-container\">\r\n        <div class=\"posts-content\">\r\n");
#nullable restore
#line 40 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
             foreach (Publicacao p in ViewBag.PublicacoesUser)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-profile\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e13148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1558, "~/img/publicacoes/", 1558, 18, true);
#nullable restore
#line 43 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 1576, p.Imagem, 1576, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"post-info\">\r\n                        <div class=\"interaction\">\r\n                            <div class=\"user-info\">\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e4587bc67a1fa7b40dc3a15b8b06d1422754a2e14927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1859, "~/img/perfil/", 1859, 13, true);
#nullable restore
#line 48 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 1872, ViewBag.UserLogado.Foto, 1872, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"username-and-location\">\r\n                                    <h2>");
#nullable restore
#line 50 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
                                   Write(ViewBag.UserLogado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <p>Rio de Janeiro, Brazil</p>
                                </div>
                            </div>
                            <div class=""like-and-comment"">
                                <img id=""1"" src=""./img/img-perfil/like.svg""");
            BeginWriteAttribute("alt", " alt=\"", 2329, "\"", 2335, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"curtir(1)\">\r\n                                <img src=\"./img/img-perfil/comment.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2430, "\"", 2436, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <p>1954 curtidas</p>
                            <ul class=""comments"">
                                <li>
                                    <div class=""comment"">
                                        <div class=""comments-text"">
                                            <h3>fausto_silva</h3>
                                            <p>Esse cara é fera bixo</p>
                                        </div>
                                        <img id=""2"" src=""./img/img-perfil/like.svg""");
            BeginWriteAttribute("alt", " alt=\"", 3015, "\"", 3021, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""curtir(2)"">
                                    </div>
                                </li>
                                <li>
                                    <div class=""comment"">
                                        <div class=""comments-text"">
                                            <h3>yes_baby</h3>
                                            <p>thank you</p>
                                        </div>
                                        <img id=""3"" src=""./img/img-perfil/like.svg""");
            BeginWriteAttribute("alt", " alt=\"", 3550, "\"", 3556, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""curtir(3)"">
                                    </div>
                                </li>
                                <li>
                                    <div class=""comment"">
                                        <div class=""comments-text"">
                                            <h3>adriano_stark</h3>
                                            <p>Quando eu adormecer, vou sonhar com você. É sempre você.</p>
                                        </div>
                                        <img id=""4"" src=""./img/img-perfil/like.svg""");
            BeginWriteAttribute("alt", " alt=\"", 4137, "\"", 4143, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""curtir(4)"">
                                    </div>
                                </li>
                                <li>
                                    <div class=""comment"">
                                        <div class=""comments-text"">
                                            <h3>yes_baby</h3>
                                            <p>thank you</p>
                                        </div>
                                        <img id=""5"" src=""./img/img-perfil/like.svg""");
            BeginWriteAttribute("alt", " alt=\"", 4672, "\"", 4678, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""curtir(5)"">
                                    </div>
                                </li>
                            </ul>
                            <p id=""view-all-comments"">Ver todos os 585 comentários</p>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 101 "C:\Users\FIC\Desktop\Vini\Instadev-06\Views\Perfil\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</article>");
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
