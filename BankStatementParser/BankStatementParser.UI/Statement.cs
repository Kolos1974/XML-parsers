using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementParser.UI
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02", IsNullable = false)]
    public partial class Document
    {

        private DocumentBkToCstmrStmt bkToCstmrStmtField;

        /// <remarks/>
        public DocumentBkToCstmrStmt BkToCstmrStmt
        {
            get
            {
                return this.bkToCstmrStmtField;
            }
            set
            {
                this.bkToCstmrStmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmt
    {

        private DocumentBkToCstmrStmtGrpHdr grpHdrField;

        private DocumentBkToCstmrStmtStmt[] stmtField;

        /// <remarks/>
        public DocumentBkToCstmrStmtGrpHdr GrpHdr
        {
            get
            {
                return this.grpHdrField;
            }
            set
            {
                this.grpHdrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Stmt")]
        public DocumentBkToCstmrStmtStmt[] Stmt
        {
            get
            {
                return this.stmtField;
            }
            set
            {
                this.stmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtGrpHdr
    {

        private string msgIdField;

        private System.DateTime creDtTmField;

        /// <remarks/>
        public string MsgId
        {
            get
            {
                return this.msgIdField;
            }
            set
            {
                this.msgIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreDtTm
        {
            get
            {
                return this.creDtTmField;
            }
            set
            {
                this.creDtTmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmt
    {

        private string idField;

        private System.DateTime creDtTmField;

        private DocumentBkToCstmrStmtStmtFrToDt frToDtField;

        private DocumentBkToCstmrStmtStmtAcct acctField;

        private DocumentBkToCstmrStmtStmtBal[] balField;

        private DocumentBkToCstmrStmtStmtTxsSummry txsSummryField;

        private DocumentBkToCstmrStmtStmtNtry[] ntryField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreDtTm
        {
            get
            {
                return this.creDtTmField;
            }
            set
            {
                this.creDtTmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtFrToDt FrToDt
        {
            get
            {
                return this.frToDtField;
            }
            set
            {
                this.frToDtField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcct Acct
        {
            get
            {
                return this.acctField;
            }
            set
            {
                this.acctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bal")]
        public DocumentBkToCstmrStmtStmtBal[] Bal
        {
            get
            {
                return this.balField;
            }
            set
            {
                this.balField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtTxsSummry TxsSummry
        {
            get
            {
                return this.txsSummryField;
            }
            set
            {
                this.txsSummryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ntry")]
        public DocumentBkToCstmrStmtStmtNtry[] Ntry
        {
            get
            {
                return this.ntryField;
            }
            set
            {
                this.ntryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtFrToDt
    {

        private System.DateTime frDtTmField;

        private System.DateTime toDtTmField;

        /// <remarks/>
        public System.DateTime FrDtTm
        {
            get
            {
                return this.frDtTmField;
            }
            set
            {
                this.frDtTmField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ToDtTm
        {
            get
            {
                return this.toDtTmField;
            }
            set
            {
                this.toDtTmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcct
    {

        private DocumentBkToCstmrStmtStmtAcctID idField;

        private string ccyField;

        private string nmField;

        private DocumentBkToCstmrStmtStmtAcctOwnr ownrField;

        private DocumentBkToCstmrStmtStmtAcctSvcr svcrField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctOwnr Ownr
        {
            get
            {
                return this.ownrField;
            }
            set
            {
                this.ownrField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctSvcr Svcr
        {
            get
            {
                return this.svcrField;
            }
            set
            {
                this.svcrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctID
    {

        private string iBANField;

        /// <remarks/>
        public string IBAN
        {
            get
            {
                return this.iBANField;
            }
            set
            {
                this.iBANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctOwnr
    {

        private string nmField;

        private DocumentBkToCstmrStmtStmtAcctOwnrPstlAdr pstlAdrField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctOwnrPstlAdr PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctOwnrPstlAdr
    {

        private string strtNmField;

        private string pstCdField;

        private string twnNmField;

        /// <remarks/>
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }

        /// <remarks/>
        public string PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }

        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctSvcr
    {

        private DocumentBkToCstmrStmtStmtAcctSvcrFinInstnId finInstnIdField;

        private DocumentBkToCstmrStmtStmtAcctSvcrBrnchId brnchIdField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctSvcrFinInstnId FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctSvcrBrnchId BrnchId
        {
            get
            {
                return this.brnchIdField;
            }
            set
            {
                this.brnchIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctSvcrFinInstnId
    {

        private string bICField;

        private string nmField;

        private DocumentBkToCstmrStmtStmtAcctSvcrFinInstnIdPstlAdr pstlAdrField;

        /// <remarks/>
        public string BIC
        {
            get
            {
                return this.bICField;
            }
            set
            {
                this.bICField = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctSvcrFinInstnIdPstlAdr PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctSvcrFinInstnIdPstlAdr
    {

        private ushort pstCdField;

        private string twnNmField;

        /// <remarks/>
        public ushort PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }

        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctSvcrBrnchId
    {

        private string nmField;

        private DocumentBkToCstmrStmtStmtAcctSvcrBrnchIdPstlAdr pstlAdrField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtAcctSvcrBrnchIdPstlAdr PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtAcctSvcrBrnchIdPstlAdr
    {

        private string strtNmField;

        private ushort pstCdField;

        private string twnNmField;

        /// <remarks/>
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }

        /// <remarks/>
        public ushort PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }

        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBal
    {

        private DocumentBkToCstmrStmtStmtBalTP tpField;

        private DocumentBkToCstmrStmtStmtBalCdtLine cdtLineField;

        private DocumentBkToCstmrStmtStmtBalAmt amtField;

        private string cdtDbtIndField;

        private DocumentBkToCstmrStmtStmtBalDT dtField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalTP Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalCdtLine CdtLine
        {
            get
            {
                return this.cdtLineField;
            }
            set
            {
                this.cdtLineField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalAmt Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public string CdtDbtInd
        {
            get
            {
                return this.cdtDbtIndField;
            }
            set
            {
                this.cdtDbtIndField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalDT Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalTP
    {

        private DocumentBkToCstmrStmtStmtBalTPCdOrPrtry cdOrPrtryField;

        private DocumentBkToCstmrStmtStmtBalTPSubTp subTpField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalTPCdOrPrtry CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalTPSubTp SubTp
        {
            get
            {
                return this.subTpField;
            }
            set
            {
                this.subTpField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalTPCdOrPrtry
    {

        private string cdField;

        /// <remarks/>
        public string Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalTPSubTp
    {

        private string cdField;

        /// <remarks/>
        public string Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalCdtLine
    {

        private bool inclField;

        private DocumentBkToCstmrStmtStmtBalCdtLineAmt amtField;

        /// <remarks/>
        public bool Incl
        {
            get
            {
                return this.inclField;
            }
            set
            {
                this.inclField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtBalCdtLineAmt Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalCdtLineAmt
    {

        private string ccyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalAmt
    {

        private string ccyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtBalDT
    {

        private System.DateTime dtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtTxsSummry
    {

        private DocumentBkToCstmrStmtStmtTxsSummryTtlCdtNtries ttlCdtNtriesField;

        private DocumentBkToCstmrStmtStmtTxsSummryTtlDbtNtries ttlDbtNtriesField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtTxsSummryTtlCdtNtries TtlCdtNtries
        {
            get
            {
                return this.ttlCdtNtriesField;
            }
            set
            {
                this.ttlCdtNtriesField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtTxsSummryTtlDbtNtries TtlDbtNtries
        {
            get
            {
                return this.ttlDbtNtriesField;
            }
            set
            {
                this.ttlDbtNtriesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtTxsSummryTtlCdtNtries
    {

        private decimal sumField;

        /// <remarks/>
        public decimal Sum
        {
            get
            {
                return this.sumField;
            }
            set
            {
                this.sumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtTxsSummryTtlDbtNtries
    {

        private decimal sumField;

        /// <remarks/>
        public decimal Sum
        {
            get
            {
                return this.sumField;
            }
            set
            {
                this.sumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtry
    {

        private ushort ntryRefField;

        private DocumentBkToCstmrStmtStmtNtryAmt amtField;

        private string cdtDbtIndField;

        private string stsField;

        private DocumentBkToCstmrStmtStmtNtryBookgDt bookgDtField;

        private DocumentBkToCstmrStmtStmtNtryValDt valDtField;

        private string acctSvcrRefField;

        private DocumentBkToCstmrStmtStmtNtryBkTxCd bkTxCdField;

        private DocumentBkToCstmrStmtStmtNtryChrgs chrgsField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtls ntryDtlsField;

        /// <remarks/>
        public ushort NtryRef
        {
            get
            {
                return this.ntryRefField;
            }
            set
            {
                this.ntryRefField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryAmt Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public string CdtDbtInd
        {
            get
            {
                return this.cdtDbtIndField;
            }
            set
            {
                this.cdtDbtIndField = value;
            }
        }

        /// <remarks/>
        public string Sts
        {
            get
            {
                return this.stsField;
            }
            set
            {
                this.stsField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryBookgDt BookgDt
        {
            get
            {
                return this.bookgDtField;
            }
            set
            {
                this.bookgDtField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryValDt ValDt
        {
            get
            {
                return this.valDtField;
            }
            set
            {
                this.valDtField = value;
            }
        }

        /// <remarks/>
        public string AcctSvcrRef
        {
            get
            {
                return this.acctSvcrRefField;
            }
            set
            {
                this.acctSvcrRefField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryBkTxCd BkTxCd
        {
            get
            {
                return this.bkTxCdField;
            }
            set
            {
                this.bkTxCdField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryChrgs Chrgs
        {
            get
            {
                return this.chrgsField;
            }
            set
            {
                this.chrgsField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtls NtryDtls
        {
            get
            {
                return this.ntryDtlsField;
            }
            set
            {
                this.ntryDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryAmt
    {

        private string ccyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryBookgDt
    {

        private System.DateTime dtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryValDt
    {

        private System.DateTime dtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryBkTxCd
    {

        private DocumentBkToCstmrStmtStmtNtryBkTxCdPrtry prtryField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryBkTxCdPrtry Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryBkTxCdPrtry
    {

        private string cdField;

        /// <remarks/>
        public string Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryChrgs
    {

        private DocumentBkToCstmrStmtStmtNtryChrgsAmt amtField;

        private DocumentBkToCstmrStmtStmtNtryChrgsTP tpField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryChrgsAmt Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryChrgsTP Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryChrgsAmt
    {

        private string ccyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryChrgsTP
    {

        private DocumentBkToCstmrStmtStmtNtryChrgsTPPrtry prtryField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryChrgsTPPrtry Prtry
        {
            get
            {
                return this.prtryField;
            }
            set
            {
                this.prtryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryChrgsTPPrtry
    {

        private string idField;

        private string issrField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtls
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtls txDtlsField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtls TxDtls
        {
            get
            {
                return this.txDtlsField;
            }
            set
            {
                this.txDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtls
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRefs refsField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtls amtDtlsField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPties rltdPtiesField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRmtInf rmtInfField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdDts rltdDtsField;

        private string addtlTxInfField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRefs Refs
        {
            get
            {
                return this.refsField;
            }
            set
            {
                this.refsField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtls AmtDtls
        {
            get
            {
                return this.amtDtlsField;
            }
            set
            {
                this.amtDtlsField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPties RltdPties
        {
            get
            {
                return this.rltdPtiesField;
            }
            set
            {
                this.rltdPtiesField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRmtInf RmtInf
        {
            get
            {
                return this.rmtInfField;
            }
            set
            {
                this.rmtInfField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdDts RltdDts
        {
            get
            {
                return this.rltdDtsField;
            }
            set
            {
                this.rltdDtsField = value;
            }
        }

        /// <remarks/>
        public string AddtlTxInf
        {
            get
            {
                return this.addtlTxInfField;
            }
            set
            {
                this.addtlTxInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRefs
    {

        private uint endToEndIdField;

        private bool endToEndIdFieldSpecified;

        private string txIdField;

        /// <remarks/>
        public uint EndToEndId
        {
            get
            {
                return this.endToEndIdField;
            }
            set
            {
                this.endToEndIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndToEndIdSpecified
        {
            get
            {
                return this.endToEndIdFieldSpecified;
            }
            set
            {
                this.endToEndIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string TxId
        {
            get
            {
                return this.txIdField;
            }
            set
            {
                this.txIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtls
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtlsPrtryAmt prtryAmtField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtlsPrtryAmt PrtryAmt
        {
            get
            {
                return this.prtryAmtField;
            }
            set
            {
                this.prtryAmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtlsPrtryAmt
    {

        private string tpField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtlsPrtryAmtAmt amtField;

        /// <remarks/>
        public string Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtlsPrtryAmtAmt Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsAmtDtlsPrtryAmtAmt
    {

        private string ccyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPties
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtr cdtrField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtrAcct cdtrAcctField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtr dbtrField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcct dbtrAcctField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtr ultmtDbtrField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtr Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtrAcct CdtrAcct
        {
            get
            {
                return this.cdtrAcctField;
            }
            set
            {
                this.cdtrAcctField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtr Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcct DbtrAcct
        {
            get
            {
                return this.dbtrAcctField;
            }
            set
            {
                this.dbtrAcctField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtr UltmtDbtr
        {
            get
            {
                return this.ultmtDbtrField;
            }
            set
            {
                this.ultmtDbtrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtr
    {

        private string nmField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtrAcct
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtrAcctID idField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtrAcctID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesCdtrAcctID
    {

        private string iBANField;

        /// <remarks/>
        public string IBAN
        {
            get
            {
                return this.iBANField;
            }
            set
            {
                this.iBANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtr
    {

        private string nmField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrID idField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrID
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrIDOrgId orgIdField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrIDOrgId OrgId
        {
            get
            {
                return this.orgIdField;
            }
            set
            {
                this.orgIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrIDOrgId
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrIDOrgIdOthr othrField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrIDOrgIdOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrIDOrgIdOthr
    {

        private uint idField;

        /// <remarks/>
        public uint Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcct
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcctID idField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcctID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcctID
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcctIDOthr othrField;

        private string iBANField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcctIDOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }

        /// <remarks/>
        public string IBAN
        {
            get
            {
                return this.iBANField;
            }
            set
            {
                this.iBANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesDbtrAcctIDOthr
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtr
    {

        private string nmField;

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrID idField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrID Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrID
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrIDPrvtId prvtIdField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrIDPrvtId PrvtId
        {
            get
            {
                return this.prvtIdField;
            }
            set
            {
                this.prvtIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrIDPrvtId
    {

        private DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrIDPrvtIdOthr othrField;

        /// <remarks/>
        public DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrIDPrvtIdOthr Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdPtiesUltmtDbtrIDPrvtIdOthr
    {

        private string idField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRmtInf
    {

        private string ustrdField;

        /// <remarks/>
        public string Ustrd
        {
            get
            {
                return this.ustrdField;
            }
            set
            {
                this.ustrdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.02")]
    public partial class DocumentBkToCstmrStmtStmtNtryNtryDtlsTxDtlsRltdDts
    {

        private System.DateTime accptncDtTmField;

        /// <remarks/>
        public System.DateTime AccptncDtTm
        {
            get
            {
                return this.accptncDtTmField;
            }
            set
            {
                this.accptncDtTmField = value;
            }
        }
    }




}
