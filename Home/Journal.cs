using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Journal
    {
        public int NumberOfPeople { get; set; }
        public Journal() { }
        public Journal(int num) { 
            this.NumberOfPeople = num;
        }
        public static Journal operator +(Journal a, int b)
        {
            Journal res = new Journal();
            res.NumberOfPeople = a.NumberOfPeople + b;
            return res;
        }
        public static Journal operator -(Journal a, int b)
        {
            Journal res = new Journal();
            res.NumberOfPeople = a.NumberOfPeople - b;
            return res;
        }
        public static bool operator ==(Journal a, Journal b)
        {
            return a.NumberOfPeople == b.NumberOfPeople;
        }
        public static bool operator !=(Journal a, Journal b)
        {
            return a.NumberOfPeople != b.NumberOfPeople;
        }
        public static bool operator <(Journal a, Journal b)
        {
            return a.NumberOfPeople < b.NumberOfPeople;
        }
        public static bool operator >(Journal a, Journal b)
        {
            return a.NumberOfPeople > b.NumberOfPeople;
        }
        public override bool Equals(object obj)
        {
            if(obj is Journal a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
