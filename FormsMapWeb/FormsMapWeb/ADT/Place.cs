using System;

public class Place
{
    public string info { set; get; }
    public double lat { set; get; }
    public double Long { set; get; }
    public string name { set; get; }
    public string imageUrl { set; get; }
    override
    public string ToString()
    {
<<<<<<< Updated upstream
        return name + "\t" + info + "\n" + lat + "\t" + Long;
=======
        public string info { set; get; }
        public double lat { set; get; }
        public double Long { set; get; }
        public string name { set; get; }
        public string imageURL { set; get; }

        override
        public string ToString()
        {
            return name + "\t Lat:" + lat + " - Long: " + Long;
        }
        public string getUbicacion()
        {
            return @"https://www.google.com/maps/@" + lat.ToString().Replace(",", ".") + "," + Long.ToString().Replace(",", ".") + ",25z";
        }

        public string getImageLink() {
            return @"< a href = " + imageURL + " > imagen </ a >";
        }
>>>>>>> Stashed changes
    }
}