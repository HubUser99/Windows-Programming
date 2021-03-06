﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_5
{
    class Hotel : IHotel
    {
        public string Name { get; private set; }
        public string ConstructionDate { get; private set; }
        public string Address { get; private set; }
        public int NumberOfStars { get; private set; }
        public List<Room> Rooms { get; private set; } = new List<Room>();
        public List<Customer> Customers { get; private set; } = new List<Customer>();

        public Hotel(string name, string constructionDate, string address, int numberOfStars)
        {
            this.Name = name;
            this.ConstructionDate = constructionDate;
            this.Address = address;
            this.NumberOfStars = numberOfStars;
        }

        public Hotel(string name, string constructionDate, string address, int numberOfStars, List<Room> rooms, List<Customer> customers)
        {
            this.Name = name;
            this.ConstructionDate = constructionDate;
            this.Address = address;
            this.NumberOfStars = numberOfStars;
            this.Rooms = new List<Room>(rooms);
            this.Customers = new List<Customer>(customers);
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("Construction date: " + this.ConstructionDate);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Number of stars: " + this.NumberOfStars);
            sb.AppendLine("Rooms: {");
            foreach (Room room in this.Rooms) {
                sb.AppendLine("-------------------------------");
                sb.Append(room.ToString());
                sb.AppendLine("-------------------------------");
            }
            sb.AppendLine("}");
            sb.AppendLine("Customers: {");
            foreach (Customer customer in this.Customers)
            {
                sb.AppendLine("-------------------------------");
                sb.Append(customer.ToString());
                sb.AppendLine("-------------------------------");
            }
            sb.AppendLine("}");
            
            return sb.ToString();
        }
    }
}
