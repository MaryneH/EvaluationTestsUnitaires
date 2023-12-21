using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        [DataRow("Coucou", "<b>Coucou</b>")]
        [DataRow("Tests", "<b>Tests</b>")]
        public void GetBoldFormat_ReturnsCorrectFormat(string content, string expectedResult)
        {
            string result = _htmlFormatHelper.GetBoldFormat(content);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("Coucou", "<i>Coucou</i>")]
        [DataRow("Tests", "<i>Tests</i>")]
        public void GetItalicFormat_ReturnsCorrectFormat(string content, string expectedResult)
        {
            string result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual(expectedResult, result);
        }
    }
}