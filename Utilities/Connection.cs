using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Scalpy.Utilities
{
    public class Connection
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Scalpy";

        public static string ClientId = "YourIDClient";
        public static string ClientSecret = "YourSecretClient";

        public string credentialError = string.Empty;
        //public SheetsService service;

        public UserCredential GetUserCredential(out string error)
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
                Global.service = new SheetsService(new BaseClientService.Initializer()
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

        public IList<IList<object>> ReadSpreadsheet(string SpreadsheetId, string range)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    Global.service.Spreadsheets.Values.Get(SpreadsheetId, range);

            // Executing Read Operation...
            var response = request.Execute();

            // Getting all records from Column A to E...
            return response.Values;
        }
    }
}
