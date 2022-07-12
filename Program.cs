// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

// Most commonly used namespaces for PDFTron SDK.
using pdftron;
using pdftron.Common;
using pdftron.PDF;
using pdftron.SDF;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pdf Creation started..!");
            
            //GeneratePdf.generateTexReplacementPdf("text.docx","Text.json","TextOnly.Pdf");
            //GeneratePdf.generateTexReplacementPdf("TextandImage.docx","ImageandText.json","TextandImage.Pdf");
           // GeneratePdf.generateTexReplacementPdf("Text_loop.docx","TextLoop.json","Text_loop.Pdf");
           // GeneratePdf.generateTexReplacementPdf("dynamic_styled_table_loop.docx","dynamic_styled_table_loop.json","dynamic_styled_table_loop.Pdf");
             GeneratePdf.generateTexReplacementPdf("TextandImageWithheaderandFooter.docx","TextandImageWithheaderandFooter.json","TextandImageWithheaderandFooter.Pdf");
            
            Console.WriteLine("Pdf Creation successfully completed..!");
            // Makes the program wait to terminate after user input
            Console.ReadKey();
        }
    }
}