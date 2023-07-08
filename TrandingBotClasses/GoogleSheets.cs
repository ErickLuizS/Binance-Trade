using DocumentFormat.OpenXml.Office2019.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using GoogleSheetsWrapper;
using GoogleSheetsWrapper.Tests.TestObjects;

namespace TrandingBotClasses
{
    public class GoogleSheets
    {

        public Guid GoogleSheetsId { get; set; }

        public string SheetID { get; set; }
        public string TabName { get; set; }


        private TestRepository repository;
     

        public virtual Cliente Cliente { get; set; }



        private const string serviceAccount = ""; // Insira o email da sua Service Accoount, Para saber mais sobre como criar uma vá em https://robocorp.com/docs/development-guide/google-sheets/interacting-with-google-sheets#create-a-google-service-account
       
        private const string jsonCredsContent = ""; // Insira o caminho para seu Arquivo JSON de credenciais. Para saber mais sobre como criar uma vá em https://robocorp.com/docs/development-guide/google-sheets/interacting-with-google-sheets#create-a-google-service-account

        public GoogleSheets() { }



        /// <summary>
        /// Cria um SheetHelper para o objeto.
        /// </summary>
        public async Task CreateSheetHelper()
        {

            var SheetHelper = new SheetHelper<TestRecord>(SheetID, serviceAccount, TabName);
            var t = File.ReadAllText(jsonCredsContent);
        
   
            SheetHelper.Init(t);


            repository = new TestRepository(SheetHelper);



        }

        /// <summary>
        /// Adiciona um dado no final da planilha
        /// </summary>
        public async Task Gravar(

            string? symbol,
            int? id,
            int? orderId,
            decimal? price,
            decimal? qty,
            decimal? quoteQty,
            decimal? comission,
            string? comissionAsset,
            decimal? time

            )
        {


            await CreateSheetHelper();

            repository.AddRecord(new TestRecord()
            {
                symbol = symbol
                ,
                id = id
                ,
                orderId = orderId
                ,
                price = price
                ,
                qty = qty
                ,
                quoteQty = quoteQty
                ,
                comission = comission
                ,
                comissionAsset = comissionAsset
                ,
                time = time

            });




        }




    }




































}

