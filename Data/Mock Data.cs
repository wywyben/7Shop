using System;
using ASP.NET_CA_SEVEN_SHOP.Models;

namespace ASP.NET_CA_SEVEN_SHOP.Data
{
	public class Mock_Data
	{

            public static List<Products> GetProductData()
            {
                List<Products> products = new List<Products>();

                 //------------------ Mock Data Start ------------------------

                products.Add(new Products
                {
                    Title = "Bunny DVD",
                    Price = "$50",
                    Rating = "3.5",
                    ProdctImageUrl = "newjeans.jpeg",
                    Description = "\"Bunny\" is a music video album DVD from K-pop group NowJeans, featuring a collection of emotional and upbeat music videos about love and programming. The title track \"Bunny\" captures the group's playful side with a romantic twist, while \"Program My Heart\" and \"Code of Love\" explore the theme of programming with a metaphorical twist.",
                    Category = "R21"
                });

                products.Add(new Products
                {
                    Title = "Rabbit DVD",
                    Price = "$40",
                    Rating = "1.2",
                    ProdctImageUrl = "easter-bunny.png",
                    Description = "\"Rabbit\" is an exciting and educational story about a curious rabbit and his animal friends as they embark on a learning adventure. Together, they explore the wonders of the natural world and learn important lessons about friendship, teamwork, and perseverance. With colorful illustrations and relatable characters, this book is perfect for young readers who love to explore and discover new things. Follow Rabbit and his friends on their journey and join in the fun!",
                    Category = "PG13"
                }); ;

                products.Add(new Products
                {
                    Title = "Duck Book",
                    Price = "$30",
                    Rating = "4.8",
                    ProdctImageUrl = "ducky.png",
                    Description = "\"Duck\" In this inspiring story, a duck named Daffy struggles with his identity as he feels that he is meant to be a rabbit. Despite facing skepticism and ridicule from his fellow ducks, Daffy embarks on an adventure and journey of self-discovery to find his true identity. Along the way, he meets other animals who challenge his beliefs, but Daffy remains steadfast in his pursuit of the truth. Through his determination and bravery, Daffy inspires others to embrace their individuality and follow their dreams, no matter how unconventional they may seem.",
                    Category = "M18"
                });

                return products;
            }

            //------------------ Mock Data End ------------------------

    }
}

