#pragma checksum "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\NewSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0696fa9ee4032fa72c385592f13c548c2a6101c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sale_NewSale), @"mvc.1.0.view", @"/Views/Sale/NewSale.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0696fa9ee4032fa72c385592f13c548c2a6101c", @"/Views/Sale/NewSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1a281e6d29a6845ae334c740ecd5dc3a34e35b", @"/Views/_ViewImports.cshtml")]
    public class Views_Sale_NewSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServerSidejQueryDatatableDotNetCore3._1.ViewModels.InvoiceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\NewSale.cshtml"
  
    ViewData["Title"] = "New Sale";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row text-center\">\r\n");
            WriteLiteral(@"</div>

<div class=""row"">
    <div class=""form-inline"" action=""/action_page.php"">
        <div class=""form-group"">
            <label for=""txtProductName"">Product:</label>
            <input type=""text"" class=""form-control"" id=""txtProductName"">
            <input type=""hidden"" class=""form-control"" id=""hidProductId"">
        </div>
        &nbsp;
        <div class=""form-group"">
            <label for=""txtProductBrand"">Brand:</label>
            <input type=""text"" class=""form-control input-sm"" id=""txtProductBrand"" disabled>
        </div>
        &nbsp;
        <div class=""form-group"">
            <label for=""txtProductModel"">Model:</label>
            <input type=""text"" class=""form-control input-sm"" id=""txtProductModel"" disabled>
        </div>
        &nbsp;
        <div class=""form-group"">
            <label for=""txtProductSize"">Size:</label>
            <input type=""text"" class=""form-control input-sm"" id=""txtProductSize"" disabled>
        </div>
        &nbsp;
        <div class=""f");
            WriteLiteral(@"orm-group"">
            <label for=""txtProductPrice"">Price:</label>
            <input type=""text"" class=""form-control"" id=""txtProductPrice"" disabled=""disabled"">
            <input type=""hidden"" class=""form-control"" id=""hidProductPrice"">
        </div>
        &nbsp;
        <div class=""form-group"">
            <label for=""txtProductDiscount"">Discount:</label>
            <input type=""text"" class=""form-control"" id=""txtProductDiscount"" disabled>
        </div>
        &nbsp;
        <button type=""button"" id=""btnAdd"" class=""btn btn-primary"" disabled=""disabled"">+</button>
    </div>
</div>
<br />
<br />

");
#nullable restore
#line 52 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\NewSale.cshtml"
 using (Html.BeginForm())
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        
        <table id=""tblSalesDetails"" class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Sl</th>
                    <th>Name</th>
                    <th>Brand</th>
                    <th>Model</th>
                    <th>Size</th>
                    <th class=""text-right"">Discount</th>
                    <th class=""text-right"">Price</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody id=""tbodySaleDetails"">
            </tbody>
            <tfoot>
                <tr>
                    <th colspan=""5"" class=""text-right"">Total : </th>
                    <th class=""text-right"">
                        <input class=""form-control"" type=""text"" name=""TotalDiscount"" readonly=""readonly"" id=""txtTotalDiscount"" value=""0"" />
                    </th>
                    <th class=""text-right"">
                        <input class=""form-control"" type=""text"" name=""Total");
            WriteLiteral(@"Price"" readonly=""readonly"" id=""txtTotalPrice"" value=""0"" />
                    </th>
                    <th class=""text-right"">

                    </th>

                </tr>
            </tfoot>
        </table>
    </div>
    <br />
    <div class=""row text-center"">
        <button type=""submit"" class=""btn btn-success"">Save</button>
    </div>
");
#nullable restore
#line 94 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\NewSale.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {


            $('#txtProductName').autocomplete({

                source: function (request, response){
                    $.ajax({
                        type: 'GET',
                        url: '");
#nullable restore
#line 107 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\NewSale.cshtml"
                         Write(Url.Action("GetProductList", "Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        data: { name: this.term },
                        success: function (data) {
                            response(data);
                        }
                    });
                },
                change: function (event, ui) {
                    if (!ui.item) {
                        clear();
                    }
                },
                select: function (e, ui) {
                    var id = ui.item.id;
                    $.ajax({
                        url: '");
#nullable restore
#line 122 "H:\Git\Core\Core3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\ServerSidejQueryDatatableDotNetCore3.1\Views\Sale\NewSale.cshtml"
                         Write(Url.Action("GetProductById", "Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        type: 'GET',
                        data: { id: id }
                    }).done(function (response) {
                        console.log(response);
                        $('#hidProductId').val(id);
                        $('#txtProductBrand').val(response.brand);
                        $('#txtProductModel').val(response.model);
                        $('#txtProductSize').val(response.size);
                        $('#txtProductPrice').val(response.price);
                        $('#hidProductPrice').val(response.price);
                        $('#txtProductDiscount').val('0');

                        $('#txtProductPrice').removeAttr('disabled');
                        $('#btnAdd').removeAttr('disabled');

                    }).fail(function (err) {
                        alert('Not Found');
                    });
                }
            });

            $(""input"").keyup(function () {
                var oritinalPrice = $('#hidProductPrice");
                WriteLiteral(@"').val();
                var currentPrice = $(""#txtProductPrice"").val();
                if (currentPrice === '') {
                    currentPrice = 0;
                    $('#btnAdd').attr('disabled', 'disabled');
                }
                else {
                    $('#btnAdd').removeAttr('disabled');
                }
                $(""#txtProductDiscount"").val(oritinalPrice - currentPrice);
            });

            $('#btnAdd').click(function () {
                var productId = $('#hidProductId').val();
                var productName = $('#txtProductName').val();
                var productBrand = $('#txtProductBrand').val();
                var productModel = $('#txtProductModel').val();
                var productSize = $('#txtProductSize').val();
                var productPrice = $('#txtProductPrice').val();
                var productDiscount = $('#txtProductDiscount').val();

                var totalDiscount = $('#txtTotalDiscount').val();
                var");
                WriteLiteral(@" totalPrice = $('#txtTotalPrice').val();

                console.log(totalDiscount);
                console.log(totalPrice);

               var rowCount =  $('#tblSalesDetails tbody').find('tr').length + 1;

                
                var rowIndex = rowCount - 1;

                var row = '<tr>'

                row += '<td><label>' + rowCount + '</label></td>';

                row += '<td><label>' + productName + '</label>';
                row += '<input type=""hidden"" name=""InvoiceDetails[' + rowIndex+'].ProductId"" value=""' + productId + '"" /></td>';

                row += '<td><label>' + productBrand + '</label></td>';
                row += '<td><label>' + productModel + '</label></td>';
                row += '<td><label>' + productSize + '</label></td>';

                row += '<td class=""text-right""><label>' + productDiscount + '</label>';
                row += '<input type=""hidden"" name=""InvoiceDetails[' + rowIndex +'].Discount"" value=""' + productDiscount + '"" /></t");
                WriteLiteral(@"d>';

                row += '<td class=""text-right""><label>' + productPrice + '</label>';
                row += '<input type=""hidden"" name=""InvoiceDetails[' + rowIndex +'].SalePrice"" value=""' + productPrice + '"" /></td>';

                row += '<td></td>';
                row += '</tr>';
                $('#tbodySaleDetails').append(row);
                $('#txtTotalDiscount').val(parseFloat(totalDiscount) + parseFloat(productDiscount));
                $('#txtTotalPrice').val(parseFloat(totalPrice) + parseFloat(productPrice));
                clear();
            });

        });
        function clear() {
            $('#txtProductName').val('');
            $('#txtProductBrand').val('');
            $('#txtProductModel').val('');
            $('#txtProductSize').val('');
            $('#txtProductPrice').val('');
            $('#hidProductPrice').val('0');
            $('#txtProductDiscount').val('');
            $('#txtProductPrice').attr('disabled', 'disabled');
            $('");
                WriteLiteral("#btnAdd\').attr(\'disabled\', \'disabled\');\r\n            $(\'#hidProductId\').val(\'\');\r\n        }\r\n\r\n    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServerSidejQueryDatatableDotNetCore3._1.ViewModels.InvoiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
