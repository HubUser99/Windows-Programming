﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    interface ICustomer
    {
        string Name { get; }
        string Address { get; }
        string RoomNumber { get; }
        string ArrivalDate { get; }
        int LengthOfStay { get; }
    }
}
