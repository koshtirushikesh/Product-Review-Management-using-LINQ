using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementUsingLINQ
{
    public class Managment
    {
        List<ProductReviewModel> listOfProductModels = new List<ProductReviewModel>();

        public void AddProductReview(List<ProductReviewModel> productReviewModels )
        {
            this.listOfProductModels = productReviewModels;
            Console.WriteLine("Review added successfully.");
        }

        public void DisplayProductReviewList(List<ProductReviewModel> productReviewModels)
        {
            foreach (ProductReviewModel product in productReviewModels)
            {
                Console.WriteLine(" "+ product.ProductId+ " "+ product.UserId+ " "+ product.Rating+ " "+ product.Review+" "+product.isLike);
            }
        }

        public void RetriveTop3Records(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.OrderByDescending(p => p.Rating).Take(3);
            DisplayProductReviewList(result.ToList());
        }

        public void RetriveProductRaringGreaterThen3(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9));
            DisplayProductReviewList(result.ToList());
        }
    }
}
