using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace $safeprojectname$
{
    /// <summary>
    /// Database.cs
    /// Create By: Jennifer Aube
    /// Modified on: March 20, 2018
    /// Purpose: Opens the database to insert and select from table
    /// </summary>
    public class Database
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand sqlcommand;
        DataGridView gridView;
        ToolStripLabel label;
        ToolStripProgressBar bar;
        Button loadBtn;
        List<ProjectPieces> arrayList = new List<ProjectPieces>();
        
        /// <summary>
        /// constructor that initializes the datagridview and toolstrip label from main window form
        /// </summary>
        /// <param name="gridV">DataGridView</param>
        /// <param name="stripLabel">ToolStripLabel</param>
        public Database(DataGridView gridV, ToolStripLabel stripLabel, List<ProjectPieces> l)
        {
            gridView = gridV;
            label = stripLabel;
            arrayList = l;
        }
        /// <summary>
        /// no arg constructor
        /// </summary>
        public Database()
        {
        }
        /// <summary>
        /// openDatabase() method opens the database connection, and creates the table ProjectTable
        /// </summary>
        public void openDatabase()
        {        
            connection.ConnectionString = "Data Source=POMPOM-JA051086;Initial Catalog=ProjectDB;Integrated Security=True";
            connection.Open();
            openSqlCommand();
            sqlcommand.CommandText = "DROP TABLE ProjectTable";
            sqlcommand.ExecuteNonQuery();

            sqlcommand.CommandText = "CREATE TABLE ProjectTable (Ref_Date char(10), Geo char(20), Commod varchar(300), " +
                "Vector char(25), Coordinate char(10), Value char(10))";
            sqlcommand.ExecuteNonQuery();
        }       
        
        /// <summary>
        /// InsertProjectPieces() method will insert the object ProjectPieces from List and will insert into database table
        /// </summary>
        /// <param name="list">List</param>
        public void InsertProjectPieces()
        {
            openDatabase();            
            openSqlCommand();
            for (int i = 0; i < arrayList.Count-1; i++)
            {                
                    string refdate = arrayList[i].RefDate;
                    string geo = arrayList[i].Geo;
                    string commod = arrayList[i].Commod;
                    string vector = arrayList[i].Vector;
                    string coordinate = arrayList[i].Coordinate;
                    string value = arrayList[i].Value;
                    sqlcommand.CommandText = "INSERT INTO ProjectTable ([Ref_Date], [Geo], [Commod], [Vector], [Coordinate], [Value]) VALUES ('"
                                + refdate + "', '" + geo + "', '" + commod + "', '" + vector + "', " + coordinate + ", " + value + ")";
                    sqlcommand.ExecuteNonQuery();            
            }
        }
        /// <summary>
        /// selectAll() method will create a sql query to select all the columns from database table and show in datagridview
        /// </summary>
        public void selectAll()
        {          
            SqlCommand command = new SqlCommand("Select Ref_Date, Geo, Commod, Vector, Coordinate, " +
                "Value From ProjectTable", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);            
            gridView.DataSource = table;
            gridView.Update();           
            gridView.Refresh();            
            label.Text = "Showing the dataset concerning Beverage and Tobacco and tobacco products";
        }
        /// <summary>
        /// openSqlCommand() method will initialized the SqlCommand
        /// </summary>
        public void openSqlCommand()
        {
            sqlcommand = connection.CreateCommand();
        }
        /// <summary>
        /// query() method will create a sql query and output results in the datagridview
        /// </summary>
        /// <param name="query">string query</param>
        public void query(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            gridView.DataSource = table;            
        }
    }
}
