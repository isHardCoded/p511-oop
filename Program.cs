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
            StreamWriter streamWriter = null;
            StreamReader streamReader = null;

            try
            {
                streamWriter = new StreamWriter(
                        @"C:\Users\User\Desktop\data.txt",
                        append: false,
                        encoding: Encoding.UTF8
                );

                streamWriter.WriteLine("Hello!");
                streamWriter.WriteLine("C#");

                Console.WriteLine("Данные успешно записаны");
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

            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        
            try
            {
                streamReader = new StreamReader(
                        @"C:\Users\User\Desktop\data.txt",
                        encoding: Encoding.UTF8
                );

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Неизвестная ошибка");
            } finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}
