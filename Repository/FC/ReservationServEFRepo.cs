﻿using HotelFuen31.APIs.Dtos.FC;
using HotelFuen31.APIs.Interfaces.FC;
using HotelFuen31.APIs.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelFuen31.APIs.Repository.FC
{
	public class ReservationServEFRepo : IReservationServRepo
	{
		private AppDbContext _db = new AppDbContext();
		public int Create(ReservationServiceDetailDto entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public ReservationServiceDetailDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<ReservationServiceDetailDto> Read()
		{
			var model = _db.ReservationServiceDetails
				.AsNoTracking()
				.Select(r => new ReservationServiceDetailDto
				{
					Id = r.Id,
					ServicesTypeId = r.ServicesTypeId,
					ServiceDetailName = r.ServiceDetailName,
					Time = r.Time,
					Price = r.Price,
					Description = r.Description,
					ImgUrl = r.ImgUrl,
				});

			return model;
		}

		public void Update(ReservationServiceDetailDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
