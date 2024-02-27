using CET322_HW1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class BookController : Controller
{
    public IActionResult Index()
    {
        // Örnek kitap kayıtları oluşturalım
        var books = new List<CET322_HW1.Models.BookManager.Book>
    {
        new CET322_HW1.Models.BookManager.Book { BookName = "Denemeler", Author = "Montaigne", PageNumber = 336, DueDate = DateTime.Now },
        new CET322_HW1.Models.BookManager.Book { BookName = "Suç ve Ceza", Author = "Dostoyevski", PageNumber = 551, DueDate = DateTime.Now.AddDays(-14) },
        new CET322_HW1.Models.BookManager.Book { BookName = "1984", Author = "George Orwell", PageNumber = 328, DueDate = DateTime.Now.AddDays(21) }
    };
        return View(books);
    }
}
