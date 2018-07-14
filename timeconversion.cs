using System;

class Solution
{
    static string timeConversion(string s)
    {
        string hh, mm, ss, sub, ret;
        ret = "";
        sub = s.Substring(8);
        hh = s.Substring(0, 2);
        mm = s.Substring(3, 2);
        ss = s.Substring(6, 2);
        if (sub == "PM")
        {
            if (hh == "12")
            {
                ret = hh + ":" + mm + ":" + ss;
            }
            else
            {
                int hh1=int.Parse(hh) + 12; 
                ret = hh1.ToString()+ ":" + mm + ":" + ss;
            }
        }

        if (sub == "AM")
        {
            if (hh == "12")
            {
                ret = "00" + ":" + mm + ":" + ss;
            }
            else
            {
                ret = hh + ":" + mm + ":" + ss;
            }
        }
        return ret;
    }

    static void Main(string[] args)
    {	
	Console.WriteLine("Enter 12hr time format ex. hh:mm:ssAM/PM \n");
        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);
    }
}
