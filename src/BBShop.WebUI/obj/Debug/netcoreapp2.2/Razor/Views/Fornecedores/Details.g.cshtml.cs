#pragma checksum "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c3a890b1d813877ef9ca38d0dc5bfacc77d8f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores_Details), @"mvc.1.0.view", @"/Views/Fornecedores/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/Details.cshtml", typeof(AspNetCore.Views_Fornecedores_Details))]
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
#line 1 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\_ViewImports.cshtml"
using BBShop.App;

#line default
#line hidden
#line 2 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\_ViewImports.cshtml"
using BBShop.App.ViewModels;

#line default
#line hidden
#line 1 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
using BBShop.App.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c3a890b1d813877ef9ca38d0dc5bfacc77d8f1", @"/Views/Fornecedores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65bb2f5e39f12e78ff986335e1e40d46d41bf43e", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BBShop.App.ViewModels.FornecedorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetalhesEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Fornecedor";

#line default
#line hidden
            BeginContext(141, 32, true);
            WriteLiteral("\r\n<h4 style=\"padding-top:30px;\">");
            EndContext();
            BeginContext(174, 17, false);
#line 8 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(191, 89, true);
            WriteLiteral("</h4>\r\n<hr />\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(281, 40, false);
#line 14 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(321, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(383, 36, false);
#line 17 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(419, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(480, 45, false);
#line 20 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(525, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(587, 60, false);
#line 23 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(this.FormataDocumento(Model.TipoFornecedor, Model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(647, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(708, 50, false);
#line 26 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoFornecedor));

#line default
#line hidden
            EndContext();
            BeginContext(758, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(820, 73, false);
#line 29 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.Raw(this.ExibeDocumentoBadge(Model.TipoFornecedor, Model.Documento)));

#line default
#line hidden
            EndContext();
            BeginContext(893, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(954, 41, false);
#line 32 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(995, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1057, 37, false);
#line 35 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 49, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1143, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c3a890b1d813877ef9ca38d0dc5bfacc77d8f18802", async() => {
                BeginContext(1210, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "G:\Curso .Net Core\MinhaAppMvcCompleta\src\BBShop.WebUI\Views\Fornecedores\Details.cshtml"
                                                WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1220, 93, true);
            WriteLiteral("\r\n    <a class=\"btn btn-info\" href=\"javascript:window.history.back();\">Voltar</a>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1313, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3c3a890b1d813877ef9ca38d0dc5bfacc77d8f111335", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BBShop.App.ViewModels.FornecedorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591