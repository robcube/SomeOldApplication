using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SomeOldApplication.ScriptingService;

namespace SomeOldApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void writeCSV(DataTable dt, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (dt.Rows.Count > 0)
            {
                string value = "";
                //DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile);

                //write header rows to csv
                for (int i = 0; i <= dt.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(dt.Columns[i].ColumnName);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= dt.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    //dr = dt.Rows[j];

                    for (int i = 0; i <= dt.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dt.Rows[j].ItemArray[i].ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }
        }

        private void buttonCreateCsv_Click(object sender, EventArgs e)
        {
            // this is where you'd pull from a database -- pretend it s all !@#$%^& SPAGHETTI CODE!
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(1, "Mickey");
            dt.Rows.Add(2, "Minnie");
            dt.Rows.Add(3, "Donald");
            dt.Rows.Add(4, "Goofy");
            dt.Rows.Add(5, "Pluto");

            // write to CSV file -- maybe make it more dynamic
            writeCSV(dt, @"c:\ddd\disney.csv");
        }

        private void buttonMailCsv_Click(object sender, EventArgs e)
        {
            //TODO: find me a SMTP server
            //TODO: find SMTP code
            //TODO: create email with link to file (maybe somewhere on github?)
            MessageBox.Show("Emailed!");
        }

        ScriptRunner _scriptingService = new ScriptRunner();

        private void RunScript(string scriptName)
        {
            var result = _scriptingService.RunScript(scriptName);
            MessageBox.Show(result);
        }

        private void buttonScript_Click(object sender, EventArgs e)
        {
            //TODO: play around, to output something, maybe throw an error too?
            RunScript("firstscript.py");
        }

        private void buttonScript2_Click(object sender, EventArgs e)
        {
            //TODO: find ipy code to add something to a Word doc
            RunScript("secondscript.py");
        }

        private void buttonScript3_Click(object sender, EventArgs e)
        {
            //TODO: take a Word doc and email attachment
            RunScript("thirdscript.py");
        }
    }
}