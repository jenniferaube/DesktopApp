using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace $safeprojectname$
{
    /// <summary>
    /// StatisticsForm.cs
    /// Created By: Jennifer Aube
    /// Modified on: April 11, 2018
    /// Purpose: Open window to show statistics from the dataset
    /// </summary>
    public partial class StatisticsForm : Form
    {        
        List<ProjectPieces> list = new List<ProjectPieces>();
        /// <summary>
        /// Opens and initiates the statistics window
        /// populates the bar graph
        /// </summary>
        /// <param name="l"></param>
        public StatisticsForm(List<ProjectPieces> l)
        {
            InitializeComponent();
            list = l;
            ChartArea chartArea = new ChartArea() { Name = "ChartArea" };
            Dictionary<string, int> count = new Dictionary<string, int>();
            /*The following for loop seperates all the commodities and counts them, then puts the values into result*/
            for(int item = 0; item < list.Count; item++)
            {
                if (!count.ContainsKey(list[item].Commod))
                {
                    count[list[item].Commod] = 0;
                }
                count[list[item].Commod]++;
            }            
            int x = 0;
            int y = 0;
            foreach (var item in count) {
                y = item.Value;
                chart1.Series[item.Key].Points.AddXY(x, y);
                chart1.Series[item.Key].ChartType = SeriesChartType.Column;              
            }           
        }       
    }
}
