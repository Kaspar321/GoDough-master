using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GoDough
{
    public class User
    {
        public int Balance { get; set; }

        public User(int balance)
        {
            this.Balance = balance;
        }
    }
}