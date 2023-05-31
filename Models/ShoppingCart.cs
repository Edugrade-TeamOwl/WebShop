﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebShop.Models;

public class ShoppingCart
{
    [Key]
    public int ShoppingCartId { get; set; }
    private List<Product> cartItems;

    public ShoppingCart()
    {
        cartItems = new List<Product>();
    }

    public void AddToCart(Product item)
    {
        cartItems.Add(item);
    }

    public void EmptyCart()
    {
        cartItems.Clear();
    }

    public void RemoveCartItem(int i)
    {
        cartItems.RemoveAt(i);
    }
    public List<Product> GetCartItems()
    {
        return cartItems;
    }

}
