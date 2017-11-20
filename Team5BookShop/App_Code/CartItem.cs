﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{
    
        string title;
        int quantity;
        double unitPrice;
        int bookID;


    public string Title
    {
        get
        {
            return title;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }
    }

    public double UnitPrice
    {
        get
        {
            return unitPrice;
        }
    }

    public int BookID
    {
        get
        {
            return bookID;
        }
    }

    public double SubTotal
    {
        get
        {
            return unitPrice * quantity;
        }
    }
}