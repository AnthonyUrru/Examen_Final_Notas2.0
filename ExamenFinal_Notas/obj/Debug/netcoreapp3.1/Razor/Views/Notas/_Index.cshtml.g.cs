#pragma checksum "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4aee20de8605d5208fc93e2462083a41547f654"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notas__Index), @"mvc.1.0.view", @"/Views/Notas/_Index.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\_ViewImports.cshtml"
using ExamenFinal_Notas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\_ViewImports.cshtml"
using ExamenFinal_Notas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4aee20de8605d5208fc93e2462083a41547f654", @"/Views/Notas/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"effda244dc3510cae97b663937fe63262034784d", @"/Views/_ViewImports.cshtml")]
    public class Views_Notas__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
   Layout = null;
    var nota = (List<Nota>)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
 foreach (var item in nota)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"col shadow text-black-50\"");
            BeginWriteAttribute("style", "  style=\"", 150, "\"", 159, 0);
            EndWriteAttribute();
            WriteLiteral("  >\n\n\n        <ul");
            BeginWriteAttribute("style", " style=\"", 177, "\"", 185, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"list-unstyled\">\n            <li class=\"nav-item shadow border shadow\"  >\n                <div class=\"text-center shadow border border-secondary text-warning bg-dark shadow\" >\n                    <a class=\"text-center\"");
            BeginWriteAttribute("href", " href=\"", 411, "\"", 444, 2);
            WriteAttributeValue("", 418, "/Notas/Detalle?Id=", 418, 18, true);
#nullable restore
#line 13 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
WriteAttributeValue("", 436, item.Id, 436, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <strong class=\"shadow text col-1 text-center text-warning\">");
#nullable restore
#line 14 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
                                                                              Write(item.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                    </a>
                </div>

                <div class=""container"" style=""margin-left:auto"" >
                    <span>
                        <strong class=""text-info bg-dark"" style=""margin-right:20px"">Contenido: </strong>
");
#nullable restore
#line 21 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
                         if (item.Nota_Content.Length > 50)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <parcial  >- ");
#nullable restore
#line 23 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
                        Write(item.Nota_Content.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial> ");
#nullable restore
#line 23 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
                                                                               }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <parcial>- ");
#nullable restore
#line 26 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
                      Write(item.Nota_Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>");
#nullable restore
#line 26 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </span>
                </div>
                <br />
                <div align=""center"">
                    <button id=""editModal"" style=""margin-right:20px;"" class=""btn btn-warning bg bg-transparent "" href=""#"" data-toggle=""modal"" data-target=""#edit""");
            BeginWriteAttribute("onclick", " onclick=\"", 1326, "\"", 1395, 9);
            WriteAttributeValue("", 1336, "selCuenta(\'", 1336, 11, true);
#nullable restore
#line 31 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
WriteAttributeValue("", 1347, item.Id, 1347, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1355, "\',", 1355, 2, true);
            WriteAttributeValue(" ", 1357, "\'", 1358, 2, true);
#nullable restore
#line 31 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
WriteAttributeValue("", 1359, item.Tittle, 1359, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1371, "\',", 1371, 2, true);
            WriteAttributeValue(" ", 1373, "\'", 1374, 2, true);
#nullable restore
#line 31 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
WriteAttributeValue("", 1375, item.Nota_Content, 1375, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1393, "\')", 1393, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1469, 2);
            WriteAttributeValue("", 1442, "/Notas/Eliminar?id=", 1442, 19, true);
#nullable restore
#line 32 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
WriteAttributeValue("", 1461, item.Id, 1461, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:20px;\" class=\"btn btn-success \">Eliminar</a>\n\n                </div>\n            </li>\n        </ul>\n        <br />\n    </div>\n</div>\n");
#nullable restore
#line 40 "C:\Users\Usuario\Desktop\Trabajos anthony\2020-2\Diars\Examen_Final_Notas\ExamenFinal_Notas\ExamenFinal_Notas\Views\Notas\_Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header bg-info"" >
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""EditarN"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-warning"" onclick=""submitForm()"">Guardar</button>
            </div>
        </div>
    </div>
</div>





<script>
    function selCuenta(id, titulo, cuerpo) {
        console.log(id + titulo + cuerpo);
        $('#mtxtId').val(id);
        $('#mtxtTitulo').val(titulo);
       ");
            WriteLiteral(@" $('#mtxtCuerpo').val(cuerpo);
    };

    $.ajax({
        url: '/Notas/Edit',
        type: 'get'
    }).done(function (html) {
        $('#EditarN').html(html);
    })

    function submitForm() {
        $('#Edit').submit();
    }

    function editar(event) {
        event.preventDefault();
        var dataString = new FormData($('#edit form')[0]);
        $.ajax({
            url: ""/Notas/Edit"",
            type: ""post"",
            processData: false,  // Important!
            contentType: false,
            cache: false,
            data: dataString
        }).done(function (html) {
            location.reload();
        }).fail(function (html) {
            $('#EditarN').html(html.responseText);
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
