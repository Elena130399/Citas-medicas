#pragma checksum "C:\CitasMedicas\Citas-medicas\CitasMedicas.App\CitasMedicas.App.Web\Pages\Pacientes\PacienteDetalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b77688acf3c141646957bdb3e2602fa716f0c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CitasMedicas.App.Web.Pages.Pacientes.Pages_Pacientes_PacienteDetalles), @"mvc.1.0.razor-page", @"/Pages/Pacientes/PacienteDetalles.cshtml")]
namespace CitasMedicas.App.Web.Pages.Pacientes
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
#line 1 "C:\CitasMedicas\Citas-medicas\CitasMedicas.App\CitasMedicas.App.Web\Pages\_ViewImports.cshtml"
using CitasMedicas.App.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b77688acf3c141646957bdb3e2602fa716f0c4", @"/Pages/Pacientes/PacienteDetalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda043b46aa6e49b3f367dedaa636ca322ff5e99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_PacienteDetalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<h1>Detalle de Pacientes</h1>\r\n\r\n<table class=\"table table-striped\">\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <td>");
#nullable restore
#line 12 "C:\CitasMedicas\Citas-medicas\CitasMedicas.App\CitasMedicas.App.Web\Pages\Pacientes\PacienteDetalles.cshtml"
           Write(Model.paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"col\">Apellidos</th>\r\n            <td>");
#nullable restore
#line 16 "C:\CitasMedicas\Citas-medicas\CitasMedicas.App\CitasMedicas.App.Web\Pages\Pacientes\PacienteDetalles.cshtml"
           Write(Model.paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n        </tr>\r\n        <tr>\r\n            <th scope=\"col\">Genero</th>\r\n            <td>");
#nullable restore
#line 20 "C:\CitasMedicas\Citas-medicas\CitasMedicas.App\CitasMedicas.App.Web\Pages\Pacientes\PacienteDetalles.cshtml"
           Write(Model.paciente.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"col\">Fecha de nacimiento</th>\r\n            <td>");
#nullable restore
#line 24 "C:\CitasMedicas\Citas-medicas\CitasMedicas.App\CitasMedicas.App.Web\Pages\Pacientes\PacienteDetalles.cshtml"
           Write(Model.paciente.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b77688acf3c141646957bdb3e2602fa716f0c45291", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CitasMedicas.App.Web.Pages.Pacientes.PacienteDetallesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CitasMedicas.App.Web.Pages.Pacientes.PacienteDetallesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CitasMedicas.App.Web.Pages.Pacientes.PacienteDetallesModel>)PageContext?.ViewData;
        public CitasMedicas.App.Web.Pages.Pacientes.PacienteDetallesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
