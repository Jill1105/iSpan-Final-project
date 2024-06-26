﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class CarManagement
{
    public int Id { get; set; }

    public int Capacity { get; set; }

    public string Brand { get; set; }

    public string Goal { get; set; }

    public string CarModel { get; set; }

    public string CarIdentity { get; set; }

    public string ImgUrl { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<CarMaintenance> CarMaintenances { get; set; } = new List<CarMaintenance>();

    public virtual ICollection<CarRentCartItem> CarRentCartItems { get; set; } = new List<CarRentCartItem>();

    public virtual ICollection<CarRentOrderItem> CarRentOrderItems { get; set; } = new List<CarRentOrderItem>();

    public virtual ICollection<CarResponsible> CarResponsibles { get; set; } = new List<CarResponsible>();

    public virtual ICollection<CarTaxiCartItem> CarTaxiCartItems { get; set; } = new List<CarTaxiCartItem>();
}