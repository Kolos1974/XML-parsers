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
using System.Xml.Serialization;
using WindowsFormsApp_NET_Framework;

namespace WindowsFormsApp_NET_Framework
{
    public partial class Form1 : Form
    {


        WindowsFormsApp_NET_Framework_CAMT.Document doc1;

        // BankStatement bnkstm;
        Document doc2;

        public Form1()
        {
            InitializeComponent();
            doc1 = new WindowsFormsApp_NET_Framework_CAMT.Document();
            doc2 = new Document();
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
                            ser = new XmlSerializer(typeof(Document));
                            doc2 = (Document)ser.Deserialize(sr);

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
                foreach (DocumentBkToCstmrStmtStmtNtry ntry in doc2.BkToCstmrStmt.Stmt[0].Ntry)
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
                            ser = new XmlSerializer(typeof(Document));
                            ser.Serialize(sw, doc2);
                        }
                        MessageBox.Show("Az XML file mentésre került!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az XML file mentése SIKERTELEN!");
                }
            }

        }

        private void btnSaveSzla_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine("This is the text");

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
