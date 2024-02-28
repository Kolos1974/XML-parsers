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
using WindowsFormsApp_NET_Framework;

namespace WindowsFormsApp_NET_Framework
{
    public partial class Form1 : Form
    {

        // A letöltött XSD-ből készült osztályok
        WindowsFormsApp_NET_Framework_CAMT.Document doc1;

        // BankStatement bnkstm;
        // Document doc2;
        XmlDocument doc2;



        public Form1()
        {
            InitializeComponent();
            doc1 = new WindowsFormsApp_NET_Framework_CAMT.Document();
            // doc2 = new Document();
            doc2 = new XmlDocument();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    // Ez jól működik!!
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
                            ser = new XmlSerializer(typeof(WindowsFormsApp_NET_Framework_CAMT.Document));
                            doc1 = (WindowsFormsApp_NET_Framework_CAMT.Document)ser.Deserialize(sr);

                            MessageBox.Show("Az XML file beolvasásra került!");
                            label2.Text = doc1.ToString();

                        }
                        else
                        {
                            ser = new XmlSerializer(typeof(XmlDocument));
                            doc2 = (XmlDocument)ser.Deserialize(sr);

                            MessageBox.Show("Az XML file beolvasásra került!");
                            label2.Text = doc2.ToString();
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az XML file beolvasásra SIKERTELEN!");
                }

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int poz = 20;


            if (radioButton1.Checked)
            {
                // CAMT XSD-ből
                foreach (WindowsFormsApp_NET_Framework_CAMT.ReportEntry2 ntry in doc1.BkToCstmrStmt.Stmt[0].Ntry)
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
                // XML tartalomból készült osztályoknál
                // foreach (DocumentBkToCstmrStmtStmtNtry ntry in doc2.BkToCstmrStmt.Stmt[0].Ntry)
                foreach (DocumentBkToCstmrStmtStmtNtry ntry in doc2)
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

        }

        private void btnSave_Click(object sender, EventArgs e)
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
                            ser = new XmlSerializer(typeof(WindowsFormsApp_NET_Framework_CAMT.Document));
                            ser.Serialize(sw, doc1);
                        }
                        else
                        {
                            // ser = new XmlSerializer(typeof(Document));
                            ser = new XmlSerializer(typeof(XmlDocument));
                            ser.Serialize(sw, doc2);
                        }
                    }
                    MessageBox.Show("Az XML file mentésre került!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az XML file mentése SIKERTELEN!");
                }
            }

        }

        private void btnSaveSzla_Click(object sender, EventArgs e)
        {
            XmlNode tempNode;

            XmlNodeList tempNodeList;


            Boolean choosedAcc = false;
            String choosedAccNum = "";
            String accNumDescription;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {

                        /*
                        if (radioButton1.Checked)
                        {
                            // CAMT XSD-ből
                            foreach (WindowsFormsApp_NET_Framework_CAMT.ReportEntry2 ntry in doc1.BkToCstmrStmt.Stmt[0].Ntry)
                            {
                                // l.Text = ntry.CdtDbtInd.ToString() + " - " + ntry.Amt.Value.ToString();
                            }
                        }
                        else
                        {
                            // XML tartalomból készült osztályoknál
                            // Ez most az első kivonati tételeket olvassa fel, de lehet, hogy az alszámla van elől!!
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

                        // Az első kivonat összes node-ja!!
                        // Ez csak típus meghatározás!
                        var nodeListStmt = nodeList.Item(0).ChildNodes;
                        var nodeListNtry = nodeList.Item(0).ChildNodes;

                        // var nodeListNtry = new Xmlch();


                        // A kivonat összes számlaszámán végigmegy. Most két kivonatot tartalmaz!!
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


                            // Az adott Stmt elemein megy végig!
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

                                    // Az Acct összes elemén végigmegy!
                                    foreach (XmlNode node3 in node2.ChildNodes)
                                    {
                                        if (node3.Name == "Id")
                                        {
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
                                                        // Itt még hiba van!!
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
                                    }

                                    //sw.WriteLine(" ");

                                }
                                // Acct vége

                                // 
                                if ((node2.Name == "Ntry") && choosedAcc)
                                {
                                    tempNodeList = node2.ChildNodes;
                                    foreach (XmlNode node3 in tempNodeList)
                                    {
                                        if (node3.Name == "Amt")
                                        {
                                            sw.Write(textBox1.Text);
                                            sw.Write("|");
                                            sw.Write("Pénzforgalmi Bankszámla");
                                            sw.Write("|");
                                            sw.Write("Dátum");
                                            sw.Write("|");
                                            sw.Write("TR kód");
                                            sw.Write("|");
                                            sw.Write("Pénznem");
                                            sw.Write("|");
                                            sw.Write("TR ID");
                                            sw.Write("|");
                                            sw.Write("Játékos neve");
                                            sw.Write("|");
                                            sw.Write("Játékos bankszámlaszáma");
                                            sw.Write("|");
                                            sw.Write("|");
                                            sw.Write("|");
                                            sw.Write("Megjegyzés 1");
                                            sw.Write("|");
                                            sw.Write("Megjegyzés 2");
                                            sw.Write("|");
                                            sw.Write("Megjegyzés 3");
                                            sw.Write("|");
                                            sw.Write(node3.InnerText);
                                            sw.Write("|");
                                            sw.Write("Dátum");
                                            sw.Write("|");
                                            sw.Write("|");
                                            sw.WriteLine("|");
                                        }
                                    }
                                    // sw.WriteLine(" ");
                                }


                                /*
                                sw.WriteLine("");
                                sw.WriteLine("--------------- 5 ----------------");
                                sw.WriteLine("");
                                */


                                /*
                                if (choosedAcc)
                                {
                                    // Ez nem jó, mert az Stmt összes elemén végigmegy!
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
                        MessageBox.Show("A TXT file mentésre került!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("A TXT file mentése SIKERTELEN!");
                }
            }

        }
    }
}
