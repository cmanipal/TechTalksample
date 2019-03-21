using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace jsonformat22
{


    [XmlRoot(ElementName = "submitted_param")]
    public class Submitted_param
    {
        [XmlElement(ElementName = "Extractor")]
        public string Extractor { get; set; }
        [XmlElement(ElementName = "TaxId")]
        public string TaxId { get; set; }
        [XmlElement(ElementName = "DefaultTaxYear")]
        public string DefaultTaxYear { get; set; }
        [XmlElement(ElementName = "SearchId")]
        public string SearchId { get; set; }
        [XmlElement(ElementName = "UserId")]
        public string UserId { get; set; }
        [XmlElement(ElementName = "Branch")]
        public string Branch { get; set; }
        [XmlElement(ElementName = "RequestedOn")]
        public string RequestedOn { get; set; }
        [XmlElement(ElementName = "Status")]
        public string Status { get; set; }
    }

    [XmlRoot(ElementName = "TaxName")]
    public class TaxName
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "TaxInstallment")]
    public class TaxInstallment
    {
        [XmlElement(ElementName = "TaxYear")]
        public string TaxYear { get; set; }
        [XmlElement(ElementName = "TaxType")]
        public string TaxType { get; set; }
        [XmlElement(ElementName = "Tax_Supplemental_APN")]
        public string Tax_Supplemental_APN { get; set; }
        [XmlElement(ElementName = "Status1")]
        public string Status1 { get; set; }
        [XmlElement(ElementName = "InstallmentAmt1")]
        public string InstallmentAmt1 { get; set; }
        [XmlElement(ElementName = "Interest1")]
        public string Interest1 { get; set; }
        [XmlElement(ElementName = "Penalty1")]
        public string Penalty1 { get; set; }
        [XmlElement(ElementName = "AmountDue1")]
        public string AmountDue1 { get; set; }
        [XmlElement(ElementName = "DatePaid1")]
        public string DatePaid1 { get; set; }
        [XmlElement(ElementName = "DelinquentDate1")]
        public string DelinquentDate1 { get; set; }
        [XmlElement(ElementName = "TotalTax1")]
        public string TotalTax1 { get; set; }
        [XmlElement(ElementName = "RedemptionDate1")]
        public string RedemptionDate1 { get; set; }
        [XmlElement(ElementName = "RedemptionAmount1")]
        public string RedemptionAmount1 { get; set; }
        [XmlElement(ElementName = "VolumeNo1")]
        public string VolumeNo1 { get; set; }
        [XmlElement(ElementName = "DueDate1")]
        public string DueDate1 { get; set; }
        [XmlElement(ElementName = "CertOfPurch1")]
        public string CertOfPurch1 { get; set; }
        [XmlElement(ElementName = "PmtGoodThrough1")]
        public string PmtGoodThrough1 { get; set; }
        [XmlElement(ElementName = "AssessmentDate1")]
        public string AssessmentDate1 { get; set; }
        [XmlElement(ElementName = "PartialPayAmt1")]
        public string PartialPayAmt1 { get; set; }
        [XmlElement(ElementName = "Status2")]
        public string Status2 { get; set; }
        [XmlElement(ElementName = "InstallmentAmt2")]
        public string InstallmentAmt2 { get; set; }
        [XmlElement(ElementName = "Interest2")]
        public string Interest2 { get; set; }
        [XmlElement(ElementName = "Penalty2")]
        public string Penalty2 { get; set; }
        [XmlElement(ElementName = "AmountDue2")]
        public string AmountDue2 { get; set; }
        [XmlElement(ElementName = "DatePaid2")]
        public string DatePaid2 { get; set; }
        [XmlElement(ElementName = "DelinquentDate2")]
        public string DelinquentDate2 { get; set; }
        [XmlElement(ElementName = "TotalTax2")]
        public string TotalTax2 { get; set; }
        [XmlElement(ElementName = "RedemptionDate2")]
        public string RedemptionDate2 { get; set; }
        [XmlElement(ElementName = "RedemptionAmount2")]
        public string RedemptionAmount2 { get; set; }
        [XmlElement(ElementName = "VolumeNo2")]
        public string VolumeNo2 { get; set; }
        [XmlElement(ElementName = "DueDate2")]
        public string DueDate2 { get; set; }
        [XmlElement(ElementName = "CertOfPurch2")]
        public string CertOfPurch2 { get; set; }
        [XmlElement(ElementName = "PmtGoodThrough2")]
        public string PmtGoodThrough2 { get; set; }
        [XmlElement(ElementName = "AssessmentDate2")]
        public string AssessmentDate2 { get; set; }
        [XmlElement(ElementName = "PartialPayAmt2")]
        public string PartialPayAmt2 { get; set; }
        [XmlElement(ElementName = "Status3")]
        public string Status3 { get; set; }
        [XmlElement(ElementName = "InstallmentAmt3")]
        public string InstallmentAmt3 { get; set; }
        [XmlElement(ElementName = "Interest3")]
        public string Interest3 { get; set; }
        [XmlElement(ElementName = "Penalty3")]
        public string Penalty3 { get; set; }
        [XmlElement(ElementName = "AmountDue3")]
        public string AmountDue3 { get; set; }
        [XmlElement(ElementName = "DatePaid3")]
        public string DatePaid3 { get; set; }
        [XmlElement(ElementName = "DelinquentDate3")]
        public string DelinquentDate3 { get; set; }
        [XmlElement(ElementName = "TotalTax3")]
        public string TotalTax3 { get; set; }
        [XmlElement(ElementName = "RedemptionDate3")]
        public string RedemptionDate3 { get; set; }
        [XmlElement(ElementName = "RedemptionAmount3")]
        public string RedemptionAmount3 { get; set; }
        [XmlElement(ElementName = "VolumeNo3")]
        public string VolumeNo3 { get; set; }
        [XmlElement(ElementName = "DueDate3")]
        public string DueDate3 { get; set; }
        [XmlElement(ElementName = "CertOfPurch3")]
        public string CertOfPurch3 { get; set; }
        [XmlElement(ElementName = "PmtGoodThrough3")]
        public string PmtGoodThrough3 { get; set; }
        [XmlElement(ElementName = "AssessmentDate3")]
        public string AssessmentDate3 { get; set; }
        [XmlElement(ElementName = "PartialPayAmt3")]
        public string PartialPayAmt3 { get; set; }
        [XmlElement(ElementName = "Status4")]
        public string Status4 { get; set; }
        [XmlElement(ElementName = "InstallmentAmt4")]
        public string InstallmentAmt4 { get; set; }
        [XmlElement(ElementName = "Interest4")]
        public string Interest4 { get; set; }
        [XmlElement(ElementName = "Penalty4")]
        public string Penalty4 { get; set; }
        [XmlElement(ElementName = "AmountDue4")]
        public string AmountDue4 { get; set; }
        [XmlElement(ElementName = "DatePaid4")]
        public string DatePaid4 { get; set; }
        [XmlElement(ElementName = "DelinquentDate4")]
        public string DelinquentDate4 { get; set; }
        [XmlElement(ElementName = "TotalTax4")]
        public string TotalTax4 { get; set; }
        [XmlElement(ElementName = "RedemptionDate4")]
        public string RedemptionDate4 { get; set; }
        [XmlElement(ElementName = "RedemptionAmount4")]
        public string RedemptionAmount4 { get; set; }
        [XmlElement(ElementName = "VolumeNo4")]
        public string VolumeNo4 { get; set; }
        [XmlElement(ElementName = "DueDate4")]
        public string DueDate4 { get; set; }
        [XmlElement(ElementName = "CertOfPurch4")]
        public string CertOfPurch4 { get; set; }
        [XmlElement(ElementName = "PmtGoodThrough4")]
        public string PmtGoodThrough4 { get; set; }
        [XmlElement(ElementName = "AssessmentDate4")]
        public string AssessmentDate4 { get; set; }
        [XmlElement(ElementName = "PartialPayAmt4")]
        public string PartialPayAmt4 { get; set; }
        [XmlElement(ElementName = "HOExempt")]
        public string HOExempt { get; set; }
        [XmlElement(ElementName = "AOExempt")]
        public string AOExempt { get; set; }
        [XmlElement(ElementName = "LandVal")]
        public string LandVal { get; set; }
        [XmlElement(ElementName = "ImpVal")]
        public string ImpVal { get; set; }
        [XmlElement(ElementName = "NetVal")]
        public string NetVal { get; set; }
        [XmlElement(ElementName = "PersPropVal")]
        public string PersPropVal { get; set; }
    }

    [XmlRoot(ElementName = "TaxDetails")]
    public class TaxDetails
    {
        [XmlElement(ElementName = "TaxInstallment")]
        public TaxInstallment TaxInstallment { get; set; }
    }

    [XmlRoot(ElementName = "TResultSet")]
    public class TResultSet
    {
        [XmlElement(ElementName = "ReportHeader")]
        public string ReportHeader { get; set; }
        [XmlElement(ElementName = "TaxReportStatus")]
        public string TaxReportStatus { get; set; }
        [XmlElement(ElementName = "TaxName")]
        public TaxName TaxName { get; set; }
        [XmlElement(ElementName = "Tax_APN")]
        public string Tax_APN { get; set; }
        [XmlElement(ElementName = "Tax_ID")]
        public string Tax_ID { get; set; }
        [XmlElement(ElementName = "Tax_BillNo")]
        public string Tax_BillNo { get; set; }
        [XmlElement(ElementName = "TRACode")]
        public string TRACode { get; set; }
        [XmlElement(ElementName = "TRAName")]
        public string TRAName { get; set; }
        [XmlElement(ElementName = "UseCode")]
        public string UseCode { get; set; }
        [XmlElement(ElementName = "TaxYear")]
        public string TaxYear { get; set; }
        [XmlElement(ElementName = "DelinquentTaxes")]
        public string DelinquentTaxes { get; set; }
        [XmlElement(ElementName = "SitusAddress")]
        public string SitusAddress { get; set; }
        [XmlElement(ElementName = "MailingAddress")]
        public string MailingAddress { get; set; }
        [XmlElement(ElementName = "Total_Due")]
        public string Total_Due { get; set; }
        [XmlElement(ElementName = "BriefLegalDescription")]
        public string BriefLegalDescription { get; set; }
        [XmlElement(ElementName = "DocNum")]
        public string DocNum { get; set; }
        [XmlElement(ElementName = "YearInstr")]
        public string YearInstr { get; set; }
        [XmlElement(ElementName = "BookNum")]
        public string BookNum { get; set; }
        [XmlElement(ElementName = "PageNum")]
        public string PageNum { get; set; }
        [XmlElement(ElementName = "RecordingDate")]
        public string RecordingDate { get; set; }
        [XmlElement(ElementName = "PropertyStatusInformation")]
        public string PropertyStatusInformation { get; set; }
        [XmlElement(ElementName = "TaxData")]
        public string TaxData { get; set; }
        [XmlElement(ElementName = "Tax_Assessor_Info")]
        public string Tax_Assessor_Info { get; set; }
        [XmlElement(ElementName = "DTDB_Property_Info")]
        public string DTDB_Property_Info { get; set; }
        [XmlElement(ElementName = "TaxDetails")]
        public TaxDetails TaxDetails { get; set; }
        [XmlElement(ElementName = "HOAData")]
        public string HOAData { get; set; }
        [XmlElement(ElementName = "SpecialAssessments")]
        public string SpecialAssessments { get; set; }
        [XmlElement(ElementName = "Bonds_Assessments")]
        public string Bonds_Assessments { get; set; }
        [XmlElement(ElementName = "DelqNotice")]
        public string DelqNotice { get; set; }
        [XmlElement(ElementName = "DistrictInfo")]
        public string DistrictInfo { get; set; }
        [XmlElement(ElementName = "SchoolDistrict")]
        public string SchoolDistrict { get; set; }
    }

    [XmlRoot(ElementName = "TaxReport")]
    public class TaxReport
    {
        [XmlElement(ElementName = "TResultSet")]
        public TResultSet TResultSet { get; set; }
    }

    [XmlRoot(ElementName = "datatrace")]
    public class Datatrace
    {
        [XmlElement(ElementName = "submitted_param")]
        public Submitted_param Submitted_param { get; set; }
        [XmlElement(ElementName = "Created")]
        public string Created { get; set; }
        [XmlElement(ElementName = "Error")]
        public string Error { get; set; }
        [XmlElement(ElementName = "TaxReport")]
        public TaxReport TaxReport { get; set; }
    }

}
