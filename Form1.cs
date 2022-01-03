using System;
using System.Windows;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelMacro
{
    public partial class Form1 : Form
    {
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        enum Trigger
        {
            Cancellation = 1,
            MTB = 2,
            Churn = 3

        };

        private void run_Click(object sender, EventArgs e)
        {

            if (path != null)
            {
                if (cancelbutt.Checked)
                {
                    macro_runner("Cancellation");
                }
                if (mtbbutt.Checked)
                {
                    macro_runner("BMT_Run");
                }
                if (churnbutt.Checked) 
                {

                    macro_runner("Churn_Prep");
                }
            }
            else
                System.Windows.MessageBox.Show("Please Select the Macro File","Notice");
        }

        private void macro_runner (string macroname)
        {
            //~~> Define your Excel Objects
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkBook;

            //~~> Start Excel and open the workbook.
            xlWorkBook = xlApp.Workbooks.Open(path);

            //~~> Run the macros by supplying the necessary arguments
            xlApp.Run(macroname);

            //~~> Clean-up: Close the workbook
            xlWorkBook.Close(false);

            //~~> Quit the Excel Application
            xlApp.Quit();

            //~~> Clean Up
            releaseObject(xlApp);
            releaseObject(xlWorkBook);
        }

        //~> Release the objects
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                System.Windows.MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void pathbutt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                FileName = "Select a Excel Macro file",
                Filter = "Macro files (*.xlsm)|*.xlsm",
                Title = "Open Excel Macro File file"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
            }
        }

    }
}

