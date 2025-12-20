using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace p511_oop
{


    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            string filePath = @"C:\Users\User\Desktop\data.txt";

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine("Hello!");
                    streamWriter.WriteLine("C#");

                    Console.WriteLine("Данные успешно записаны");
                }                    
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        
            try
            {
                using (streamReader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }        
            } catch (Exception ex)
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
