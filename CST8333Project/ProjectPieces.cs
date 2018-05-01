namespace $safeprojectname$
{
    /// <summary>
    /// ProjectPieces.cs
    /// Created By: Jennifer Aube
    /// Date: February 13, 2018
    /// Purpose: Will create an object
    /// </summary>
    public class ProjectPieces
    {
        private string refDate;
        private string geo;
        private string commod;
        private string vector;
        private string coordinate;
        private string value;
        /// <summary>
        /// RefDate method will get and set the value
        /// </summary>
        public string RefDate { get => refDate; set => refDate = value; }
        /// <summary>
        /// Geo method will get and set the value
        /// </summary>
        public string Geo { get => geo; set => geo = value; }
        /// <summary>
        /// Commod method will get and set the value
        /// </summary>
        public string Commod { get => commod; set => commod = value; }
        /// <summary>
        /// Vector method will get and set the value
        /// </summary>
        public string Vector { get => vector; set => vector = value; }
        /// <summary>
        /// Coordinate will get and set the value
        /// </summary>
        public string Coordinate { get => coordinate; set => coordinate = value; }
        /// <summary>
        /// Value will get and set the value
        /// </summary>
        public string Value { get => value; set => this.value = value; }

        /// <summary>
        /// no-arg constructor
        /// </summary>
        public ProjectPieces() {    }
        /// <summary>
        /// contructor that will create an object with all variable
        /// </summary>
        /// <param name="rd">string refdate</param>
        /// <param name="g">string geo</param>
        /// <param name="c">string commod</param>
        /// <param name="ve">string vector</param>
        /// <param name="co">string coordinate</param>
        /// <param name="v">string value</param>
        public ProjectPieces(string rd, string g, string c, string ve, string co, string v)
        {
            RefDate = rd;
            Geo = g;
            Commod = c;
            Vector = ve;
            Coordinate = co;
            Value = v;
        }
    }
}
