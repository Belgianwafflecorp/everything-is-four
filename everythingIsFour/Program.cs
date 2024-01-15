namespace everythingIsFour
{
    internal class Program
    {

        static void Four(int inputLenght, string userInput, string[] spelledNumbers)
        {
            if (inputLenght == 4)
            {
                Console.WriteLine($"{userInput} lenght = four, just like everything else in the universe.");
            }
            else
            {
                Console.WriteLine($"The length of {userInput} = {spelledNumbers[inputLenght]}");
                string numberName = spelledNumbers[inputLenght];

                while (numberName != "four")
                {
                    Console.WriteLine($"The length of {numberName} = {spelledNumbers[numberName.Length]}");
                    string newNumberName = spelledNumbers[numberName.Length];
                    numberName = newNumberName;
                }
            }
        }

        static void Again(string[] spelledNumbers)
        {
            Console.WriteLine("Want to see more proof of why everything is four?\ty / n");
            string yOrN = Console.ReadLine();
            while (yOrN != "n" ||  yOrN != "N")
            {
                Console.WriteLine("Give another name, place or object: ");
                string userInput = Console.ReadLine();
                int inputLenght = Convert.ToInt32(userInput.Length);
                Four(inputLenght, userInput, spelledNumbers);
                Console.WriteLine("Want to see more proof of why everything is four?\ty / n");
                yOrN = Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            string[] spelledNumbers = {
  "zero",
  "one",
  "two",
  "three",
  "four",
  "five",
  "six",
  "seven",
  "eight",
  "nine",
  "ten",
  "eleven",
  "twelve",
  "thirteen",
  "fourteen",
  "fifteen",
  "sixteen",
  "seventeen",
  "eighteen",
  "nineteen",
  "twenty",
  "twenty-one",
  "twenty-two",
  "twenty-three",
  "twenty-four",
  "twenty-five",
  "twenty-six",
  "twenty-seven",
  "twenty-eight",
  "twenty-nine",
  "thirty",
  "thirty-one",
  "thirty-two",
  "thirty-three",
  "thirty-four",
  "thirty-five",
  "thirty-six",
  "thirty-seven",
  "thirty-eight",
  "thirty-nine",
  "forty",
  "forty-one",
  "forty-two",
  "forty-three",
  "forty-four",
  "forty-five",
  "forty-six",
  "forty-seven",
  "forty-eight",
  "forty-nine",
  "fifty"
};


            Console.WriteLine(@"Are you tired of being lied to? Do you ever get the feeling that everything you know is just a facade?
Our app will reveal the truth that has been hidden from you.
Prepare to have your mind blown as you discover that everything you know is actually four.
This is not a coincidence, it's a conspiracy.
Join us and be part of the revolution that will change the world forever.


       .+------+     +------+     +------+     +------+     +------+.
     .' |    .'|    /|     /|     |      |     |\     |\    |`.    | `.
    +---+--+'  |   +-+----+ |     +------+     | +----+-+   |  `+--+---+
    |   |  |   |   | |    | |     |      |     | |    | |   |   |  |   |
    |  ,+--+---+   | +----+-+     +------+     +-+----+ |   +---+--+   |
    |.'    | .'    |/     |/      |      |      \|     \|    `. |   `. |
    +------+'      +------+       +------+       +------+      `+------+

");

            Console.WriteLine("Let's start with the first name, place or object that comes to mind: ");
            string userInput = Console.ReadLine();
            int inputLenght = Convert.ToInt32(userInput.Length);
            Four(inputLenght, userInput, spelledNumbers);
            Again(spelledNumbers);
        }
    }
}
