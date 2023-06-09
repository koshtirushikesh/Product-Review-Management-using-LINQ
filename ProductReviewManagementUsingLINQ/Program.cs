﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReviewManagementUsingLINQ
{
    public class Program
    {
        // LinQ -  it is language integrated Query . it use for grouping , sorting and ordering data.
        public static void Main(string[] args)
        {
            List<ProductReviewModel> listOfProductReview = new List<ProductReviewModel>()
            {
                new ProductReviewModel { ProductId = 1 , UserId = 11 , Rating = 5 , Review = "nice" , isLike = true  },
                new ProductReviewModel { ProductId = 2 , UserId = 10 , Rating = 2 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 3 , UserId = 11 , Rating = 4 , Review = "nice" , isLike = true  },
                new ProductReviewModel { ProductId = 4 , UserId = 11 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 5 , UserId = 11 , Rating = 3 , Review = "Average" , isLike = true  },
                new ProductReviewModel { ProductId = 6 , UserId = 10 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 7 , UserId = 10 , Rating = 2 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 8 , UserId = 8 , Rating = 5 , Review = "nice" , isLike = true  },
                new ProductReviewModel { ProductId = 9 , UserId = 11 ,Rating = 5 , Review = "Good" , isLike = true },
                new ProductReviewModel { ProductId = 10 , UserId = 9 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 11 , UserId = 10 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 12 , UserId = 10 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 13 , UserId = 10 , Rating = 5 , Review = "nice" , isLike = true  },
                new ProductReviewModel { ProductId = 11 , UserId = 7 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 1 , UserId = 6 , Rating = 5 , Review = "nice" , isLike = true },
                new ProductReviewModel { ProductId = 11 , UserId = 5 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 1 , UserId = 10 , Rating = 5 , Review = "nice" , isLike = true },

            };
            bool flage = true;

            Managment managment = new Managment();

            while (flage)
            {
                Console.WriteLine("\n1. Add Product" +
                    "\n2. Display Products" +
                    "\n3. top 3 records" +
                    "\n4. Product Rating Greater Than 3 And product id 1,4,9" +
                    "\n5. Count Of review for each product" +
                    "\n6. Retrive only Product id And Review" +
                    "\n7. Skip top 5 records " +
                    "\n8. Retrive records of isLike is true" +
                    "\n9. Average Rating of each Product Id" +
                    "\n10. Retrive records of review nice" +
                    "\n11. Retrive user Id by Assending by rating"
                    );
                Console.WriteLine("12. Exit the program");

                Console.Write("\nEnter option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (option)
                {
                    case 1: managment.AddProductReview(listOfProductReview); break;
                    case 2: managment.DisplayProductReviewList(listOfProductReview); break;
                    case 3: managment.RetriveTop3Records(listOfProductReview); break;
                    case 4: managment.RetriveProductRaringGreaterThen3(listOfProductReview); break;
                    case 5: managment.CountOfReview(listOfProductReview); break;
                    case 6: managment.RetrivOnlyProductIdAndReview(listOfProductReview); break;
                    case 7: managment.SkipTop5RecordsFromProductList(listOfProductReview); break;
                    case 8: managment.RetriveIsLikeTrue(listOfProductReview); break;
                    case 9: managment.AverageRatingForEachProduct(listOfProductReview); break;
                    case 10: managment.RetriveNiceMessageRecordFromList(listOfProductReview); break;
                    case 11: managment.RetriveUserIdDataByRating(listOfProductReview); break;
                    case 12:managment.CreatingDataTable(listOfProductReview); break;
                    case 13:  var result = managment.CreatingDataTable(listOfProductReview);
                            managment.PrintDataTable(result);break;

                    case 14: flage = false; break;
                }
            }
        }
    }
}
