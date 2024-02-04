using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarRepositories
{
	public class CarRepository : ICarRepository
	{
		private readonly CarBookContext _context;

		public CarRepository(CarBookContext context)
		{
			_context = context;
		}
		public List<Car> GetCarsListWithBrands()
		{
			var values = _context.Cars.Include(x => x.Brand).ToList();
			return values;
		}

		async Task<List<Car>> ICarRepository.GetCarsListWithBrands()
		{
			var values = await _context.Cars.Include(x => x.Brand).ToListAsync();
			return values;
		}
	}
}