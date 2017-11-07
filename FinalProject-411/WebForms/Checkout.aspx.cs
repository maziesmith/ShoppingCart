using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_411.Controller;

namespace FinalProject_411.WebForms
{
    public partial class Checkout : System.Web.UI.Page
    {
        List<CartObject> cartObj = new List<CartObject>();
        protected void Page_Load(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjects"];

            if (!IsPostBack)
            {
                foreach(CartObject prod in cartObj)
                {
                    productListBox.Items.Add(prod.Object.Title.ToString() + " - " + prod.Object.Price.ToString("c"));
                }

                quantityTxtBx.Enabled = false;
            }
        }

        protected void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityTxtBx.Enabled = true;

            int selectedIndex = productListBox.SelectedIndex;

            CartObject selectedObj = cartObj[selectedIndex];

            quantityTxtBx.Text = selectedObj.Quantity.ToString();
        }

        protected void changeQuantity_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(quantityTxtBx.Text);
            int selectedIndex = productListBox.SelectedIndex;
            CartObject selectedObject = cartObj[selectedIndex];

            if (quantity == 0)
            {
                cartObj.Remove(cartObj[productListBox.SelectedIndex]);
                productListBox.Items.RemoveAt(productListBox.SelectedIndex);

            }
            else if (quantity > 0)
            {
                CartObject updatedCartObj = new CartObject(quantity, selectedObject.Object);
                cartObj.Remove(selectedObject);
                cartObj.Add(updatedCartObj);

                productListBox.Items.RemoveAt(selectedIndex);
                productListBox.Items.Add(updatedCartObj.Object.Title.ToString() + " - " + updatedCartObj.Object.Price.ToString("c"));
            }
        }

        protected void payBttn_Click(object sender, EventArgs e)
        {
            double price = 0;
            double discountTotal = 0;
            foreach (CartObject prod in cartObj)
            {
                double itemTotal;
                
                itemTotal = prod.Object.Price * prod.Quantity;
                price += (itemTotal - (itemTotal * prod.Object.CalcDiscountPercentage(prod.Quantity)));
                discountTotal += prod.Object.CalcDiscountPercentage(prod.Quantity);
            }

            priceLabel.Text = "Your total is: " + price.ToString("c") + ". You got a discount of " + discountTotal.ToString("p");
        }

        protected void exitBttn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitPage.aspx");
        }
    }
}