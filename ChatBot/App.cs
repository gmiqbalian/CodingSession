using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodingSession
{
    public class App
    {
        public void Run()
        {
            main();
        }
        public void ChatBot()
        {
            while (true)
            {
                Console.Write(":");
                var input = Console.ReadLine();
                var answer = GetRandomAnswer();
                Console.WriteLine(answer);
            }
        }

        public string GetRandomAnswer()
        {
            var arrayOfAnswers = new string[] 
            {
                "Jag mår bra",
                "Lämna mig ifred",
                "Vad sa du?",
                "whatever",
                "Kanske det",
                "Ingen aning",
                "Ja vad bra"
            };
            var random = new Random();
            var index = random.Next(0, arrayOfAnswers.Length);
            return arrayOfAnswers[index];
        }
        public void ChatBotBob()
        {
            while (true)
            {                
                Console.WriteLine("Wanna continue? ");
                var input = Console.ReadLine();                
                if (input.ToLower() == "no" || input.ToLower() == "n")
                {
                    break;
                }
                var response = generateResponse(input);
                Console.WriteLine(response);
            }
        }

        public string generateResponse(string input)
        {
            var responseArray = new string[]
            {
                "Sure",
                "Whoa, chill out!",
                "Calm down, I know what I'm doing!",
                "Fine. Be that way!",
                "Whatever"
            };
                        
            if (UpperCase(input) && input.EndsWith('?'))
            {
                return responseArray[2];
            }
            else if (input.EndsWith('?'))
            {
                return responseArray[0];
            }
            else if (UpperCase(input))
            {
                return responseArray[1];
            }
            else if (input.ToLower() == "bob")
            {
                return responseArray[3];
            }            
            else
            {
                return responseArray[4];
            }

        }
        public bool UpperCase(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public void main()
        {
            var inputList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, -1, -2, 8, 9, -10};
            RemoveNegative(inputList);
            
        }
        public void RemoveNegative(List<int> inputList)
        {
            var newList = new List<int>();

            foreach (var positive in inputList)
            {
                if (positive >= 0)
                {
                    newList.Add(positive);
                }
            }
            
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
