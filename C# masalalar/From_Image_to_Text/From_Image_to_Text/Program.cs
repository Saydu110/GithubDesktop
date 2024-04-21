using System;
using System.Drawing;
using Tesseract;


namespace ImageToText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Rasmdan matn olish uchun OCR obyekti yaratamiz
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    // Rasmi yuklash
                    using (var image = Pix.LoadFromFile("./images/image.jpg"))
                    {
                        using (var page = engine.Process(image))
                        {
                            // Matnni konsolga chiqaramiz
                            Console.WriteLine("Rasmdagi Matn:");
                            Console.WriteLine(page.GetText());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}