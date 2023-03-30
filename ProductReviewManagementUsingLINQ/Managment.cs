using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReviewManagementUsingLINQ
{
    public class Managment
    {
        List<ProductReviewModel> listOfProductModels = new List<ProductReviewModel>();

        public void AddProductReview(List<ProductReviewModel> productReviewModels)
        {
            this.listOfProductModels = productReviewModels;
            Console.WriteLine("Review added successfully.");
        }

        public void DisplayProductReviewList(List<ProductReviewModel> productReviewModels)
        {
            foreach (ProductReviewModel product in productReviewModels)
            {
                Console.WriteLine(" " + product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
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

        public void CountOfReview(List<ProductReviewModel> productReviewModels)
        {
            var groupOfProductId = productReviewModels.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, Count = p.Count() });

            foreach (var product in groupOfProductId)
                Console.WriteLine("Product id: " + product.ProductId + " count: " + product.Count);
        }

        public void RetrivOnlyProductIdAndReview(List<ProductReviewModel> productReviewModels)
        {
            var listOfProductId = productReviewModels.Select(p => new { p.ProductId, p.Review }).ToList();

            foreach (var product in listOfProductId)
                Console.WriteLine(" Product id: " + product.ProductId + " -> " + product.Review);
        }

        public void SkipTop5RecordsFromProductList(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Skip(5);

            foreach (var product in result)
            {
                Console.WriteLine(" " + product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
            }
        }

        // uc9
        public void RetriveIsLikeTrue(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.isLike == true);

            foreach (var product in result)
            {
                Console.WriteLine(" " + product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
            }
        }

        // uc10
        public void AverageRatingForEachProduct(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.GroupBy(p => p.ProductId).Select(p => new { ProductId = p.Key, average = p.Average(x => x.Rating) });

            foreach (var product in result)
                Console.WriteLine("Product id: " + product.ProductId + " Avg: " + product.average);
        }

        // uc11
        public void RetriveNiceMessageRecordFromList(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.Review == "nice");

            foreach (var product in result)
                Console.WriteLine(" " + product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
        }

        //uc12
        public void RetriveUserIdDataByRating(List<ProductReviewModel> productReviewModels)
        {
            var result = productReviewModels.Where(p => p.UserId == 10).OrderBy(p => p.Rating);

            foreach (var product in result)
                Console.WriteLine(" " + product.ProductId + " " + product.UserId + " " + product.Rating + " " + product.Review + " " + product.isLike);
        }

        public DataTable CreatingDataTable(List<ProductReviewModel> productReviewModels)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));

            foreach (var data in productReviewModels)
            {
                dataTable.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.isLike);
            }
            return dataTable;
        }

        public void PrintDataTable(DataTable dataTable)
        {
            Console.Write("ProductId " + " UserId " + " Rating " + " Review " + " IsLike \n");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine();
                for (int i = 0; i < dataRow.ItemArray.Length; i++)
                {
                    Console.Write(dataRow.ItemArray[i] + "   ");
                }
            }
        }
    }
}
