﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class HallMenuSchedule
{
    public int Id { get; set; }

    public int HallOrderItemId { get; set; }

    public int HallMenuId { get; set; }

    public virtual HallMenu HallMenu { get; set; }

    public virtual HallOrderItem HallOrderItem { get; set; }
}