using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace jsonformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //string file = @"C:\DataTrace\title-response.json";

            //string Json = System.IO.File.ReadAllText(file);
            //dynamic results = JsonConvert.DeserializeObject<dynamic>(Json);
            //TitleLegals obj = new jsonformat.Form1.TitleLegals();
            //List<Legals> Legallist = new List<Legals>();
            //foreach (dynamic d in results)
            //{
            //    foreach (dynamic root in d)
            //    {
            //        if (root.Name == "PropertyLegal")
            //        {
            //            Legals t = new jsonformat.Form1.Legals();
            //            dynamic r = ((Newtonsoft.Json.Linq.JContainer)root).First;
            //            foreach (dynamic d1 in r)
            //            {
            //                if (d1.Name == "LegalType")
            //                {
            //                    t.PropertyType = d1.Value;
            //                }
            //                else if (d1.Name == "LegalDescription")
            //                {
            //                    t.PropertyTDesc = d1.Value;
            //                }
            //            }
            //            Legallist.Add(new Legals { PropertyType = t.PropertyType, PropertyTDesc = t.PropertyTDesc });
            //        }

            //    }
            //}
            //obj.TitleLegal = Legallist;

            //string file1 = @"C:\Datatrace\tax-instrument-response.xml";
            //string xml = System.IO.File.ReadAllText(file1);

            //XmlDocument objXmldoc = new XmlDocument();
            //objXmldoc.LoadXml(xml);
            //XmlNodeList objxmlNodeList = objXmldoc.SelectNodes(@"/datatrace/response/search_group/search_object/search_unit/title_report/title_rec/title_doc/property");
            //List<Legals> Instrumentlegals = new List<Legals>();
            //foreach (XmlNode responseXML in objxmlNodeList)
            //{
            //    string Type = responseXML.SelectSingleNode("property_legal") != null ? responseXML.SelectSingleNode("property_legal/@type").Value : "";
            //    string Book = responseXML.SelectSingleNode("property_legal/plat/book_page/book") != null ? responseXML.SelectSingleNode("property_legal/plat/book_page/book").InnerText : "";
            //    string Page = responseXML.SelectSingleNode("property_legal/plat/book_page/page") != null ? responseXML.SelectSingleNode("property_legal/plat/book_page/page").InnerText : "";
            //    string lot = responseXML.SelectSingleNode("property_legal/lot") != null ? responseXML.SelectSingleNode("property_legal/lot").InnerText : "";
            //    Instrumentlegals.Add(new Legals { PropertyType = Type, PropertyTDesc = "Book:" + Book + " Page:" + Page + " Lot: " + lot });
            //}
            //obj.InstrumentLegal = Instrumentlegals;
            //var requestJson = JsonConvert.SerializeObject(obj);
            //DTDBCall();
        }

        private string GetDTDBAddress(String strAPN, String strStreet, String strZip, String strCity, String strState, String strCounty, Boolean blnTransHist)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            string str_C2DAccountIdentifier = "TIQ";
            string str_C2DAccountPassword = "QQBcwmdyL";

            sb.Append("<REQUEST_GROUP MISMOVersionID=\"2.1\">");
            sb.Append(string.Format("<REQUEST _JobIdentifier=\"Test\" _RequestDateTime=\"20040101\" InternalAccountIdentifier=\"0\" LoginAccountIdentifier=\"{0}\" LoginAccountPassword=\"{1}\" _HVERequestType=\"02\">", str_C2DAccountIdentifier, str_C2DAccountPassword));
            sb.Append("<REQUESTDATA>");
            sb.Append("<PROPERTY_INFORMATION_REQUEST _ActionType=\"Submit\">");
            if (!blnTransHist)
                sb.Append("<_CONNECT2DATA_PRODUCT _ShortSubjectReport=\"Y\" _StatewideOwnerSearch=\"N\" _IncludePendingRecordsIndicator=\"Y\" _ExtendAddressSuggestSearch=\"Y\" /> ");
            else
                sb.Append("<_CONNECT2DATA_PRODUCT _InstantTransactionHistory=\"Y\" _StatewideOwnerSearch=\"N\" _IncludePendingRecordsIndicator=\"N\" /> ");
            sb.Append(string.Format("<_PROPERTY_CRITERIA _StreetAddress=\"{0}\" _City=\"{1}\" _State=\"{2}\" _County=\"{3}\" _PostalCode=\"{4}\" _LastSalePriceAmount=\"\" _LastSaleDate=\"\">", strStreet, strCity, strState, strCounty, strZip));
            sb.Append("<PARSED_STREET_ADDRESS _ApartmentOrUnit=\"\" /> ");
            sb.Append("<_LAND_USE _SameAsSubjectType=\"Yes\" />");
            sb.Append("</_PROPERTY_CRITERIA>");
            sb.Append("<_SEARCH_CRITERIA>");
            sb.Append(string.Format("<_SUBJECT_SEARCH _AssessorsParcelIdentifier=\"{0}\" _OwnerFirstName=\"\" _OwnerLastName=\"\" /> ", strAPN));
            sb.Append("<_COMPARABLE_SEARCH>");
            sb.Append("<_LAND_USE />");
            sb.Append("</_COMPARABLE_SEARCH>");
            sb.Append("<_DOCUMENT_SEARCH /> ");
            sb.Append("</_SEARCH_CRITERIA>");
            sb.Append("<_RESPONSE_CRITERIA _NumberSubjectPropertiesType=\"100\" /> ");
            sb.Append("</PROPERTY_INFORMATION_REQUEST>");
            sb.Append("</REQUESTDATA>");
            sb.Append("</REQUEST>");
            sb.Append("</REQUEST_GROUP>");

            return sb.ToString();
        }
        private string DTDBCall()
        {
            string str_C2DCheckAddressUrl = "http://dbs.datatree.com/dtdbxml/service/";
            System.Net.HttpWebRequest httpRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(str_C2DCheckAddressUrl);
            string strQuery = GetDTDBAddress("4206-006-022", "", "", "", "CA", "Los Angeles", true);

            byte[] reqPostBuffer = System.Text.Encoding.UTF8.GetBytes(strQuery);

            httpRequest.Method = "POST";
            httpRequest.ContentType = "text/xml";
            httpRequest.ContentLength = reqPostBuffer.Length;

            System.IO.Stream reqPostData = httpRequest.GetRequestStream();
            reqPostData.Write(reqPostBuffer, 0, reqPostBuffer.Length);
            reqPostData.Close();

            System.IO.StreamReader streamReader = new System.IO.StreamReader(httpRequest.GetResponse().GetResponseStream());
            string strResponse = streamReader.ReadToEnd();
            System.Xml.XmlDocument xmlforNameCollection = new System.Xml.XmlDocument();
            xmlforNameCollection.XmlResolver = null;
            xmlforNameCollection.LoadXml(strResponse);
            System.Xml.XmlNodeList propertyInformation = xmlforNameCollection.GetElementsByTagName("_TRANSACTION_HISTORY");
            //string Instrument = propertyInformation[0].Attributes["_FormattedSaleDocumentNumberIdentifier"].Value;
            //string[] Instrumentvalues = Instrument.Split('.');
            //string Instrumentresult = InstrumentRequest(Instrumentvalues[0].ToString(), Instrumentvalues[1].ToString());
            return null;
        }
        public class TitleLegals
        {
            public List<Legals> TitleLegal { get; set; }
            public List<Legals> InstrumentLegal { get; set; }
        }
        public class Legals
        {
            [JsonProperty("PropertyType")]
            public string PropertyType { get; set; }

            [JsonProperty("PropertyTDesc")]
            public string PropertyTDesc { get; set; }
        }

        public class Serializer
        {
            public T Deserialize<T>(string input) where T : class
            {
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

                using (StringReader sr = new StringReader(input))
                {
                    return (T)ser.Deserialize(sr);
                }
            }

            public string Serialize<T>(T ObjectToSerialize)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                    return textWriter.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaxReport taxReport = new jsonformat.TaxReport();
            TaxInstallment inst = new jsonformat.TaxInstallment();
            TResultSet result = new TResultSet();

            string x = System.IO.File.ReadAllText(@"C:\Examples\AMADOR_TC.xml").Replace("xmlns=\"http://schemas.datacontract.org/2004/07/Objects.Transport.TPA\"", "");
            //Replace("UTF-16", "UTF-8").Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:application=\"TIQ\" xmlns:Version=\"0.1\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "").Replace("xsi:nil=\"true\"", "");

            //Serializer ser = new Serializer();
            //TaxReport Tax = ser.Deserialize<TaxReport>(x);
            //string xmlOutputData = ser.Serialize<TaxReport>(Tax);

            XmlDocument objXmldoc = new XmlDocument();

            objXmldoc.LoadXml(x);

            XmlNodeList objxmlNodeList = objXmldoc.SelectNodes(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment");
            //var req = responseXML.Descendants("datatrace").Descendants("TaxReport").Descendants("TaxDetails").Descendants("TaxInstallment");
            result.ReportHeader = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/ReportHeader").InnerText;
            result.TaxReportStatus = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxReportStatus").InnerText;

            TaxName name = new TaxName();
            name.Name = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxName/Name").InnerText;
            result.TaxName = new List<jsonformat.TaxName>();
            result.TaxName.Add(name);

            result.Tax_APN = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/Tax_APN").InnerText;
            result.Tax_ID = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/Tax_ID").InnerText;
            result.Tax_BillNo = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/Tax_BillNo").InnerText;
            result.TRACode = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TRACode").InnerText;
            result.TRAName = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TRAName").InnerText;
            result.UseCode = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/UseCode").InnerText;
            result.TaxYear = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxYear").InnerText;
            result.DelinquentTaxes = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/DelinquentTaxes").InnerText;
            result.SitusAddress = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/SitusAddress").InnerText;
            result.MailingAddress = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/MailingAddress").InnerText;
            result.Total_Due = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/Total_Due").InnerText;
            result.BriefLegalDescription = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/BriefLegalDescription").InnerText;
            result.DocNum = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/DocNum").InnerText;
            result.YearInstr = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/YearInstr").InnerText;
            result.BookNum = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/BookNum").InnerText;
            result.PageNum = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/PageNum").InnerText;
            result.RecordingDate = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/RecordingDate").InnerText;
            result.PropertyStatusInformation = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/PropertyStatusInformation").InnerText;
            result.TaxData = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxData").InnerText;

            result.Tax_Assessor_Info = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/Tax_Assessor_Info").InnerText;
            result.DTDB_Property_Info = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/DTDB_Property_Info").InnerText;
            result.HOAData = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/HOAData").InnerText;
            result.SpecialAssessments = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/SpecialAssessments").InnerText;
            result.Bonds_Assessments = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/Bonds_Assessments").InnerText;
            result.DelqNotice = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/DelqNotice").InnerText;
            result.DistrictInfo = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/DistrictInfo").InnerText;
            result.SchoolDistrict = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/SchoolDistrict").InnerText;


            inst.TaxYear = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/TaxYear").InnerText;
            inst.TaxType = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/TaxType").InnerText;
            inst.Tax_Supplemental_APN = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Tax_Supplemental_APN").InnerText;


            inst.Status1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Status1").InnerText;
            inst.InstallmentAmt1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/InstallmentAmt1").InnerText;
            inst.Interest1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Interest1").InnerText;
            inst.Penalty1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Penalty1").InnerText;
            inst.AmountDue1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AmountDue1").InnerText;
            inst.DatePaid1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DatePaid1").InnerText;
            inst.TotalTax1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/TotalTax1").InnerText;
            inst.RedemptionDate1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionDate1").InnerText;
            inst.RedemptionAmount1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionAmount1").InnerText;
            inst.VolumeNo1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/VolumeNo1").InnerText;
            inst.DueDate1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DueDate1").InnerText;
            inst.CertOfPurch1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/CertOfPurch1").InnerText;
            inst.PmtGoodThrough1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PmtGoodThrough1").InnerText;
            inst.AssessmentDate1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AssessmentDate1").InnerText;
            inst.PartialPayAmt1 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PartialPayAmt1").InnerText;
            inst.Status2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Status2").InnerText;
            inst.InstallmentAmt2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/InstallmentAmt2").InnerText;
            inst.Interest2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Interest2").InnerText;
            inst.Penalty2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Penalty2").InnerText;
            inst.AmountDue2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AmountDue2").InnerText;
            inst.DatePaid2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DatePaid2").InnerText;
            inst.TotalTax2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/TotalTax2").InnerText;

            inst.RedemptionDate2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionDate2").InnerText;
            inst.RedemptionAmount2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionAmount2").InnerText;
            inst.VolumeNo2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/VolumeNo2").InnerText;
            inst.DueDate2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DueDate2").InnerText;
            inst.CertOfPurch2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/CertOfPurch2").InnerText;
            inst.PmtGoodThrough2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PmtGoodThrough2").InnerText;
            inst.AssessmentDate2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AssessmentDate2").InnerText;
            inst.PartialPayAmt2 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PartialPayAmt2").InnerText;
            inst.Status3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Status3").InnerText;
            inst.InstallmentAmt3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/InstallmentAmt3").InnerText;
            inst.VolumeNo3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/VolumeNo3").InnerText;
            inst.RedemptionAmount3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionAmount3").InnerText;
            inst.RedemptionDate3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionDate3").InnerText;
            inst.TotalTax3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/TotalTax3").InnerText;
            inst.DelinquentDate3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DelinquentDate3").InnerText;
            inst.DatePaid3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DatePaid3").InnerText;
            inst.AmountDue3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AmountDue3").InnerText;
            inst.Penalty3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Penalty3").InnerText;
            inst.Interest3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Interest3").InnerText;
            inst.PartialPayAmt3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PartialPayAmt3").InnerText;
            inst.AssessmentDate3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AssessmentDate3").InnerText;
            inst.PmtGoodThrough3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PmtGoodThrough3").InnerText;
            inst.CertOfPurch3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/CertOfPurch3").InnerText;
            inst.DueDate3 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DueDate3").InnerText;
            inst.VolumeNo4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/VolumeNo4").InnerText;
            inst.RedemptionAmount4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionAmount4").InnerText;
            inst.RedemptionDate4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/RedemptionDate4").InnerText;
            inst.TotalTax4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/TotalTax4").InnerText;
            inst.DelinquentDate4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DelinquentDate4").InnerText;
            inst.DatePaid4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DatePaid4").InnerText;
            inst.AmountDue4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AmountDue4").InnerText;
            inst.Penalty4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Penalty4").InnerText;
            inst.Interest4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Interest4").InnerText;
            inst.InstallmentAmt4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/InstallmentAmt4").InnerText;
            inst.Status4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/Status4").InnerText;
            inst.PersPropVal = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PersPropVal").InnerText;
            inst.NetVal = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/NetVal").InnerText;
            inst.ImpVal = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/ImpVal").InnerText;
            inst.LandVal = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/LandVal").InnerText;
            inst.AOExempt = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AOExempt").InnerText;
            inst.HOExempt = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/HOExempt").InnerText;
            inst.PartialPayAmt4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PartialPayAmt4").InnerText;
            inst.AssessmentDate4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/AssessmentDate4").InnerText;
            inst.PmtGoodThrough4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/PmtGoodThrough4").InnerText;
            inst.CertOfPurch4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/CertOfPurch4").InnerText;
            inst.DueDate4 = objXmldoc.SelectSingleNode(@"datatrace/TaxReport/TResultSet/TaxDetails/TaxInstallment/DueDate4").InnerText;
            taxReport.TResultSet = result;
            TaxDetail details = new TaxDetail();
            result.TaxDetail = new jsonformat.TaxDetail();
            details.TaxInstallment = new List<TaxInstallment>();

            details.TaxInstallment.Add(inst);
            taxReport.TResultSet.TaxDetail = details;
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(TaxReport));
            serializer.Serialize(stringwriter, taxReport);
            string finalresult = stringwriter.ToString();
        }
    }

}
