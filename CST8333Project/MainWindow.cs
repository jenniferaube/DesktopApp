using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace $safeprojectname$
{
    /// <summary>
    /// MainWindow.cs
    /// Created By: Jennifer Aube
    /// Modified on: April 11, 2018
    /// Purpose: Open the main window form for GUI
    /// 
    /// </summary>
    public partial class MainWindow : Form
    {
        Database db;
        List<ProjectPieces> arrayList = new List<ProjectPieces>();
        /// <summary>
        /// Opens and initializes the main window form
        /// Opens the FileOpener 
        /// </summary>
        public MainWindow(List<ProjectPieces> list)
        {
            
            string fileName = "D:/03290040-eng.csv";             
            InitializeComponent();
            arrayList = list;
            tsLabel.Text = fileName + " file is open";
            db = new Database(gridView, tsLabel, arrayList);
            this.Refresh();

            Thread t = new Thread(new ThreadStart(db.InsertProjectPieces));
            try
            {
                t.IsBackground = true;
                t.Start();                
            }
            catch (ThreadStateException et)
            {
                Console.WriteLine(et.ToString());
            }            
        }
        /// <summary>
        /// loadBtn_Click() method handles event when user clicks the Load button in main window form
        /// Event: loads the database with the file contents, and outputs the database table in the datagridview
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void loadBtn_Click_1(object sender, EventArgs e)
        {
            loadBtn.Visible = false; //Load button will disapper, no more use for it
            db.selectAll();            
            toolStrip1.Visible = true; //ToolStrip will appear for user to interact with database table 
            licenseLink.Visible = true;
            sourceLink.Visible = true;
            gridView.Visible = true; //DataGridView will appear for user to view the database table
        }
        /// <summary>
        /// statsBtn_Click() method handles the event when user clicks the Statistics button in main window form
        /// Event: opens the StatisticsForm window
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void statsBtn_Click(object sender, EventArgs e)
        {
            StatisticsForm statsform = new StatisticsForm(arrayList);
            statsform.Show();
        }
        /// <summary>
        /// showAllBtn_Click() method handles the event when the user clicks Show All button in the main window form
        /// Event: will show the entire table ProjectTable from database
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void showAllBtn_Click(object sender, EventArgs e)
        {            
            db.selectAll();
            this.Refresh();
        }
        /// <summary>
        /// columnBtn_Click() method handles the event when user click the button that will select a column to view from table
        /// Event: will show just the one column the user wishes to view
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void columnBtn_Click(object sender, EventArgs e)
        {            
            string columnName = dropDown.Text;
            string query = "Select " + columnName + " From ProjectTable";            
            db.query(query);
            tsLabel.Text = "Showing " + columnName + " column";
        }
        /// <summary>
        /// findBtn_Click() method handles the event when the user clicks the button that will search for a word in the table
        /// Event: will show just the rows in the table that contain the word the user entered
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void findBtn_Click(object sender, EventArgs e)
        {
            string word = findText.Text;
            string column = columnDropDown.Text;
            string query = "";
            if (column == "Select column")
            {
                MessageBox.Show("Please select a column to search word from");
            }
            else
            {
                query = "Select * From ProjectTable Where " + column + " LIKE '%" + word + "%'";
                db.query(query);
                findText.Text = "";
                tsLabel.Text = "Showing only rows with the word '" + word + "' in column " + column;
            }
            
        }
        /// <summary>
        /// licenceLink_LinkClicked method will when clicked on will take user to the license page of the database set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://open.canada.ca/en/open-government-licence-canada");
        }
        /// <summary>
        /// sourceLink_LinkClicked method will when clicked take user to the source page of the database set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://open.canada.ca/data/en/dataset/e8a4c5ec-4e75-4050-8a11-f13bef3bb357");
        }
    }
}
