using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FOSSTRAK.TDT;

namespace FOSSTRAK.TDT.Tests
{
    /// <summary>
    /// Tests for the TDTEngine
    /// </summary>
    /// <remarks>Author Mike Lohmeier</remarks>
    [TestClass]
    public class TDTEngineUnitTests
    {
        
        // http://stackoverflow.com/questions/227545/how-can-i-get-copy-to-output-directory-to-work-with-unit-tests
        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("SGTIN application identifier (AI) to Binary")]
        public void Page29SGTIN()
        {
            TDTEngine engine = new TDTEngine();
            List<KeyValuePair<String, String>> inputParameters = new List<KeyValuePair<String, String>>();
            inputParameters.Add(new KeyValuePair<string, string>("taglength", "96"));               // Binary requiredFormattingParameter
            inputParameters.Add(new KeyValuePair<string, string>("filter", "3"));                   // Binary requiredFormattingParamter
            inputParameters.Add(new KeyValuePair<string, string>("gs1companyprefixlength", "7"));   // AI requiredParsingParamter
            String original = "gtin=00037000302414;serial=1041970";
            String result = engine.Translate(original, inputParameters, LevelTypeList.BINARY);
            Assert.AreEqual(result, "001100000111010000000010010000100010000000011101100010000100000000000000000011111110011000110010");
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("SSCC application identifier (AI) to binary")]
        public void Page29SSCC()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("SGLN application identifier (AI) to binary")]
        public void Page29SGLN()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("GRAI application identifier (AI) to binary")]
        public void Page29GRAI()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("GIAI application identifier (AI) to binary")]
        public void Page29GIAI()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("GSRN application identifier (AI) to binary")]
        public void Page29GSRN()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("GDTI application identifier (AI) to binary")]
        public void Page29GDTI()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("GID application identifier (AI) to binary")]
        public void Page29SGID()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("USDOD application identifier (AI) to binary")]
        public void Page29USDOD()
        {
            Assert.Fail();
        }

        [TestMethod]
        [DeploymentItem("Resources", "Resources")]
        [Description("ADI application identifier (AI) to binary")]
        public void Page29ADI()
        {
            TDTEngine engine = new TDTEngine();
            List<KeyValuePair<String, String>> inputParameters = new List<KeyValuePair<String, String>>();
            inputParameters.Add(new KeyValuePair<string, string>("taglength", "96"));               // Binary requiredFormattingParameter
            inputParameters.Add(new KeyValuePair<string, string>("filter", "20"));                   // Binary requiredFormattingParamter
            String epc_pure_identity = "urn:epc:id:adi:15860.512-010-415-101.NH44";

            List<KeyValuePair<LevelTypeList, String>> encodings = new List<KeyValuePair<LevelTypeList, string>>();

            string encoded;
            foreach (LevelTypeList encodingType in Enum.GetValues(typeof(LevelTypeList)))
            {
                try
                {
                    encoded = engine.Translate(epc_pure_identity, inputParameters, encodingType);
                   
                }
                catch (Exception e)
                {
                    encoded = e.Message;
                }
                encodings.Add(new KeyValuePair<LevelTypeList, string>(encodingType, encoded));
            }

            
            String binary = engine.Translate(epc_pure_identity, inputParameters, LevelTypeList.BINARY);
            string hexString = engine.BinaryToString(binary, 9);

            inputParameters.Clear();
            String epc_tag_uri = engine.Translate(binary, inputParameters, LevelTypeList.TAG_ENCODING);


            Assert.AreEqual(binary, "00111011010100100000110001110101111000110110110000110101110001110010101101110000110001110000101101110100110001110101101101110001110000110001000000001110001000110100110100000000");
            Assert.AreEqual(epc_tag_uri, "urn:epc:tag:adi-var:20.15860.512-010-415-101.NH44");
            Assert.AreEqual(hexString, "3B520C75E36C35C72B70C70B74C75B71C3100E234D00");

        }
       
    }
}
