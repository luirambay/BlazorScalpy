using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Entities;
using System.Threading;
using Google.Apis.Util.Store;


namespace Scalpy
{
    public class GSheets
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Scalpy";
        static readonly string sheet = "Base única de Ingesta";
        static readonly string sheetTwo = "Concentradora Estatus";
        //static readonly string SpreadsheetId = "1KLGHGy-dUlREUjKQozMPhumtFXG2uFiTr7cWMr-RMK4";
        static readonly string SpreadsheetId = "1UNn1b0KZfmZXxFnPkTChv-thwI2mr9AtrtdIuztySAo";
        static SheetsService service;

        string credentialError = string.Empty;
        string refreshToken = string.Empty;

        static List<BUIEntity> rowsBUI = new List<BUIEntity>();
        static List<IngestBoardEntity> rowsIngestBoard = new List<IngestBoardEntity>();

        public List<BUIEntity> getDataBUI()
        {
            //var connectionGSheets = new Utilities.Connection();

            if (rowsBUI.Count == 0)
            {
                UserCredential credential = GetUserCredential(out credentialError);

                if (credential != null && string.IsNullOrWhiteSpace(credentialError))
                {
                    refreshToken = credential.Token.RefreshToken;
                }

                //Run().Wait();
                //Init();
                readBUI();
            }
            else
            {
                rowsBUI.Clear();
                readBUI();
            }

            return rowsBUI;
        }

        public List<IngestBoardEntity> getDataIngestBoard()
        {
            if (rowsIngestBoard.Count == 0)
            {
                readIngestBoard();
            }
            else
            {
                rowsIngestBoard.Clear();
                readIngestBoard();
            }

            return rowsIngestBoard;
        }

        public static UserCredential GetUserCredential(out string error)
        {
            UserCredential credential = null;
            error = string.Empty;

            try
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = ClientId,
                        ClientSecret = ClientSecret
                    },
                    Scopes,
                    Environment.UserName,
                    CancellationToken.None,
                    new FileDataStore("Scalpy")).Result;

                // Creating Google Sheets API service...
                service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
            }
            catch (Exception ex)
            {
                credential = null;
                error = "Failed to UserCredential Initialization: " + ex.ToString();
            }

            return credential;
        }

        //static void Init()
        //{
        //    GoogleCredential credential;

        //    //Reading Credentials File...
        //    using (var stream = new FileStream("Quickstart-014849b9b400.json", FileMode.Open, FileAccess.Read))
        //    {
        //        credential = GoogleCredential.FromStream(stream)
        //            .CreateScoped(Scopes);
        //    }

        //    // Creating Google Sheets API service...
        //    service = new SheetsService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = ApplicationName,
        //    });
        //}

        static void readBUI()
        {
            // Specifying Column Range for reading...
            var range = $"{sheet}!A4:AM";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(SpreadsheetId, range);

            // Ecexuting Read Operation...
            var response = request.Execute();

            // Getting all records from Column A to E...
            IList<IList<object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row.Count > 0)
                    {
                        if (row.Count < 39)
                        {
                            int dif = 39 - row.Count;

                            for (int i = 0; i < dif; i++)
                            {
                                row.Add("");
                            }
                        }
                    }

                    //List<string> users = new List<string>();
                    // Writing Data on Console...
                    //Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", row[0], row[1], row[2], row[3], row[4]);
                    //object[] array = ;
                    rowsBUI.Add(new BUIEntity
                    {
                        FolioDatahub = row[0].ToString(),
                        CasoUso = row[1].ToString(),
                        EstatusResolucion = row[9].ToString(),
                        Resolucion = row[11].ToString(),
                        FechaResolucion = row[12].ToString(),
                        TipoOrigen = row[18].ToString(),
                        IdTabla = row[20].ToString(),
                        UUAARaw = row[25].ToString(),
                        UUAAMaster = row[32].ToString(),
                        URLDocumentacion = row[34].ToString(),
                        Proyecto = row[36].ToString(),
                        PasaIngesta = row[37].ToString(),
                        QSprintTermino = row[38].ToString()
                    });
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        static void readIngestBoard()
        {
            //var connectionGSheets = new Utilities.Connection();

            // Specifyng sheet
            string SpreadsheetId = "12ywigRiIbAz3e9zxs5ObnbyUELCmfG0qSkx5zRuBFOs";

            // Specifying Column Range for reading...
            var range = $"{sheetTwo}!A3:AZ";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                   service.Spreadsheets.Values.Get(SpreadsheetId, range);

            // Ecexuting Read Operation...
            var response = request.Execute();

            // Getting all records from Column A to E...
            IList<IList<object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row.Count > 0)
                    {
                        if (row.Count < 52)
                        {
                            int dif = 52 - row.Count;

                            for (int i = 0; i < dif; i++)
                            {
                                row.Add("");
                            }
                        }
                    }

                    rowsIngestBoard.Add(new IngestBoardEntity
                    {
                        FolioDatahub = row[0].ToString(),
                        IdTabla = row[1].ToString(),
                        TipoIngesta = row[12].ToString(),
                        QAñoSprintInicioIngesta = row[13].ToString(),
                        QAñoInicioIngesta = row[14].ToString(),
                        Scrum = row[15].ToString(),
                        NombreTablaRaw = row[16].ToString(),
                        NombreTablaMaster = row[17].ToString(),
                        NumeroCamposTabla = row[18].ToString(),
                        UUAARaw = row[28].ToString(),
                        UUAAMaster = row[29].ToString(),
                        RutaMaster = row[30].ToString(),
                        ReglaUsuarioIngesta = row[51].ToString()
                    });
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        public string obtenerHello()
        {
            return (20 * 5).ToString();
        }
    }
}
