#pragma checksum "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0fe86be407050fbbeeeb7a2c18a16a27948e84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amigo_Index), @"mvc.1.0.view", @"/Views/Amigo/Index.cshtml")]
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
#line 1 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c0fe86be407050fbbeeeb7a2c18a16a27948e84", @"/Views/Amigo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f319f1c7e7f8897f7fafa50fe612e3aef97501", @"/Views/_ViewImports.cshtml")]
    public class Views_Amigo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("foto de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/img-perfil/like.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
  
    ViewData["Title"] = @ViewBag.UsuarioClicado.Nome;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"info\">\r\n    <div class=\"info-container\">\r\n        <div class=\"info-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c0fe86be407050fbbeeeb7a2c18a16a27948e844480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 177, "~/img/perfil/", 177, 13, true);
#nullable restore
#line 8 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 190, ViewBag.UsuarioClicado.Foto, 190, 28, false);

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
#line 11 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                   Write(ViewBag.UsuarioClicado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <button class=\"btn1\">Seguir</button>\r\n                </div>\r\n                <div class=\"info-numbers\">\r\n                    <p>");
#nullable restore
#line 15 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                  Write(ViewBag.NumPosts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" publicações</p>\r\n                    <p>0 seguindo</p>\r\n                    <p>0 seguidores</p>\r\n                </div>\r\n                <div class=\"description\">\r\n                    <p><strong>");
#nullable restore
#line 20 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                          Write(ViewBag.UsuarioClicado.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<div class=\"menu-posts\">\r\n    <div class=\"menu-profile\">\r\n        <div class=\"menu-text\">\r\n            <img src=\"./img/img-perfil/squares.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1014, "\"", 1020, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <p>Publicações</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<article id=\"posts\">\r\n    <div class=\"posts-container\">\r\n        <div class=\"posts-content\">\r\n");
#nullable restore
#line 37 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
             foreach (Publicacao p in ViewBag.PostAmigo)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-profile\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c0fe86be407050fbbeeeb7a2c18a16a27948e848208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1333, "~/img/publicacoes/", 1333, 18, true);
#nullable restore
#line 40 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 1351, p.Imagem, 1351, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"post-info\">\r\n                        <div class=\"interaction\">\r\n                            <div class=\"user-info\">\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c0fe86be407050fbbeeeb7a2c18a16a27948e8410001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1634, "~/img/perfil/", 1634, 13, true);
#nullable restore
#line 45 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 1647, ViewBag.UsuarioClicado.Foto, 1647, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"username-and-location\">\r\n                                    <h2>");
#nullable restore
#line 47 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                   Write(ViewBag.UsuarioClicado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <p>São Paulo, SP</p>
                                </div>
                            </div>
                            <div class=""comment"">
                                <div class=""comments-text subtitle"">
                                    <h3>");
#nullable restore
#line 53 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                   Write(p.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 54 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                  Write(p.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"like-and-comment\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c0fe86be407050fbbeeeb7a2c18a16a27948e8412999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 58 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 2383, p.IdPublicacao, 2383, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2448, "curtir(", 2448, 7, true);
#nullable restore
#line 58 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 2455, p.IdPublicacao, 2455, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2470, ")", 2470, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2531, "\"", 2572, 1);
#nullable restore
#line 59 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
WriteAttributeValue("", 2539, ViewBag.UsuarioClicado.IdUsuario, 2539, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"IdAmigo\"></input>\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2655, "\"", 2691, 1);
#nullable restore
#line 60 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
WriteAttributeValue("", 2663, ViewBag.UsuarioClicado.Nome, 2663, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"NomeAmigo\"></input>\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2776, "\"", 2812, 1);
#nullable restore
#line 61 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
WriteAttributeValue("", 2784, ViewBag.UsuarioClicado.Foto, 2784, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"FotoAmigo\"></input>\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2897, "\"", 2937, 1);
#nullable restore
#line 62 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
WriteAttributeValue("", 2905, ViewBag.UsuarioClicado.Username, 2905, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"UsernameAmigo\"></input>\r\n                                <img src=\"./img/img-perfil/comment.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3041, "\"", 3047, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <p>");
#nullable restore
#line 65 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                          Write(p.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" curtidas</p>\r\n                            <ul class=\"comments\">\r\n");
#nullable restore
#line 67 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                 foreach (Comentario c in ViewBag.Comentarios)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                     if(p.IdPublicacao == c.IdPublicacao)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            <div class=\"comment\">\r\n                                                <div class=\"comments-text\">\r\n                                                    <h3>");
#nullable restore
#line 74 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                                   Write(c.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                    <p>");
#nullable restore
#line 75 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                                  Write(c.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                                <img");
            BeginWriteAttribute("id", " id=\"", 3865, "\"", 3885, 1);
#nullable restore
#line 77 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
WriteAttributeValue("", 3870, c.IdComentario, 3870, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" src=\"./img/img-perfil/like.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3918, "\"", 3924, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3925, "\"", 3958, 3);
            WriteAttributeValue("", 3935, "curtir(", 3935, 7, true);
#nullable restore
#line 77 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
WriteAttributeValue("", 3942, c.IdComentario, 3942, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3957, ")", 3957, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a href=\"#\"><i class=\"far fa-trash-alt\"></i></a>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 81 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
                                     
                                }                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Amigo\Index.cshtml"
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
