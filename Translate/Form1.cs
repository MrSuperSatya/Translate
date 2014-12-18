using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Satya;
using System.Data.OleDb;

namespace Translate
{
    public partial class Form1 : Form
    {
        SatMsAccessConnector con;

        public Form1()
        {
            InitializeComponent();
            con = new SatMsAccessConnector(@"D:\Database\Combine6.accdb", false);
        }
        private void textBoxPage_KeyDown(object sender, KeyEventArgs e)
        {
            OleDbDataReader reader = con.executeReader("Select ID, Khmer, Korean, Chinese From Combine Where ID="+textBoxPage.Text);
            if (reader.Read())
            {
                Word w = new Word();
                w.ID = reader[0].ToString();
                w.Khmer = reader[1].ToString();
                w.Korean = reader[2].ToString();
                w.Chinese = reader[3].ToString();
                setText(w);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
        private void setText(Word w)
        {
            textBoxID.Text = w.ID;
            textBoxKhmer.Text = w.Khmer;
            textBoxChinese.Text = w.Chinese;
        }
    }
}
