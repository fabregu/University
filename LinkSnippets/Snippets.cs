using System.Linq;

namespace LinkSnippets
{
    public class Snippets
    {
        static public void BasicLinkq()
        {
            string[] cars = { "VW California", "Fiat Punto", "Seat Ibiza", "Seat León" , "Audi 5", "Audi 3", "VW Wolf"};


            // 1. SELECT * OF CARS
            var carList = from car in cars
                          select car;
            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }

            // 2. SELECT * OF CARS WHERE IS AUDI
            var audiList = from car in cars
                           where car.Contains("Audi")
                           select car;

            foreach (var audi in audiList)
            {
                Console.WriteLine(audi);
            }
        }

        //Number Examples
        static public void NumberLink()
        {
            List <int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. SELECT * OF NUMBERS
            var processedNumberList = numbers
                .Select(num => num * 3) //(3, 6, 9, etc)
                .Where(num => num != 9)
                .OrderBy(num => num); //(3, 6, 9, etc)
        }

        static public void SearchExample() 
        { 
            List<string> textList = new List<string> { "a", "bx", "c", "d" , "e", "cj", "f", "c"};

            //First of all Element
            var first = textList.First();

            //First Element that is c
            var cText = textList.First(x => x.Equals("c"));

            //First Element that is j 
            var jText = textList.First(x => x.Equals("j"));

            //First Element that is Z or default 
            var firstOrDefault = textList.FirstOrDefault(x => x.Equals("z"));

            //Last Element that is Z or default 
            var lastOrDefault = textList.LastOrDefault(x => x.Equals("z"));

            //Single Value
            var uniqueText = textList.Single();
            var uniqueOrDefaultText = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8, 10 };
            int[] otherEvenNumbers = { 0, 2, 6 };

            //Obtain
            var myEvenNumbers = evenNumbers.Except(otherEvenNumbers);   
        }

        static public void MultipleSelects()
        {
            // select many
            string[] myOpinions =
            {
                "Opinion 1, text 1",
                "Opinion 2, text 2",
                "Opinion 3, text 3"
            };

            var myOpinionSelection = myOpinions.SelectMany(opinion => opinion.Split(","));

        }

    }
}
