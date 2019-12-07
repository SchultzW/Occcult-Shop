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
                product.Price = 16;
                product.Description = "Spruce up anyroom in your house with this jar filled with whispers of the unknown. Who knows what they will whisper(Legal Disclaimer: We are not responsible for Jar of Whispers telling you to sacrafice family members";
                product.Tag = "Home";
                product.imgPath = "/img/Jar.jpg";
                product.IsNew = false;
                context.Products.Add(product);

                product = new Product();
                product.Title = "Unknown Book from the Library of Jurgen Leitner";
                product.Price = 40;
                product.Description = "No one know what is held within the pages of this tome.All our interns that opened it were inflected with mind-boggline instantiy(Legal Disclaimer: We are not respobsible for any alteration to the sanity of purchaser.";
                product.Tag = "Books";
                product.imgPath = "/img/JergenBook.jpg";
                product.IsNew = false;
                context.Products.Add(product);

                product = new Product();
                product.Title = "A Wooden Spoon";
                product.Price = 5;
                product.Description = "A wooden spoon that is great for use in the kitchen";
                product.Tag = "Home";
                product.imgPath = "/img/woodenspoon.jpg";
                product.IsNew = false;
                context.Products.Add(product);

                product = new Product();
                product.Title = "Necronomicon";
                product.Price = 88;
                product.Description = "The Necronomicon has been a staple in any mystic's library. It contains accounts of the Old Ones, their history, and how to summon them.(Legal Disclaimer: We are not responsible for any personal physical or mental injury from attempting to perform a summoning ritural contained in this book.)";
                product.Tag = "Books";
                product.imgPath = "/img/necronomicon.jpg";
                product.IsNew = true;
                context.Products.Add(product);

                product = new Product();
                product.Title = "Garden Gome";
                product.Price = 8;
                product.Description = "A small gnome can really spruce up anyones garden";
                product.Tag = "Home";
                product.imgPath = "/img/gnome.jpg";
                product.IsNew = true;
                context.Products.Add(product);

                product = new Product();
                product.Title = "Spirit Board";
                product.Price = 22;
                product.Description = "A real spirit board to communicate with the great beyond. This is a great gift for teenagers that enjoy venturing into abandoned buildings or a birthday present for your favorite medium. (Legal Disclaimer: We are not responsible for any posessions that may come from using this product.";
                product.Tag = "Home";
                product.imgPath = "/img/SpiritBoard.jpg";             
                product.IsNew = true;
                context.Products.Add(product);

                product = new Product();
                product.Title = "Creepy Thing";
                product.Price = 10;
                product.Description = "We don't know what this thing is but it creeps everyone out and we want it gone. (Legal Discalaimer: We have no idea what this is or does and hold no responsibility for whatever happens with it)";
                product.Tag = "Decor";
                product.imgPath = "/img/creepy.jpg";
                product.IsNew = true;
                context.Products.Add(product);

                Review r = new Review();
                r.Author = "James";
                r.ReviewID = 1;
                r.ReviewText = "Y'AI'NG'NGAH YOG - SOTHOTH H'EE-L'GEB F'AI THRODOG UAAAH";


                product = new Product();
                product.Title = "A Black Obelisk";
                product.Price = 50;
                product.Description = " This small Black Obelisk is perfect for an at home summinings or incantations at home or on the go. It also looks great on a coffee table";
                product.Tag = "Decor";
                product.imgPath = "/img/obelisk.jpg";
                product.IsNew = true;
                product.Reviews.Add(r);


                product = new Product();
                product.Title = "Classy Table Lamp";
                product.Price = 20;
                product.Description = "Are you tried of usin your spirit board in the dark? Fear not gentle customer, this classy table lamp is for you. It brings just enough light to see what your doing but not too much that it ruins the atmosphere.";
                product.Tag = "Decor";
                product.imgPath = "/img/tablelamp.jpg";
                product.IsNew = true;
                context.Products.Add(product);

                product = new Product();
                product.Title = "Amulet of Nyarlathotep";
                product.Price = 55;
                product.Description = "Of unknown origin, this is a must have for any priest of the Crawling Chaos.";
                product.Tag = "Trinkets";
                product.imgPath = "/img/amulet";
                product.IsNew = false;
                context.Products.Add(product);


                product = new Product();
                product.Title = "Sacrificial Dagger";
                product.Price = 155;
                product.Description = "This hand crafted dagger is perfect for offering the innocent to summon an Old One or an Outer God.";
                product.Tag = "Trinkets";
                product.imgPath = "/img/dagger";
                product.IsNew = false;
                context.Products.Add(product);


                product = new Product();
                product.Title = "Hidden Bookcase Door";
                product.Price = 200;
                product.Description = "Tired of local law enforcement or a group of kids with their dog stumbling upon your hidden arcane lab. This bookcase can be easily installed to stop anyone from finding your most guarded secrets.";
                product.Tag = "Home";
                product.imgPath = "/img/bookcase";
                product.IsNew = true;
                context.Products.Add(product);


                product = new Product();
                product.Title = "Mask of Hastur";
                product.Price = 75;
                product.Description = "Hand crafted mask dedicated to the Great Old One Himself. It is freat for any aspiring cultist.";
                product.Tag = "Clothing";
                product.imgPath = "/img/mask";
                product.IsNew = false;
                context.Products.Add(product);


                product = new Product();
                product.Title = "Robes";
                product.Price = 15;
                product.Description = "Robes are the most essential item any cultist needs. Our robes are light-weight, yet durable. They are made from 100% organic cotten";
                product.Tag = "Clothing";
                product.imgPath = "/img/robe";
                product.IsNew = false;
                context.Products.Add(product);




                context.SaveChanges();


            }
        }
    }
}
