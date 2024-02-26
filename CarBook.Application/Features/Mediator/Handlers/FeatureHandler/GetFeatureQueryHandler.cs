using CarBook.Application.Features.Mediator.Results.FeatureQueries;
using CarBook.Application.Features.Mediator.Results.FeatureResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandler
{

	public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
	{
		private readonly IRepository<Feature> _repository;

		public GetFeatureQueryHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetFeatureQueryResult
			{
				FeatureID = x.FeatureID,
				Name = x.Name
			}).ToList();
		}
	}
}
