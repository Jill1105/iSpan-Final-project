﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class Member
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public bool IsConfirmed { get; set; }

    public string ConfirmCode { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string IdentityNumber { get; set; }

    public DateTime? BirthDay { get; set; }

    public bool Gender { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public bool Ban { get; set; }

    public int LevelId { get; set; }

    public virtual ICollection<CarRentCartItem> CarRentCartItems { get; set; } = new List<CarRentCartItem>();

    public virtual ICollection<CarRentOrderItem> CarRentOrderItems { get; set; } = new List<CarRentOrderItem>();

    public virtual ICollection<CarTaxiCartItem> CarTaxiCartItems { get; set; } = new List<CarTaxiCartItem>();

    public virtual ICollection<CarTaxiOrderItem> CarTaxiOrderItems { get; set; } = new List<CarTaxiOrderItem>();

    public virtual MemberLevel Level { get; set; }
}