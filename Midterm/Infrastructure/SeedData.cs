using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm;
using Midterm.Models;
using Microsoft.Extensions.DependencyInjection;
using Midterm.Infrastructure;

namespace OccultShop.Infrastructure
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Products.Any())
            {
                Product product = new Product();
                product.Title = "Jar of Whispers";
                product.Price = 10;
                product.Description = "Spruce up anyroom in your house with this jar filled with whispers of the unknown. Who knows what they will whisper(Legal Disclaimer: We are not responsible for Jar of Whispers telling you to sacrafice family members";
                product.Tag = "Home";
                product.imgPath = "/img/Jar.jpg";
                context.Products.Add(product);

                product = new Product();
                product.Title = "Unknown Book from the Library of Jurgen Leitner";
                product.Price = 10;
                product.Description = "No one know what is held within the pages of this tome.All our interns that opened it were inflected with mind-boggline instantiy(Legal Disclaimer: We are not respobsible for any alteration to the sanity of purchaser.";
                product.Tag = "Books";
                product.imgPath = "/img/JergenBook.jpg";
                context.Products.Add(product);

                product = new Product();
                product.Title = "A Wooden Spoon";
                product.Price = 10;
                product.Description = "A wooden spoon that is great for use in the kitchen";
                product.Tag = "Home";
                product.imgPath = "/img/woodenspoon.jpg";
                context.Products.Add(product);

                product = new Product();
                product.Title = "Necronomicon";
                product.Price = 10;
                product.Description = "The Necronomicon has been a staple in any mystic's library. It contains accounts of the Old Ones, their history, and how to summon them.(Legal Disclaimer: We are not responsible for any personal physical or mental injury from attempting to perform a summoning ritural contained in this book.)";
                product.Tag = "Books";
                product.imgPath = "/img/necronomicon.jpg";
                context.Products.Add(product);
                product.IsNew = true;

                product = new Product();
                product.Title = "Garden Gome";
                product.Price = 10;
                product.Description = "A small gnome can really spruce up anyones garden";
                product.Tag = "Home";
                product.imgPath = "/img/gnome.jpg";
                context.Products.Add(product);
                product.IsNew = true;

                product = new Product();
                product.Title = "Spirit Board";
                product.Price = 10;
                product.Description = "A real spirit board to communicate with the great beyond. This is a great gift for teenagers that enjoy venturing into abandoned buildings or a birthday present for your favorite medium. (Legal Disclaimer: We are not responsible for any posessions that may come from using this product.";
                product.Tag = "Home";
                product.imgPath = "/img/SpiritBoard.jpg";
                context.Products.Add(product);
                product.IsNew = true;

                product = new Product();
                product.Title = "Creepy Thing";
                product.Price = 10;
                product.Description = "We don't know what this thing is but it creeps everyone out and we want it gone. (Legal Discalaimer: We have no idea what this is or does and hold no responsibility for whatever happens with it)";
                product.Tag = "Decor";
                product.imgPath = "/img/creepy.jpg";
                context.Products.Add(product);
                product.IsNew = true;

                product = new Product();
                product.Title = "A Black Obelisk ";
                product.Price = 10;
                product.Description = " This small Black Obelisk is perfect for at  summinings or incantations at home or on the go. It also looks great on a coffee table";
                product.Tag = "Decor";
                product.imgPath = "/img/obelisk.jpg";
                product.IsNew = true;


                context.Products.Add(product);






                context.SaveChanges();


            }
        }
    }
}
