using GoogleSheetsWrapper.Tests.TestObjects;
using Microsoft.Extensions.Configuration;
using NuGet.Protocol.Core.Types;
using System;
using System.IO;
using System.Linq;

namespace GoogleSheetsWrapper.SampleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
     // Get all rows from the sheet starting with the 1st row, between the 1st and 8th columns
// Leaving the last row blank tells Google Sheets to return all rows from the Sheet
            var config = BuildConfig();

            // Get the Google Spreadsheet Config Values
            var serviceAccount = config["GOOGLE_SERVICE_ACCOUNT"];
            var documentId = config["GOOGLE_SPREADSHEET_ID"];
            var jsonCredsPath = config["GOOGLE_JSON_CREDS_PATH"];
             var documentId2 = "1S4NJbi3OYbST2DwbNPkWAGfdLxgiTOeTV_AyNZXfj6Y";
           
            Console.WriteLine(serviceAccount);
             Console.WriteLine(documentId);
              Console.WriteLine(jsonCredsPath);
   
            // In this case the json creds file is stored locally, but you can store this however you want to (Azure Key Vault, HSM, etc)
           
            var jsonCredsContent = File.ReadAllText("Chave.json");
            // Create a new SheetHelper class
            var sheetHelper = new SheetHelper<TestRecord>(documentId2, serviceAccount,"teste");
            sheetHelper.Init(jsonCredsContent);

            var allRows = sheetHelper.GetRows(new SheetRange ("teste", 1, 1, 8));


            

            // Create a Repository for the TestRecord class
            var repository = new TestRepository(sheetHelper);

            // Add a new record to the end of the Google Sheets tab
            repository.AddRecord(new TestRecord()
            {
       
            });
        }


        /// <summary>
        /// Really simple method to build the config locally.  This requires you to setup User Secrets locally with Visual Studio
        /// </summary>
        /// <returns></returns>
        private static IConfigurationRoot BuildConfig()
        {
            var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");

            var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) ||
                                devEnvironmentVariable.ToLower() == "development";

            var builder = new ConfigurationBuilder();
            // tell the builder to look for the appsettings.json file
            builder
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            
            //only add secrets in development
            if (isDevelopment)
            {
                builder.AddUserSecrets<Program>();
            }

            return builder.Build();
        }  

    }
  
}

