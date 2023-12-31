﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
	public class Car : IVechicle
	{
		public int bookingID { get; set; }
		public string regNumber { get; set; }
		public string brand { get; set; }
		public int odometer { get; set; }
		public double costPerKm { get; set; }
		public int costPerDay { get; set; }
		public VechicleTypes vechicleType { get; set; }
		public VechicleStatuses status { get; set; }

		public Car(string RegNumber, string Brand, int Odometer, double CostPerKm, VechicleTypes VechicleType, int CostPerDay)
		{
			regNumber = RegNumber;
			brand = Brand;
			odometer = Odometer;
			costPerKm = CostPerKm;
			vechicleType = VechicleType;
			costPerDay = CostPerDay;
			status = VechicleStatuses.Available;
		}	
	}
}
