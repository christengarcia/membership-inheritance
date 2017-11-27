using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membership_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

class Member
{
    protected int annualFee;
    private string name;
    private int memberID;
    private int memberSince;
}

public override string ToString()
{
    return "\name: " + name + "\nMember ID: " + memberID
                              + "\nMember Since: " + memberSince
                              + "\nTotal Annual Fee: " + annualFee; 
}

