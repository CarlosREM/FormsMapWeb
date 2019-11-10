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
        return name + "\t" + info + "\n" + lat + "\t" + Long;
    }
}