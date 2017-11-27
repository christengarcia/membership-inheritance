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


    public override string ToString()
    {
        return "\name: " + name + "\nMember ID: " + memberID
                                  + "\nMember Since: " + memberSince
                                  + "\nTotal Annual Fee: " + annualFee;
    }

    public Member()
    {
        Console.WriteLine("Parent Constructor with no parameter");
    }

    public Member(string pName, int pMemberID, int pMemberSince)
    {
        Console.WriteLine("Parent Constructor with 3 parameters");

        name = pName;
        pMemberID = pMemberID;
        pMemberSince = pMemberSince;
    }
}