using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jsonformat
{


    public class TaxReport
    {
        public TResultSet TResultSet;


    }
    public class TResultSet
    {
        public string ReportHeader;
        public string TaxReportStatus;
        public List<TaxName> TaxName;
        public string Tax_APN;
        public string Tax_ID;
        public string Tax_BillNo;
        public string TRACode;
        public string TRAName;
        public string UseCode;
        public string TaxYear;
        public string DelinquentTaxes;
        public string SitusAddress;
        public string MailingAddress;
        public string Total_Due;
        public string BriefLegalDescription;
        public string DocNum;
        public string YearInstr;
        public string BookNum;
        public string PageNum;
        public string RecordingDate;
        public string PropertyStatusInformation;
        public string TaxData;
        public string Tax_Assessor_Info;
        public string DTDB_Property_Info;
        public TaxDetail TaxDetail;
        public string HOAData;
        public string SpecialAssessments;
        public string Bonds_Assessments;
        public string DelqNotice;
        public string DistrictInfo;
        public string SchoolDistrict;
    }
    public class TaxName
    {
        public string Name;
    }
    public class TaxDetail
    {
        public List<TaxInstallment> TaxInstallment;
    }


    public class TaxInstallment
    {

        private string _TaxYear;
        private string _TaxType;
        private string _Tax_Supplemental_APN;

        private string _Status1;
        private string _InstallmentAmt1;
        private string _Interest1;
        private string _Penalty1;
        private string _AmountDue1;
        private string _DatePaid1;
        private string _DelinquentDate1;
        private string _TotalTax1;
        private string _RedemptionDate1;
        private string _RedemptionAmount1;
        private string _VolumeNo1;
        private string _DueDate1;
        private string _CertOfPurch1;
        private string _PmtGoodThrough1;
        private string _AssessmentDate1;
        private string _PartialPayAmt1;

        private string _Status2;
        private string _InstallmentAmt2;
        private string _Interest2;
        private string _Penalty2;
        private string _AmountDue2;
        private string _DatePaid2;
        private string _DelinquentDate2;
        private string _TotalTax2;
        private string _RedemptionDate2;
        private string _RedemptionAmount2;
        private string _VolumeNo2;
        private string _DueDate2;
        private string _CertOfPurch2;
        private string _PmtGoodThrough2;
        private string _AssessmentDate2;
        private string _PartialPayAmt2;

        private string _Status3;
        private string _InstallmentAmt3;
        private string _Interest3;
        private string _Penalty3;
        private string _AmountDue3;
        private string _DatePaid3;
        private string _DelinquentDate3;
        private string _TotalTax3;
        private string _RedemptionDate3;
        private string _RedemptionAmount3;
        private string _VolumeNo3;
        private string _DueDate3;
        private string _CertOfPurch3;
        private string _PmtGoodThrough3;
        private string _AssessmentDate3;
        private string _PartialPayAmt3;

        private string _Status4;
        private string _InstallmentAmt4;
        private string _Interest4;
        private string _Penalty4;
        private string _AmountDue4;
        private string _DatePaid4;
        private string _DelinquentDate4;
        private string _TotalTax4;
        private string _RedemptionDate4;
        private string _RedemptionAmount4;
        private string _VolumeNo4;
        private string _DueDate4;
        private string _CertOfPurch4;
        private string _PmtGoodThrough4;
        private string _AssessmentDate4;
        private string _PartialPayAmt4;

        private string _HOExempt;
        private string _AOExempt;
        private string _LandVal;
        private string _ImpVal;
        private string _NetVal;
        private string _PersPropVal;

        public string TaxYear
        {
            get
            {
                return _TaxYear;
            }

            set
            {
                _TaxYear = value;
            }
        }

        public string TaxType
        {
            get
            {
                return _TaxType;
            }

            set
            {
                _TaxType = value;
            }
        }

        public string Tax_Supplemental_APN
        {
            get
            {
                return _Tax_Supplemental_APN;
            }

            set
            {
                _Tax_Supplemental_APN = value;
            }
        }

        public string Status1
        {
            get
            {
                return _Status1;
            }

            set
            {
                _Status1 = value;
            }
        }

        public string InstallmentAmt1
        {
            get
            {
                return _InstallmentAmt1;
            }

            set
            {
                _InstallmentAmt1 = value;
            }
        }

        public string Interest1
        {
            get
            {
                return _Interest1;
            }

            set
            {
                _Interest1 = value;
            }
        }

        public string Penalty1
        {
            get
            {
                return _Penalty1;
            }

            set
            {
                _Penalty1 = value;
            }
        }

        public string AmountDue1
        {
            get
            {
                return _AmountDue1;
            }

            set
            {
                _AmountDue1 = value;
            }
        }

        public string DatePaid1
        {
            get
            {
                return _DatePaid1;
            }

            set
            {
                _DatePaid1 = value;
            }
        }

        public string DelinquentDate1
        {
            get
            {
                return _DelinquentDate1;
            }

            set
            {
                _DelinquentDate1 = value;
            }
        }

        public string TotalTax1
        {
            get
            {
                return _TotalTax1;
            }

            set
            {
                _TotalTax1 = value;
            }
        }

        public string RedemptionDate1
        {
            get
            {
                return _RedemptionDate1;
            }

            set
            {
                _RedemptionDate1 = value;
            }
        }

        public string RedemptionAmount1
        {
            get
            {
                return _RedemptionAmount1;
            }

            set
            {
                _RedemptionAmount1 = value;
            }
        }

        public string VolumeNo1
        {
            get
            {
                return _VolumeNo1;
            }

            set
            {
                _VolumeNo1 = value;
            }
        }

        public string DueDate1
        {
            get
            {
                return _DueDate1;
            }

            set
            {
                _DueDate1 = value;
            }
        }

        public string CertOfPurch1
        {
            get
            {
                return _CertOfPurch1;
            }

            set
            {
                _CertOfPurch1 = value;
            }
        }

        public string PmtGoodThrough1
        {
            get
            {
                return _PmtGoodThrough1;
            }

            set
            {
                _PmtGoodThrough1 = value;
            }
        }

        public string AssessmentDate1
        {
            get
            {
                return _AssessmentDate1;
            }

            set
            {
                _AssessmentDate1 = value;
            }
        }

        public string PartialPayAmt1
        {
            get
            {
                return _PartialPayAmt1;
            }

            set
            {
                _PartialPayAmt1 = value;
            }
        }

        public string Status2
        {
            get
            {
                return _Status2;
            }

            set
            {
                _Status2 = value;
            }
        }

        public string InstallmentAmt2
        {
            get
            {
                return _InstallmentAmt2;
            }

            set
            {
                _InstallmentAmt2 = value;
            }
        }

        public string Interest2
        {
            get
            {
                return _Interest2;
            }

            set
            {
                _Interest2 = value;
            }
        }

        public string Penalty2
        {
            get
            {
                return _Penalty2;
            }

            set
            {
                _Penalty2 = value;
            }
        }

        public string AmountDue2
        {
            get
            {
                return _AmountDue2;
            }

            set
            {
                _AmountDue2 = value;
            }
        }

        public string DatePaid2
        {
            get
            {
                return _DatePaid2;
            }

            set
            {
                _DatePaid2 = value;
            }
        }

        public string DelinquentDate2
        {
            get
            {
                return _DelinquentDate2;
            }

            set
            {
                _DelinquentDate2 = value;
            }
        }

        public string TotalTax2
        {
            get
            {
                return _TotalTax2;
            }

            set
            {
                _TotalTax2 = value;
            }
        }

        public string RedemptionDate2
        {
            get
            {
                return _RedemptionDate2;
            }

            set
            {
                _RedemptionDate2 = value;
            }
        }

        public string RedemptionAmount2
        {
            get
            {
                return _RedemptionAmount2;
            }

            set
            {
                _RedemptionAmount2 = value;
            }
        }

        public string VolumeNo2
        {
            get
            {
                return _VolumeNo2;
            }

            set
            {
                _VolumeNo2 = value;
            }
        }

        public string DueDate2
        {
            get
            {
                return _DueDate2;
            }

            set
            {
                _DueDate2 = value;
            }
        }

        public string CertOfPurch2
        {
            get
            {
                return _CertOfPurch2;
            }

            set
            {
                _CertOfPurch2 = value;
            }
        }

        public string PmtGoodThrough2
        {
            get
            {
                return _PmtGoodThrough2;
            }

            set
            {
                _PmtGoodThrough2 = value;
            }
        }

        public string AssessmentDate2
        {
            get
            {
                return _AssessmentDate2;
            }

            set
            {
                _AssessmentDate2 = value;
            }
        }

        public string PartialPayAmt2
        {
            get
            {
                return _PartialPayAmt2;
            }

            set
            {
                _PartialPayAmt2 = value;
            }
        }

        public string Status3
        {
            get
            {
                return _Status3;
            }

            set
            {
                _Status3 = value;
            }
        }

        public string InstallmentAmt3
        {
            get
            {
                return _InstallmentAmt3;
            }

            set
            {
                _InstallmentAmt3 = value;
            }
        }

        public string Interest3
        {
            get
            {
                return _Interest3;
            }

            set
            {
                _Interest3 = value;
            }
        }

        public string Penalty3
        {
            get
            {
                return _Penalty3;
            }

            set
            {
                _Penalty3 = value;
            }
        }

        public string AmountDue3
        {
            get
            {
                return _AmountDue3;
            }

            set
            {
                _AmountDue3 = value;
            }
        }

        public string DatePaid3
        {
            get
            {
                return _DatePaid3;
            }

            set
            {
                _DatePaid3 = value;
            }
        }

        public string DelinquentDate3
        {
            get
            {
                return _DelinquentDate3;
            }

            set
            {
                _DelinquentDate3 = value;
            }
        }

        public string TotalTax3
        {
            get
            {
                return _TotalTax3;
            }

            set
            {
                _TotalTax3 = value;
            }
        }

        public string RedemptionDate3
        {
            get
            {
                return _RedemptionDate3;
            }

            set
            {
                _RedemptionDate3 = value;
            }
        }

        public string RedemptionAmount3
        {
            get
            {
                return _RedemptionAmount3;
            }

            set
            {
                _RedemptionAmount3 = value;
            }
        }

        public string VolumeNo3
        {
            get
            {
                return _VolumeNo3;
            }

            set
            {
                _VolumeNo3 = value;
            }
        }

        public string DueDate3
        {
            get
            {
                return _DueDate3;
            }

            set
            {
                _DueDate3 = value;
            }
        }

        public string CertOfPurch3
        {
            get
            {
                return _CertOfPurch3;
            }

            set
            {
                _CertOfPurch3 = value;
            }
        }

        public string PmtGoodThrough3
        {
            get
            {
                return _PmtGoodThrough3;
            }

            set
            {
                _PmtGoodThrough3 = value;
            }
        }

        public string AssessmentDate3
        {
            get
            {
                return _AssessmentDate3;
            }

            set
            {
                _AssessmentDate3 = value;
            }
        }

        public string PartialPayAmt3
        {
            get
            {
                return _PartialPayAmt3;
            }

            set
            {
                _PartialPayAmt3 = value;
            }
        }

        public string Status4
        {
            get
            {
                return _Status4;
            }

            set
            {
                _Status4 = value;
            }
        }

        public string InstallmentAmt4
        {
            get
            {
                return _InstallmentAmt4;
            }

            set
            {
                _InstallmentAmt4 = value;
            }
        }

        public string Interest4
        {
            get
            {
                return _Interest4;
            }

            set
            {
                _Interest4 = value;
            }
        }

        public string Penalty4
        {
            get
            {
                return _Penalty4;
            }

            set
            {
                _Penalty4 = value;
            }
        }

        public string AmountDue4
        {
            get
            {
                return _AmountDue4;
            }

            set
            {
                _AmountDue4 = value;
            }
        }

        public string DatePaid4
        {
            get
            {
                return _DatePaid4;
            }

            set
            {
                _DatePaid4 = value;
            }
        }

        public string DelinquentDate4
        {
            get
            {
                return _DelinquentDate4;
            }

            set
            {
                _DelinquentDate4 = value;
            }
        }

        public string TotalTax4
        {
            get
            {
                return _TotalTax4;
            }

            set
            {
                _TotalTax4 = value;
            }
        }

        public string RedemptionDate4
        {
            get
            {
                return _RedemptionDate4;
            }

            set
            {
                _RedemptionDate4 = value;
            }
        }

        public string RedemptionAmount4
        {
            get
            {
                return _RedemptionAmount4;
            }

            set
            {
                _RedemptionAmount4 = value;
            }
        }

        public string VolumeNo4
        {
            get
            {
                return _VolumeNo4;
            }

            set
            {
                _VolumeNo4 = value;
            }
        }

        public string DueDate4
        {
            get
            {
                return _DueDate4;
            }

            set
            {
                _DueDate4 = value;
            }
        }

        public string CertOfPurch4
        {
            get
            {
                return _CertOfPurch4;
            }

            set
            {
                _CertOfPurch4 = value;
            }
        }

        public string PmtGoodThrough4
        {
            get
            {
                return _PmtGoodThrough4;
            }

            set
            {
                _PmtGoodThrough4 = value;
            }
        }

        public string AssessmentDate4
        {
            get
            {
                return _AssessmentDate4;
            }

            set
            {
                _AssessmentDate4 = value;
            }
        }

        public string PartialPayAmt4
        {
            get
            {
                return _PartialPayAmt4;
            }

            set
            {
                _PartialPayAmt4 = value;
            }
        }

        public string HOExempt
        {
            get
            {
                return _HOExempt;
            }

            set
            {
                _HOExempt = value;
            }
        }

        public string AOExempt
        {
            get
            {
                return _AOExempt;
            }

            set
            {
                _AOExempt = value;
            }
        }

        public string LandVal
        {
            get
            {
                return _LandVal;
            }

            set
            {
                _LandVal = value;
            }
        }

        public string ImpVal
        {
            get
            {
                return _ImpVal;
            }

            set
            {
                _ImpVal = value;
            }
        }

        public string NetVal
        {
            get
            {
                return _NetVal;
            }

            set
            {
                _NetVal = value;
            }
        }

        public string PersPropVal
        {
            get
            {
                return _PersPropVal;
            }

            set
            {
                _PersPropVal = value;
            }
        }
    }


}
