using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
namespace ProductReviewManagement
{
    public class Manage
    {
        public readonly DataTable dataTable = new DataTable();

        // UC2

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.rating descending
                                select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.productId + " " + "UserId:- " + list.userId
                    + " " + "Rating:- " + list.rating + " " + "Review:- " + list.review + " " + "isLike :- " + list.isLike);
            }
        }
 
        // UC3
        
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.productId == 1 ||
                                     productReviews.productId == 4 ||
                                     productReviews.productId == 9) && (productReviews.rating > 3)
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.productId + " " + "UserId:- " + list.userId
                    + " " + "Rating:- " + list.rating + " " + "Review:- " + list.review + " " + "isLike :- " + list.isLike);
            }
        }

        // UC4
       
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.productId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Count);
            }
        }

        //UC5
        public void RetrieveProdutIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.productId
                                select productReviews);
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.productId + "     " + list.rating);
            }
        }
        //UC6
        public void SkipTopFive(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.productId
                                select productReviews);
            foreach (var list in recordedData.Skip(5))
            {
                Console.WriteLine("ProductId:- " + list.productId + " " + "UserId:- " + list.userId
                    + " " + "Rating:- " + list.rating + " " + "Review:- " + list.review + " " + "isLike :- " + list.isLike);
            }
        }

        //UC7
        public void RetrieveReviewNice(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.review == "Nice")
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.productId + " " + "UserId:- " + list.userId
                    + " " + "Rating:- " + list.rating + " " + "Review:- " + list.review + " " + "isLike :- " + list.isLike);
            }
        }
        
        //UC8
        public void RetrieveisLikeTrue(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.isLike == true)
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.productId + " " + "UserId:- " + list.userId
                    + " " + "Rating:- " + list.rating + " " + "Review:- " + list.review + " " + "isLike :- " + list.isLike);
            }
        }
    }
}
