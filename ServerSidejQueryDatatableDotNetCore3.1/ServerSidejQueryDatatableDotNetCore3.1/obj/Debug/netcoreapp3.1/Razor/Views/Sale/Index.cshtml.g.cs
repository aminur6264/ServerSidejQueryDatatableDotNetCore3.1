#pragma checksum "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b058af3fbf3dc0a216da60938f3fb21b837bbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sale_Index), @"mvc.1.0.view", @"/Views/Sale/Index.cshtml")]
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
#line 1 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\_ViewImports.cshtml"
using ServerSidejQueryDatatableDotNetCore3._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\_ViewImports.cshtml"
using ServerSidejQueryDatatableDotNetCore3._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03b058af3fbf3dc0a216da60938f3fb21b837bbc", @"/Views/Sale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1a281e6d29a6845ae334c740ecd5dc3a34e35b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\Index.cshtml"
  
    ViewData["Title"] = "Sales List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    td.details-control {
        background: url('lib/jqueryDataTable/css/images/details_open.png') no-repeat center center;
        cursor: pointer;
    }

    tr.shown td.details-control {
        background: url('lib/jqueryDataTable/css/images/details_close.png') no-repeat center center;
    }
</style>

<div class=""row"">
    <table id=""tblSalesList"" class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr>
                <th>Sl</th>
                <th>Invoice</th>
                <th>Date</th>
                <th>Amount</th>
                <th>Discount</th>
                <th>Action</th>
            </tr>
            <tr>
                <th>Sl</th>
                <th>Invoice</th>
                <th>Date</th>
                <th>Amount</th>
                <th>Discount</th>
                <th>Action</th>
            </tr>
        </thead>
    </table>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            var saleTable = $('#tblSalesList').DataTable({
                lengthMenu: [[10, 20, 50, 100], [10, 20, 50, 100]],
                processing: true,
                searching: true,
                //serverSide: true,
                //scrollX: true,
                //fixedColumns: { leftColumns: 0, rightColumns: 1 },
                ajax: {
                    //""url"": ""/Prescription/Patients/AllProduct"",
                    ""url"": """);
#nullable restore
#line 53 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\Index.cshtml"
                       Write(Url.Action("AllSales", "Sale"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    ""type"": ""POST"",
                    contentType: ""application/json"",
                    ""datatype"": ""json"",
                    data: function (d) {
                        return JSON.stringify(d);
                    }
                },
                columns: [
                    { 'data': 'sl', 'orderable': 'false' },
                    { 'data': 'id' },
                    { 'data': 'salesDate' },
                    { 'data': 'discountAmount' },
                    { 'data': 'totalAmount' },
                    {
                        ""className"": 'details-control',
                        ""orderable"": false,
                        ""data"": null,
                        ""defaultContent"": ''
                    }
                ]
            });

            $(saleTable.table().container()).on('keyup', 'thead input', function () {
                var searchText = this.value.trim();
                saleTable.column($(this).parent().index() + ':visibl");
                WriteLiteral(@"e')
                        .search(searchText)
                        .draw();
            });

            $('#tblSalesList tbody').on('click', 'td.details-control', function () {
                var tr = $(this).closest('tr');
                var row = saleTable.row(tr);

                if (row.child.isShown()) {
                    // This row is already open - close it
                    row.child.hide();
                    tr.removeClass('shown');
                }
                else {
                    // Open this row
                    $.ajax({
                         url: '");
#nullable restore
#line 95 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\Index.cshtml"
                          Write(Url.Action("GetSaleDetailsByInvoice", "Sale"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                         type: 'GET',
                        data: { id: row.data().id }
                    }).done(function (response) {
                        //row.data()
                        row.child(format(response)).show();
                         tr.addClass('shown');
                         return table;
                     }).fail(function (err) {
                         console.log(table);
                         return table;
                     });
                    
                }
            });

            $('#tblProductList_filter').html('<a href=""");
#nullable restore
#line 111 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\Index.cshtml"
                                                  Write(Url.Action("NewSale","Sale"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" class=""btn btn-primary"" style=""margin-bottom:10px;"">New Product</a>');
        });

        function format(d) {



            //return '<table cellpadding=""5"" cellspacing=""0"" border=""0"" style=""padding-left:50px;"">' +
            //    '<tr>' +
            //    '<td>Full name:</td>' +
            //    '<td>' + d.name + '</td>' +
            //    '</tr>' +
            //    '<tr>' +
            //    '<td>Extension number:</td>' +
            //    '<td>' + d.extn + '</td>' +
            //    '</tr>' +
            //    '<tr>' +
            //    '<td>Extra info:</td>' +
            //    '<td>And any further details here (images etc)...</td>' +
            //    '</tr>' +
            //    '</table>';
        }
    </script>

");
            }
            );
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
