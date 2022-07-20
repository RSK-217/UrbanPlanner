using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner;

internal class Building
{
    public Building(string address, string designer)
    {
        _address = address;
        _designer = designer;
    }


    private string _designer;
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public int Stories { get; set; }
    public double Width { get; set; }   
    public double Height { get; set; }  
    public double Volume => Width * Height * (3*Stories);

    public void Construct()
    {
        _dateConstructed = DateTime.Now;
    }

    public void Purchase(string buyer)
    {
        _owner = buyer; 
    }

    internal string DisplayInfo()
    {
        return $@"
{_address}
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space
";
    }
}
