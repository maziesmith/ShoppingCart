using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_411.Controller;


namespace FinalProject_411.Model
{
    public class BuildProducts
    {
        List<Product> prod = new List<Product>();

        public BuildProducts()
        {
            Product book1 = new Product();
            book1.ProductType = "Book";
            book1.ProductID = 101;
            book1.Title = "Big Data: A Revolution That Will Transform How We Live, Work, and Think";
            book1.Price = 50.55;


            Product book2 = new Product();
            book2.ProductType = "Book";
            book2.ProductID = 102;
            book2.Title = "Disruptive Possibilities: How Big Data Changes Everything";
            book2.Price = 65.67;

            Product book3 = new Product();
            book3.ProductType = "Book";
            book3.ProductID = 103;
            book3.Title = "Data Smart: Using Data Science to Transform Information into Insight";
            book3.Price = 32.78;

            Product book4 = new Product();
            book4.ProductType = "Book";
            book4.ProductID = 104;
            book4.Title = "Big Data: Principles and best practices of scalable realtime data systems";
            book4.Price = 90.65;

            Product book5 = new Product();
            book5.ProductType = "Book";
            book5.ProductID = 105;
            book5.Title = "Big Data Science & Analytics: A Hands On Approach";
            book5.Price = 15.25;

            Product dvd1 = new Product();
            dvd1.ProductType = "DVD";
            dvd1.ProductID = 201;
            dvd1.Title = "The Grand Tour Season 1";
            dvd1.Price = 10.00;

            Product dvd2 = new Product();
            dvd2.ProductType = "DVD";
            dvd2.ProductID = 202;
            dvd2.Title = "Spectre";
            dvd2.Price = 11.99;

            Product dvd3 = new Product();
            dvd3.ProductType = "DVD";
            dvd3.ProductID = 203;
            dvd3.Title = "Goliath Season 1";
            dvd3.Price = 12.99;

            Product dvd4 = new Product();
            dvd4.ProductType = "DVD";
            dvd4.ProductID = 204;
            dvd4.Title = "The Hunger Games: Mockingjay Part 2";
            dvd4.Price = 10.99;

            Product dvd5 = new Product();
            dvd5.ProductType = "DVD";
            dvd5.ProductID = 205;
            dvd5.Title = "Good Girls Revolt";
            dvd5.Price = 11.99;

            prod.Add(book1);
            prod.Add(book2);
            prod.Add(book3);
            prod.Add(book4);
            prod.Add(book5);
            prod.Add(dvd1);
            prod.Add(dvd2);
            prod.Add(dvd3);
            prod.Add(dvd4);
            prod.Add(dvd5);

            HttpContext.Current.Session["AllProducts"] = prod;
        }

    }
}