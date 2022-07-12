 using System;

// Most commonly used namespaces for PDFTron SDK.
using pdftron;
using pdftron.Common;
using pdftron.PDF;
using pdftron.SDF;

 public class GeneratePdf
    {
       public const string inputfilepath = @"C:\Users\sunil\dotnetsampleapplication\PDFConsoleApplicationDemo\Templates\";
       public const string outputfilepath = @"C:\Users\sunil\dotnetsampleapplication\PDFConsoleApplicationDemo\PDFDocs\";
       public const string jsonFilePath = @"C:\Users\sunil\dotnetsampleapplication\PDFConsoleApplicationDemo\JsonInputFiles\";
       public static void generateTexReplacementPdf(string inputTemplate, string jsonFile,string outputFile)
        {
            // Initialize PDFNet before using any PDFTron related
            // classes and methods (some exceptions can be found in API)
            //PDFNet.Initialize("demo:1657206433476:7a454c1c0300000000424146ebed66cec1eda0c9159c7e533be1af98ff");
            Console.WriteLine("1");
            //PDFNet.Initialize("PowerDMS, Inc. (www.powerdms.com):OEM:PowerDMS::IA+:AMS(20231226):0FB57B120457580AF3603E3AC992737860613F66F9164A8A9BADB48ABD308B96649A31F5C7");
             PDFNet.Initialize("PowerDMS, Inc. (www.powerdms.com):OEM:PowerDMS::B+:AMS(20231226):6FB5F6120457580AF360B13AC982547860613F66F9164A8A9BADB48ABD308B96649A31F5C7");
            string output_path = outputfilepath + outputFile;
            string input_path = inputfilepath+inputTemplate;
            var json_data_string = System.IO.File.ReadAllText(jsonFilePath+jsonFile);

            try
            {
                using (PDFDoc doc = new PDFDoc())
                {
                    doc.InitSecurityHandler();

                    // create an options object and add your template
                    // replacement values to it. If this option is not
                    // set, the document will convert as if it is a normal
                    // office documents, with no template generation.
                    OfficeToPDFOptions options = new OfficeToPDFOptions();
                    options.SetTemplateParamsJson(json_data_string);

                    // perform the conversion with the template replacement data
                    pdftron.PDF.Convert.OfficeToPDF(doc, input_path, options);
                    doc.Save(output_path, SDFDoc.SaveOptions.e_linearized);

                    System.Console.WriteLine("Done. Results saved in "+ output_path);
                }
            }
            catch (PDFNetException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }