using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement`");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { productId = 1, userId = 1, rating = 10, review = "Good,", isLike=true},
                new ProductReview() { productId = 2, userId = 2, rating = 3, review = "Good", isLike = true },
                new ProductReview() { productId = 3, userId = 3, rating = 4, review = "Nice", isLike = true },
                new ProductReview() { productId = 4, userId = 4, rating = 9, review = "Good", isLike = false },
                new ProductReview() { productId = 5, userId = 5, rating = 4, review = "Good", isLike = true },
                new ProductReview() { productId = 6, userId = 1, rating = 1, review = "Nice", isLike = true },
                new ProductReview() { productId = 7, userId = 2, rating = 3, review = "Good", isLike = true },
                new ProductReview() { productId = 8, userId = 3, rating = 4, review = "Good", isLike = true },
                new ProductReview() { productId = 9, userId = 4, rating = 3, review = "Good", isLike = true },
                new ProductReview() { productId = 10, userId = 5, rating = 4, review = "Nice", isLike = false },
                new ProductReview() { productId = 11, userId = 1, rating = 8, review = "Good", isLike = true },
                new ProductReview() { productId = 12, userId = 2, rating = 3, review = "Nice", isLike = true },
                new ProductReview() { productId = 13, userId = 3, rating = 7, review = "Good", isLike = false },
                new ProductReview() { productId = 14, userId = 4, rating = 3, review = "Nice", isLike = true },
                new ProductReview() { productId = 15, userId = 5, rating = 4, review = "Good", isLike = false },
                new ProductReview() { productId = 16, userId = 1, rating = 1, review = "Good", isLike = true }

            };
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductId:- " + list.productId + " " + "UserId:- " + list.userId
            //        + " " + "Rating:- " + list.rating + " " + "Review:- " + list.review + " " + "isLike :- " + list.isLike);
            //}

            Manage manage = new Manage();
            //UC2
            // manage.TopRecords(productReviewList);

            //UC3
            //manage.SelectedRecords(productReviewList);

            //UC4
            //manage.RetrieveCountOfRecords(productReviewList);

            //UC5
            //manage.RetrieveProdutIdAndReview(productReviewList);

            //UC6
            //manage.SkipTopFive(productReviewList);

            //UC7
            //manage.RetrieveReviewNice(productReviewList);

            //UC8
            manage.RetrieveisLikeTrue(productReviewList);
        }
    }
}
