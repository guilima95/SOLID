namespace SOLID.OCP.After
{
    public class ReviewBook
    {
        public static void Operations()
        {
            Menu();

            var option = Console.ReadKey();
            var result = string.Empty;

            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("Let's go, doing review of physical book");
                    result = SetReviewBookPhysical();
                    break;

                case '2':
                    Console.WriteLine("Let's go, doing review of digital book");
                    result = SetReviewBookDigital();
                    break;
            }

            ReturnReview(result);
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Review the book using SOLID Principle OCP:");
            Console.WriteLine("Choice your book option:");
            Console.WriteLine();
            Console.WriteLine("1 - Review Physical book.");
            Console.WriteLine("2 - Review Digital book.");
        }

        private static string SetReviewBookDigital()
        {
            Console.WriteLine();
            Console.WriteLine("......................");
            Console.WriteLine();
            Console.WriteLine("Name the book");
            var bookName = Console.ReadLine();
            Console.WriteLine("Digit the score to review:");
            var score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digit the number pages the book:");
            var numberPages = Convert.ToInt32(Console.ReadLine());

            var book = new BookDigital();

            return book.Review(numberPages, bookName, score);
        }

        private static string SetReviewBookPhysical()
        {
            Console.WriteLine();
            Console.WriteLine("......................");
            Console.WriteLine();
            Console.WriteLine("Name the book");
            var bookName = Console.ReadLine();
            Console.WriteLine("Digit the score to review:");
            var score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digit the number pages the book:");
            var numberPages = Convert.ToInt32(Console.ReadLine());

            var book = new BookPhysical();

            return book.Review(numberPages, bookName, score);
        }

        private static void ReturnReview(string score)
        {
            Console.WriteLine();
            Console.WriteLine($"Review successfully! book reviewed: {score}");
            Console.ReadKey();
        }
    }
}
