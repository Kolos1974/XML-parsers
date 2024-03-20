using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace BankStatementParser.UI
{
    public partial class Form1 : Form
    {

        // A let�lt�tt XSD-b�l k�sz�lt oszt�lyok
        BankStatementParser.UI_CAMT.Document doc1;

        // BankStatement bnkstm;
        // Document doc2;
        XmlDocument doc2;


        public Form1()
        {
            InitializeComponent();
            doc1 = new BankStatementParser.UI_CAMT.Document();
            // doc2 = new Document();
            doc2 = new XmlDocument();
        }

        private void Open_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    // Ez j�l m�k�dik!!
                    /*
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(Document));
                        doc = (Document)ser.Deserialize(sr);
                    }
                    */


                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        XmlSerializer ser;

                        if (radioButton1.Checked)
                        {
                            ser = new XmlSerializer(typeof(BankStatementParser.UI_CAMT.Document));
                            doc1 = (BankStatementParser.UI_CAMT.Document)ser.Deserialize(sr);

                            MessageBox.Show("Az XML file beolvas�sra ker�lt!");
                            label2.Text = doc1.ToString();

                        }
                        else
                        {
                            ser = new XmlSerializer(typeof(XmlDocument));
                            doc2 = (XmlDocument)ser.Deserialize(sr);

                            MessageBox.Show("Az XML file beolvas�sra ker�lt!");
                            label2.Text = doc2.ToString();
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az XML file beolvas�sra SIKERTELEN!");
                }

            }

        }

        private void Print_Click(object sender, EventArgs e)
        {
            int poz = 20;


            if (radioButton1.Checked)
            {
                // CAMT XSD-b�l
                foreach (BankStatementParser.UI_CAMT.ReportEntry2 ntry in doc1.BkToCstmrStmt.Stmt[0].Ntry)
                {
                    Label l = new Label();
                    l.Top = poz;
                    l.Left = 200;
                    l.Width = 500;
                    l.Text = ntry.ToString();
                    l.Text = ntry.CdtDbtInd.ToString() + " - " + ntry.Amt.Value.ToString();
                    Controls.Add(l);
                    poz += 40;
                }
            }
            else
            {
                // XML tartalomb�l k�sz�lt oszt�lyokn�l
                // foreach (DocumentBkToCstmrStmtStmtNtry ntry in doc2.BkToCstmrStmt.Stmt[0].Ntry)
                // foreach (DocumentBkToCstmrStmtStmtNtry ntry in doc2)
                // foreach (XmlElement ntry in doc2)
                // foreach (XmlNode ntry in doc2)
                foreach (XmlElement ntry in doc2)
                {

                    Label l = new Label();
                    l.Top = poz;
                    l.Left = 200;
                    l.Width = 500;
                    l.Text = " - " + ntry.ToString() + " - ";
                    // l.Text = ntry.CdtDbtInd.ToString() + " - " + ntry.Amt.Value.ToString();
                    // l.Text = " - " +  ntry.InnerText.ToString() + " - ";

                    // label2.Text = " - " + ntry.InnerText.ToString() + " - ";

                    Controls.Add(l);
                    poz += 40;

                    l.Text = ntry.InnerText.ToString();

                    listBox1.Items.Add("- " + ntry.InnerText.ToString());
                }
                listBox1.Items.Add("Teszt");


            }


        }

        private void SaveToXML_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        // XmlSerializer ser = new XmlSerializer(typeof(Baratok));

                        XmlSerializer ser;

                        if (radioButton1.Checked)
                        {
                            ser = new XmlSerializer(typeof(BankStatementParser.UI_CAMT.Document));
                            ser.Serialize(sw, doc1);
                        }
                        else
                        {
                            // ser = new XmlSerializer(typeof(Document));
                            ser = new XmlSerializer(typeof(XmlDocument));
                            ser.Serialize(sw, doc2);
                        }
                    }
                    MessageBox.Show("Az XML file ment�sre ker�lt!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az XML file ment�se SIKERTELEN!");
                }
            }

        }

        private void SaveToBankAccountHistory_Click(object sender, EventArgs e)
        {
            XmlNode tempNode;
            XmlNodeList tempNodeList;

            Boolean choosedAcc = false;
            String choosedAccNum = "";
            String accNumName = "";
            String accAccountDate = "";
            String accTransType = "";
            String accCurrencyCode = "";
            String accTransId = "";
            String accCustName = "";
            String accCustBankAccount = "";
            String accCustBankAccountName = "";
            String accNotice1 = "";
            String accNotice2 = "";
            String accNotice3 = "";
            String ntryAmount = "";
            String accValueDate = "";

            // Nem szerepelnek a CAM form�tumban!!
            String accOriginCurrencyCode = "";
            String accOriginAmount = "";

            String cdtDbtInd = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {

                        /*
                        if (radioButton1.Checked)
                        {
                            // CAMT XSD-b�l
                            foreach (WindowsFormsApp_NET_Framework_CAMT.ReportEntry2 ntry in doc1.BkToCstmrStmt.Stmt[0].Ntry)
                            {
                                // l.Text = ntry.CdtDbtInd.ToString() + " - " + ntry.Amt.Value.ToString();
                            }
                        }
                        else
                        {
                            // XML tartalomb�l k�sz�lt oszt�lyokn�l
                            // Ez most az els� kivonati t�teleket olvassa fel, de lehet, hogy az alsz�mla van el�l!!
                            foreach (DocumentBkToCstmrStmtStmtNtry ntry in doc2.BkToCstmrStmt.Stmt[0].Ntry)
                            {
                                // l.Text = ntry.CdtDbtInd.ToString() + " - " + ntry.Amt.Value.ToString();


                                //sw.Write(ntry.NtryDtls.TxDtls.RmtInf.Ustrd.ToString());

                                sw.Write("|||");
                                sw.Write(" ");
                                sw.Write(ntry.Amt.Value.ToString());
                                sw.WriteLine("|");
                            }

                        }
                        */

                        var nodeList = doc2.GetElementsByTagName("Stmt");

                        // doc2.SelectNodes

                        // nodeList[0].InnerXml.ToString();

                        // Az els� kivonat �sszes node-ja!!
                        // Ez csak t�pus meghat�roz�s!
                        var nodeListStmt = nodeList.Item(0).ChildNodes;
                        var nodeListNtry = nodeList.Item(0).ChildNodes;

                        // var nodeListNtry = new Xmlch();


                        // A kivonat �sszes sz�mlasz�m�n v�gigmegy. Most k�t kivonatot tartalmaz!!
                        foreach (XmlNode node in nodeList)
                        {
                            // nodeListNtry = nodeList.Item(0).ChildNodes;

                            nodeListStmt = node.ChildNodes;
                            nodeListNtry = nodeListStmt.Item(0).ChildNodes;




                            // if node["Acct/Id/IBAN"].InnerText

                            // sw.Write(ntry.Amt.Value.ToString());
                            // sw.Write(nodeListNtry.Item(0).InnerText);
                            // /sw.Write(node.InnerText);
                            // // sw.Write(node["Acct/Id/IBAN"].InnerText);
                            // sw.Write(nodeList[0].InnerXml.ToString());

                            /*
                            sw.WriteLine(node.InnerText);
                            sw.WriteLine(node.Name);
                            sw.WriteLine("--------------- 1 ----------------");
                            */

                            // sw.WriteLine(node["IBAN"].InnerText);
                            // sw.WriteLine(node.Attributes["IBAN"].InnerText);

                            // sw.WriteLine(node.SelectSingleNode("IBAN").InnerText);


                            // Az adott Stmt elemein megy v�gig!
                            foreach (XmlNode node2 in nodeListStmt)
                            {
                                /*
                                sw.Write(node2.InnerText);
                                sw.Write("|||");

                                sw.Write(node2.Name);
                                sw.WriteLine("--------------- 2 ----------------");
                                */

                                if (node2.Name == "Acct")
                                {
                                    // sw.Write(node2["Acct/Id/IBAN"].InnerText);
                                    // sw.Write(node2.Attributes["Acct/Id/IBAN"].InnerText);

                                    /*
                                    sw.WriteLine(node2.InnerXml.ToString());
                                    sw.WriteLine(node2.ChildNodes.Count.ToString());
                                    sw.WriteLine("--------------- 3 ----------------");
                                    */

                                    // Az Acct �sszes elem�n v�gigmegy!
                                    foreach (XmlNode node3 in node2.ChildNodes)
                                    {
                                        if (node3.Name == "Id")
                                        {

                                            // Ez nem tal�l semmit!!
                                            XmlNode noteFind = node3.SelectSingleNode("IBAN");
                                            if (noteFind != null)
                                            {
                                                sw.WriteLine(noteFind.InnerText);
                                                sw.WriteLine("--------------- IBAN ----------------");
                                            }

                                            /*
                                            sw.WriteLine(node3.InnerXml.ToString());
                                            sw.WriteLine(node3.InnerText);
                                            sw.WriteLine("--------------- 4 ----------------");
                                            */

                                            foreach (XmlNode node4 in node3.ChildNodes)
                                            {
                                                if (node4.Name == "IBAN")
                                                {
                                                    /*
                                                      sw.WriteLine(node4.InnerXml.ToString());
                                                      sw.WriteLine(node4.InnerText);
                                                    */

                                                    // if (node4.InnerText.Contains("119911020214869800000000"))
                                                    if (node4.InnerText.Contains(textBox1.Text))
                                                    {
                                                        choosedAcc = true;
                                                        // Itt m�g hiba van!!
                                                        // choosedAccNum = node4.InnerText.ToString().Substring(5, 24);
                                                        /// sw.WriteLine("--------------- Found! ----------------");
                                                    }
                                                    else
                                                    {
                                                        choosedAcc = false;
                                                        choosedAccNum = "";
                                                    }
                                                }
                                            }
                                        }
                                        if (node3.Name == "Nm")
                                        {
                                            accNumName = node3.InnerText;
                                        }
                                    }

                                    //sw.WriteLine(" ");

                                }
                                // Acct v�ge

                                // 
                                if ((node2.Name == "Ntry") && choosedAcc)
                                {
                                    // Inicializ�lni kell a v�ltoz�t, mert nem mindegyik t�teln�l van TrID!
                                    accTransId = "";
                                    accCustName = "";
                                    accCustBankAccount = "";
                                    accNotice1 = "";
                                    accNotice2 = "";
                                    accNotice3 = "";
                                    accOriginCurrencyCode = "";
                                    accOriginAmount = "";

                                    cdtDbtInd = "";

                                    tempNodeList = node2.ChildNodes;
                                    foreach (XmlNode node3 in tempNodeList)
                                    {
                                        if (node3.Name == "Amt")
                                        {
                                            ntryAmount = node3.InnerText.Replace('.', ',');

                                            accCurrencyCode = (node3 as XmlElement).GetAttribute("Ccy");

                                            // Ez is j�!!
                                            // accCurrencyCode = node3.Attributes["Ccy"].Value;
                                        }

                                        if (node3.Name == "CdtDbtInd")
                                        {
                                            cdtDbtInd = node3.InnerText;
                                        }


                                        if (node3.Name == "BookgDt")
                                        {
                                            foreach (XmlNode node4 in node3.ChildNodes)
                                            {
                                                if (node4.Name == "Dt")
                                                {
                                                    // Kezelni kellene, ha m�s a d�tum form�tum!!
                                                    accAccountDate = node4.InnerText.ToString().Substring(0, 4) +
                                                                     node4.InnerText.ToString().Substring(5, 2) +
                                                                     node4.InnerText.ToString().Substring(8, 2);
                                                }
                                            }
                                        }

                                        if (node3.Name == "ValDt")
                                        {
                                            foreach (XmlNode node4 in node3.ChildNodes)
                                            {
                                                if (node4.Name == "Dt")
                                                {
                                                    // Kezelni kellene, ha m�s a d�tum form�tum!!
                                                    accValueDate = node4.InnerText.ToString().Substring(0, 4) +
                                                                     node4.InnerText.ToString().Substring(5, 2) +
                                                                     node4.InnerText.ToString().Substring(8, 2);
                                                }
                                            }
                                        }

                                        if (node3.Name == "BkTxCd")
                                        {
                                            foreach (XmlNode node4 in node3.ChildNodes)
                                            {
                                                if (node4.Name == "Prtry")
                                                {
                                                    foreach (XmlNode node5 in node4.ChildNodes)
                                                    {
                                                        if (node5.Name == "Cd")
                                                        {
                                                            accTransType = node5.InnerText;

                                                        }
                                                    }
                                                }
                                            }
                                        }

                                        if (node3.Name == "NtryDtls")
                                        {
                                            foreach (XmlNode node4 in node3.ChildNodes)
                                            {
                                                if (node4.Name == "TxDtls")
                                                {
                                                    foreach (XmlNode node5 in node4.ChildNodes)
                                                    {
                                                        if (node5.Name == "Refs")
                                                        {
                                                            foreach (XmlNode node6 in node5.ChildNodes)
                                                            {
                                                                if (node6.Name == "TxId")
                                                                {
                                                                    accTransId = node6.InnerText;
                                                                }
                                                            }
                                                        }

                                                        if (node5.Name == "RltdPties")
                                                        {
                                                            foreach (XmlNode node6 in node5.ChildNodes)
                                                            {
                                                                if (node6.Name == "Dbtr")
                                                                {
                                                                    foreach (XmlNode node7 in node6.ChildNodes)
                                                                    {
                                                                        if (node7.Name == "Nm")
                                                                        {
                                                                            accCustName = node7.InnerText;
                                                                        }
                                                                    }
                                                                }

                                                                if (node6.Name == "DbtrAcct")
                                                                {
                                                                    foreach (XmlNode node7 in node6.ChildNodes)
                                                                    {
                                                                        if (node7.Name == "Id")
                                                                        {
                                                                            foreach (XmlNode node8 in node7.ChildNodes)
                                                                            {
                                                                                if (node8.Name == "IBAN")
                                                                                {
                                                                                    accCustBankAccount = node8.InnerText;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }


                                                        if (node5.Name == "RmtInf")
                                                        {
                                                            foreach (XmlNode node6 in node5.ChildNodes)
                                                            {
                                                                if (node6.Name == "Ustrd")
                                                                {
                                                                    int textLength = node6.InnerText.Length;

                                                                    // Maximaliz�lom a 3*35 karakterre.
                                                                    if (textLength > 105)
                                                                    {
                                                                        textLength = 105;
                                                                    }

                                                                    if (textLength > 70)
                                                                    {
                                                                        accNotice3 = node6.InnerText.Substring(70, textLength - 70);
                                                                        textLength = 70;
                                                                    }
                                                                    if (textLength > 35)
                                                                    {
                                                                        accNotice2 = node6.InnerText.Substring(35, textLength - 35);
                                                                        textLength = 35;
                                                                    }
                                                                    if (textLength > 0)
                                                                    {
                                                                        accNotice1 = node6.InnerText.Substring(0, textLength);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }

                                    // A j�v��r�s t�tel ki�r�sa
                                    if (cdtDbtInd == "CRDT")
                                    {
                                        sw.Write(textBox1.Text);
                                        sw.Write("|");
                                        sw.Write(accNumName);
                                        sw.Write("|");
                                        sw.Write(accAccountDate);
                                        sw.Write("|");
                                        sw.Write(accTransType);
                                        sw.Write("|");
                                        sw.Write(accCurrencyCode);
                                        sw.Write("|");
                                        sw.Write(accTransId);
                                        sw.Write("|");
                                        sw.Write(accCustName);
                                        sw.Write("|");
                                        sw.Write(accCustBankAccount);
                                        sw.Write("|");
                                        sw.Write(accCustBankAccountName);
                                        sw.Write("|");
                                        sw.Write("|");
                                        sw.Write(accNotice1);
                                        sw.Write("|");
                                        sw.Write(accNotice2);
                                        sw.Write("|");
                                        sw.Write(accNotice3);
                                        sw.Write("|");
                                        sw.Write(ntryAmount);
                                        sw.Write("|");
                                        sw.Write(accValueDate);
                                        sw.Write("|");
                                        sw.Write(accOriginCurrencyCode);
                                        sw.Write("|");
                                        sw.Write(accOriginAmount);
                                        sw.WriteLine("|");
                                    }

                                    /*
                                    sw.WriteLine("");
                                    sw.WriteLine("--------------- 5 ----------------");
                                    sw.WriteLine("");
                                    */


                                    /*
                                    if (choosedAcc)
                                    {
                                        // Ez nem j�, mert az Stmt �sszes elem�n v�gigmegy!
                                        foreach (XmlNode node2 in nodeListNtry)
                                        {
                                            sw.WriteLine(node2.InnerText);


                                            sw.Write("|||");
                                            sw.Write(" ");
                                        }

                                    }
                                    */


                                    // sw.WriteLine("|");
                                }


                            }
                        }
                        MessageBox.Show("A TXT file ment�sre ker�lt!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A TXT file ment�se SIKERTELEN!");
                }
            }

        }

    }
}
