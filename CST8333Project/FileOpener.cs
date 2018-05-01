using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    /// <summary>
    /// Multithreading.cs
    /// Create By: Jennifer Aube
    /// Modified on: March 20, 2018
    /// Purpose: Open and read file then insert into a List<ProjectPieces> using BlockingCollection
    /// dataset "03290040-eng.csv" was found on https://open.canada.ca/data/en/dataset/e8a4c5ec-4e75-4050-8a11-f13bef3bb357
    /// </summary>
    public class FileOpener
    {
       
        List<ProjectPieces> list = new List<ProjectPieces>();
        List<ProjectPieces> drinksAndSmokes = new List<ProjectPieces>();
        /// <summary>
        /// openFile() method will open and read the contents of the file 
        /// </summary>
        /// <returns></returns>
        public List<ProjectPieces> openFile()
        {
            try
            {
                string fileName = "D:/03290040-eng.csv";
                StreamReader reader = new StreamReader(fileName);
                string[] line = new string[System.IO.File.ReadAllLines(fileName).Length];
                line = reader.ReadLine().Split(',');
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine().Split(',');
                    string refdate = line[0];
                    string geo = line[1];
                    string commod = line[2];
                    string vector = line[3];
                    string coordinate = line[4];
                    string value = line[5];
                    list.Add(new ProjectPieces(refdate, geo, commod, vector, coordinate, value));
               }
                reader.Close();//closes the streamreader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
                throw;
            }
            for(int j = 0; j < list.Count()-1; j++)
            {
                if (list[j].Commod.Contains("beverage")|| list[j].Commod.Contains("alcoholic")|| list[j].Commod.Contains("drink")||
                    list[j].Commod.Contains("tobacco")|| list[j].Commod.Contains("cigarettes")|| list[j].Commod.Contains("whiskey"))
                {
                    
                    string refdate = list[j].RefDate;
                    string geo = list[j].Geo;
                    string commod = list[j].Commod;
                    string vector = list[j].Vector;
                    string coordinate = list[j].Coordinate;
                    string value = list[j].Value;
                    drinksAndSmokes.Add(new ProjectPieces(refdate, geo, commod, vector, coordinate, value));
                }
            }
            return drinksAndSmokes;
        }
       
    }

}