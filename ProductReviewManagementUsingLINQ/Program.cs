using System;
using System.Collections.Generic;

namespace ProductReviewManagementUsingLINQ
{
    public class Program
    {
        // LinQ -  it is language integrated Query . it use for grouping , sorting and ordering data.
        public static void Main(string[] args)
        {
            List<ProductReviewModel> listOfProductReview = new List<ProductReviewModel>()
            {
                new ProductReviewModel { ProductId = 1 , UserId = 11 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 2 , UserId = 10 , Rating = 2 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 3 , UserId = 11 , Rating = 4 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 4 , UserId = 11 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 5 , UserId = 11 , Rating = 3 , Review = "Average" , isLike = true  },
                new ProductReviewModel { ProductId = 6 , UserId = 10 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 7 , UserId = 10 , Rating = 2 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 8 , UserId = 8 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 9 , UserId = 11 ,Rating = 5 , Review = "Good" , isLike = true },
                new ProductReviewModel { ProductId = 10 , UserId = 9 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 11 , UserId = 10 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 12 , UserId = 10 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 13 , UserId = 10 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 11 , UserId = 7 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 1 , UserId = 6 , Rating = 5 , Review = "Good" , isLike = true },
                new ProductReviewModel { ProductId = 11 , UserId = 5 , Rating = 1 , Review = "Bad", isLike = false  },
            };
            bool flage = true;

            Managment managment = new Managment();

            while (flage)
            {
                Console.WriteLine("\n1. Add Product" +
                    "\n2. Display Products" +
                    "\n3. top 3 records"
                    );
                Console.WriteLine("5. Exit the program");

                Console.Write("\nEnter option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (option)
                {
                    case 1: managment.AddProductReview(listOfProductReview); break;
                    case 2: managment.DisplayProductReviewList(listOfProductReview); break;
                    case 3: managment.RetriveTop3Records(listOfProductReview); break;
                    case 4: managment.RetriveProductRaringGreaterThen3(listOfProductReview); break;
                    case 5: flage = false; break;
                }
            }

        }
    }
}
