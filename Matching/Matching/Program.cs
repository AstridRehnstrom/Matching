using System;
using Application;
using Microsoft.EntityFrameworkCore;

namespace Matching
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataInput.ClearDatabase();
            DataInput.AddPersonWithData();
            
        }
    }
}
