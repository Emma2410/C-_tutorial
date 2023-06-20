using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = ReadFile("value.csv");
            List<Person> people = new List<Person>();

            people = GetPeople(file);
           
        }

        //filename= path to file
        static string[] ReadFile(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            return lines;
        }

        static List<Person> GetPeople(string[] file) 
        {
            Dictionary<int, List<string>> file_items = new Dictionary<int, List<string>>();
            List<Person> people = new List<Person>();
            for (int i = 1; i < file.Length; i++)
            {
                file_items.Add(i, GetItems(file[i]));
            }

            //create person object
            for(int  i = 1; i < file.Length; i++)
            {
                Person p;
                string firstname = "", lastname ="", occupation =""; int age = 0;
                for(int  j = 0; j < file_items[0].Count(); j++)
                {
                    
                    switch (file_items[0][j])
                    {
                        case "firstname":
                            firstname = file_items[i][j];break;
                        case "lastname":
                            lastname= file_items[i][j];break;
                        case "occupation":
                            occupation= file_items[i][j]; break;
                        case "age":
                            age= int.Parse(file_items[i][j]); break;
                        default: 
                            Console.WriteLine($"Header '{file_items[0][j]}' is not a valid header");break;
                    }
                }
            }
            return new List<Person>(people);

        }
        static List<string> GetItems(string line)
        {
            string current_word = "";
            List<string> items = new List<string>();
            foreach(char c in line)
            {
                if (c == ',' )
                {
                    if (current_word != "")
                    {
                        items.Add(current_word);
                        current_word = "";

                    }
                    else
                    {
                        current_word += c.ToString();
                    }
                }

                if (current_word != "") items.Add(current_word);
            }
            return new List<string>(items);
        }        
    }
}
