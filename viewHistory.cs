using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics;

public class viewHistory
{
    public void viewBuyHistory(string name)
    {
        string[] filen = File.ReadAllLines("../../../buyHistory.csv");

        foreach (string line in filen)
        {
            if (line == "")
            {
                continue;
            }

            filen = line.Split(';');
            string itemname = filen[0];
            string item = filen[1];
            string price = filen[2];

            if (name == itemname)
            {
                Console.WriteLine(item + " " + price);
            }
        }
    }

}
