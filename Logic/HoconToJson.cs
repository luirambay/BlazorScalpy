using Hocon;
using Hocon.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scalpy.Logic
{
    public class HoconToJson
    {
        IDictionary<string, string> attributeCode = new Dictionary<string, string>();
        string spreedsheetId = "1axexxSserxmBHquH_SX8n2lEZyAhrhS4"; //Id de Data Sophia

        dynamic convertHoconToJson(string text)
        {
            var config = HoconParser.Parse(text);
            var json = config.ToJToken().ToString();

            return JsonConvert.DeserializeObject(json);            
        }

        void readGSheetSophia()
        {

        }

        public IDictionary<string, string> validationKirby(string text)
        {
            dynamic jsonData = convertHoconToJson(text);

            string input = jsonData.kirby.input.type;
            string output = jsonData.kirby.output.type;

            string inputType = input.ToLower();
            string outputType = output.ToLower();

            //string resultado = "";

            //Validation A: Input Fixed - Output Avro
            if (inputType == "fixed" && outputType == "avro")
            {
                //resultado = "Input: fixed - Output: avro";

                //INPUT

                //options
                string optionsInput = (jsonData.kirby.input.options != null) ? "true" : "false";
                attributeCode.Add("optionsInput", optionsInput);

                //castMode
                string castMode = jsonData.kirby.input.options.castMode;

                if (castMode == null)
                {
                    attributeCode.Add("castMode", "null");
                }
                else if (castMode == "notPermissive")
                {
                    attributeCode.Add("castMode", "true");
                }
                else
                {
                    attributeCode.Add("castMode", "false");
                }

                //mode
                string mode = jsonData.kirby.input.options.mode;

                if (mode.ToLower() == null)
                {
                    attributeCode.Add("mode", "null");
                }
                else if (mode.ToLower() == "failfast")
                {
                    attributeCode.Add("mode", "true");
                }
                else
                {
                    attributeCode.Add("mode", "false");
                }

                //charset
                string charsetValue = jsonData.kirby.input.options.charset;
                string[] charsetList = { "windows-1252", "" };

                if (charsetValue != "null")
                {
                    string charset = (charsetList.Contains(charsetValue)) ? "true" : "false";
                    attributeCode.Add("charset", charset);
                }

                //paths: SE REUTILIZARÁ

                //schema: SE REUTILIZARÁ

                //type
                attributeCode.Add("inputType", "true");

                //OUTPUT (Se repite con el de Output Parquet)

                ////mode
                //string modeX = (jsonData.kirby.output.mode == "reprocess") ? "true" : "false";
                //attributeCode.Add("mode", mode);

                ////options
                //string optionsOutput = (jsonData.kirby.output.options == null) ? "true" : "false";
                //attributeCode.Add("optionsOutput", optionsOutput);

                ////partition
                //string sophiaPartition = "Reemplazar";
                //string partition = (jsonData.kirby.output.partition[0] == sophiaPartition) ? "true" : "false";

                //attributeCode.Add("partition", partition);

                ////reprocess
                ////string sophiaPartition = "Reemplazar";
                //string reprocess = (jsonData.kirby.output.reprocess[0] == sophiaPartition + "=") ? "true" : "false";

                //attributeCode.Add("reprocess", reprocess);

                ////path
                //string sophiaOutputPath = "Reemplazar";
                //string outputPath = (jsonData.kirby.output.path[0] == sophiaOutputPath) ? "true" : "false";

                //attributeCode.Add("outputPath", outputPath);

                ////schema
                ////string schemaBasePath = "${repository.endpoint}/${schemas.repo}/${schemas.base-path}";
                //string ttt = "" + "";

                //string schemaOutputPath = (jsonData.kirby.output.schema.path == ttt) ? "true" : "false";
                //attributeCode.Add("schemaOutputPath", schemaOutputPath);

                ////type
                //attributeCode.Add("outputType", "true");
            }

            //Validation B: Input CSV - Output Avro
            if (true)
            {

            }

            //Validation C: Input Avro - Output Parquet
            if (inputType == "avro" && outputType == "parquet")
            {
                //INPUT

                //applyConversions
                string applyConversions = jsonData.kirby.input.applyConversions;

                if (applyConversions.ToLower() == "false")
                {
                    attributeCode.Add("applyConversions", "true");
                }
                else if (applyConversions.ToLower() == "true")
                {
                    attributeCode.Add("applyConversions", "false");
                }
                else
                {
                    attributeCode.Add("applyConversions", "null");
                }

                //options
                string optionsInput = (jsonData.kirby.input.options == null) ? "true" : "false";
                attributeCode.Add("optionsInput", optionsInput);

                //paths
                string sophiaInputPath = "Reemplazar";
                string inputPath = (jsonData.kirby.input.paths[0] == sophiaInputPath) ? "true" : "false";

                attributeCode.Add("inputPath", inputPath);

                //schema
                string schemaBasePath = "${repository.endpoint}/${schemas.repo}/${schemas.base-path}";
                string yyy = schemaBasePath + "";

                string schemaInputPath = (jsonData.kirby.input.schema.path == yyy) ? "true" : "false";
                attributeCode.Add("schemaInputPath", schemaInputPath);

                //type
                attributeCode.Add("inputType", "true");

                //OUTPUT

                //mode
                string mode = (jsonData.kirby.output.mode == "reprocess") ? "true" : "false";
                attributeCode.Add("mode", mode);

                //options
                string optionsOutput = (jsonData.kirby.output.options == null) ? "true" : "false";
                attributeCode.Add("optionsOutput", optionsOutput);

                //partition
                string sophiaPartition = "Reemplazar";
                string partition = (jsonData.kirby.output.partition[0] == sophiaPartition) ? "true" : "false";

                attributeCode.Add("partition", partition);

                //reprocess
                //string sophiaPartition = "Reemplazar";
                string reprocess = (jsonData.kirby.output.reprocess[0] == sophiaPartition + "=") ? "true" : "false";

                attributeCode.Add("reprocess", reprocess);

                //path
                string sophiaOutputPath = "Reemplazar";
                string outputPath = (jsonData.kirby.output.path[0] == sophiaOutputPath) ? "true" : "false";

                attributeCode.Add("outputPath", outputPath);

                //schema
                //string schemaBasePath = "${repository.endpoint}/${schemas.repo}/${schemas.base-path}";
                string ttt = schemaBasePath + "";

                string schemaOutputPath = (jsonData.kirby.output.schema.path == ttt) ? "true" : "false";
                attributeCode.Add("schemaOutputPath", schemaOutputPath);

                //type
                attributeCode.Add("outputType", "true");
            }

            //Validation D: Input Avro - Output Avro
            if (true)
            {

            }

            //Validation E: Input Parquet - Output CSV
            if (true)
            {

            }

            //return resultado;
            return attributeCode;
        }
    }
}
