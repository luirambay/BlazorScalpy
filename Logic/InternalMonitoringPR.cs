using Entities;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Scalpy.Logic
{
    public class InternalMonitoringPR
    {
        static readonly string sheet = "Respuestas de formulario";

        static readonly string SpreadsheetId = "1eS94lxFcp5u51Fz9lR1qUBdCKXw34FqnxqVfD42y4IA";

        string credentialError = string.Empty;
        string refreshToken = string.Empty;

        static List<MonitoringPREntity> rowsMonitoringPR = new List<MonitoringPREntity>();

        public List<MonitoringPREntity> getDataMonitoringPR()
        {
            var connectionGSheets = new Utilities.Connection();

            if (rowsMonitoringPR.Count == 0)
            {
                UserCredential credential = connectionGSheets.GetUserCredential(out credentialError);

                if (credential != null && string.IsNullOrWhiteSpace(credentialError))
                {
                    refreshToken = credential.Token.RefreshToken;
                }

                readBUI();
            }
            else
            {
                rowsMonitoringPR.Clear();
                readBUI();
            }

            return rowsMonitoringPR;
        }

        static void readBUI()
        {
            var connection = new Utilities.Connection();

            var range = $"{sheet}!A2:AE";

            var values = connection.ReadSpreadsheet(SpreadsheetId, range);

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row.Count > 0)
                    {
                        if (row.Count < 31)
                        {
                            int dif = 31 - row.Count;

                            for (int i = 0; i < dif; i++)
                            {
                                row.Add("");
                            }
                        }
                    }

                    rowsMonitoringPR.Add(new MonitoringPREntity
                    {
                        FechaRegistro = row[0].ToString(),
                        NombreProyecto = row[2].ToString(),
                        NombreDeveloper = row[3].ToString(),
                        IDTabla = row[4].ToString(),
                        TipoDesarrollo = row[5].ToString(),
                        RutaBitbucket = row[8].ToString(),
                        TicketJIRA = row[10].ToString(),
                        NumeroQ = row[12].ToString(),
                        NumeroPR = row[13].ToString(),
                        LiderTecnicoDatahub = row[14].ToString(),
                        Estado = row[15].ToString(),
                        Revisores = row[16].ToString(),
                        Size = row[17].ToString(),
                        EstadoJIRA = row[30].ToString()
                    });
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
    }
}
