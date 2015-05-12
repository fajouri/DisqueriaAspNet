<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="DisqueriaAspNet.Views.Cart" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<script src="Scripts/cart.js" type="text/javascript"></script> 
<%--<script type="text/javascript">
    $(function () {
        // Document.ready -> link up remove event handler
        $(".RemoveLink").click(function () {
            // Get the id from the link
            var recordToDelete = $(this).attr("data-id");

            if (recordToDelete != '') {

                // Perform the ajax post
                $.post("/ShoppingCart/RemoveFromCart", { "id": recordToDelete },
                    function (data) {
                        // Successful requests get here
                        // Update the page elements
                        if (data.ItemCount == 0) {
                            $('#row-' + data.DeleteId).fadeOut('slow');
                        } else {
                            $('#item-count-' + data.DeleteId).text(data.ItemCount);
                        }

                        $('#cart-total').text(data.CartTotal);
                        $('#updateMessage').text(data.Message);
                        $('#cart-status').text('Cart (' + data.CartCount + ')');
                    });
            }
        });

    });


    function handleUpdate() {
        // Load and deserialize the returned JSON data
        var json = context.get_data();
        var data = Sys.Serialization.JavaScriptSerializer.deserialize(json);

        // Update the page elements
        if (data.ItemCount == 0) {
            $('#row-' + data.DeleteId).fadeOut('slow');
        } else {
            $('#item-count-' + data.DeleteId).text(data.ItemCount);
        }

        $('#cart-total').text(data.CartTotal);
        $('#updateMessage').text(data.Message);
        $('#cart-status').text('Cart (' + data.CartCount + ')');
    }
</script>--%>
<h3>
    <em>Review</em> your cart:
</h3>
    <button></button>
<p><a id="btnCheckout" class="button" runat="server">Checkout >></a></p>
<div id="updateMessage" runat="server" clientidmode="Static">
</div>
<div>
    <%--<label id="lblMessage" runat="server" class="updateMessage"></label>--%>
    <table id="tableCart" runat="server">
        <tr>
            <th>Album Name
            </th>
            <th>Price (each)
            </th>
            <th>Quantity
            </th>
            <th></th>
        </tr>
    </table>

</div>
</asp:Content>