using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_411.Controller;
using FinalProject_411.Model;

namespace FinalProject_411.WebForms
{
    public partial class ShoppingPlazaForm : System.Web.UI.Page
    {
        List<CartObject> cart = new List<CartObject>();
        List<Product> allProducts;

        //create separate lists to hold books and dvds
        List<Product> bookList = new List<Product>();
        List<Product> dvdList = new List<Product>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if session is null, recreate prodobj
            if (Session["AllProducts"] == null)
            {
                BuildProducts prodObj = new BuildProducts();
            }

            //assigns the session AllProducts to the product list variable
            allProducts = (List<Product>)Session["AllProducts"];

            if (!IsPostBack)
            {
                //foreach element in allProducts list, assign the Product title to the 
                //appropriate drop down list and add product to the respective list
                foreach (Product element in allProducts)
                {
                    if (element.ProductType == "Book")
                    {
                        bookSelectionDropDown.Items.Add(element.Title);
                        bookList.Add(element);

                    }
                    else
                    {
                        dvdSelectionDropDown.Items.Add(element.Title);
                        dvdList.Add(element);
                    }
                }

                //gets selected index of dropdown box
                int selectedBookIndex = bookSelectionDropDown.SelectedIndex;
                int selectedDvdIndex = dvdSelectionDropDown.SelectedIndex;
                //assigns the selected index to a product variable
                Product selectedBookProduct = bookList[selectedBookIndex];
                Product selectedDvdProduct = dvdList[selectedDvdIndex];
                //set the price labels with the product variable's price property
                bookPriceLabel.Text = selectedBookProduct.Price.ToString("c");
                dvdPriceLabel.Text = selectedDvdProduct.Price.ToString("c");
                //Create sessions to hold the value of the book and dvd lists
                HttpContext.Current.Session["AllBooks"] = bookList;
                HttpContext.Current.Session["AllDvds"] = dvdList;
            }
        }

        protected void addBttn_Click(object sender, EventArgs e)
        {
            //when add button clicked, check to see if both of the quantity text boxes are empty
            if (string.IsNullOrEmpty(bookQuantityTxtBx.Text) && string.IsNullOrEmpty(dvdQuantityTxtBx.Text))

            {
                messageLabel.Text = "One of the quantities must be more than 0. Otherwise, Please Click Exit.";
            }

            if (!(Session["CartObjects"] == null))
            {
                cart = (List<CartObject>)Session["CartObjects"];
            }
            else
                cart = new List<CartObject>();

            if (!string.IsNullOrEmpty(bookQuantityTxtBx.Text))
            {
                //create a list of products to hold the list of books held in session AllBooks
                List<Product> cartBookList = (List<Product>)Session["AllBooks"];
                //holds the quantity in textbox
                int bookQuantity = int.Parse(bookQuantityTxtBx.Text);
                //variable to hold the selected index of the drop down box
                int selectedBook = bookSelectionDropDown.SelectedIndex;
                //product variable assigned the current index of the list
                Product selectedBookProduct = cartBookList[selectedBook];
                //create a new cart object of the current quantity and product
                CartObject bookCartObj = new CartObject(bookQuantity, selectedBookProduct);
                //Add that cart object to the cart list
                cart.Add(bookCartObj);
                //Add the cartlist to the session
                Session.Add("CartObjects", cart);

            }

            //
            if (!string.IsNullOrEmpty(dvdQuantityTxtBx.Text))
            {
                List<Product> cartDvdList = (List<Product>)Session["AllDvds"];
                int dvdQuantity = int.Parse(dvdQuantityTxtBx.Text);
                int selectedDvd = dvdSelectionDropDown.SelectedIndex;
                Product selectedDvdProduct = cartDvdList[selectedDvd];
                CartObject dvdCartObj = new CartObject(dvdQuantity, selectedDvdProduct);
                cart.Add(dvdCartObj);
                Session.Add("CartObjects", cart);
            }
        }


        //Redirects to the Checkout screen as long as items have been selected for purchase
        protected void checkoutBttn_Click(object sender, EventArgs e)
        {
            if (Session["CartObjects"] == null)
            {
                messageLabel.Text = "Before checking out, you must first choose to purchase a product. Otherwise, Please Click Exit.";
            }
            else
            {
                Response.Redirect("Checkout.aspx");
            }
        }

        //Redirects to the Exit screen
        protected void exitBttn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitPage.aspx");
        }

        //Changes book price label according to which book is selected
        protected void bookSelectionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> cartBookList = (List<Product>)Session["AllBooks"];
            int selectedBookIndex = bookSelectionDropDown.SelectedIndex;
            Product selectedBookProduct = cartBookList[selectedBookIndex];
            bookPriceLabel.Text = cartBookList[selectedBookIndex].Price.ToString("c");
        }

        //Changes dvd price label according to which dvd is selected
        protected void dvdSelectionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> cartDvdList = (List<Product>)Session["AllDvds"];
            int selectedDvdIndex = dvdSelectionDropDown.SelectedIndex;
            Product selectedDvdProduct = cartDvdList[selectedDvdIndex];
            dvdPriceLabel.Text = selectedDvdProduct.Price.ToString("c");
        }
    }
}
