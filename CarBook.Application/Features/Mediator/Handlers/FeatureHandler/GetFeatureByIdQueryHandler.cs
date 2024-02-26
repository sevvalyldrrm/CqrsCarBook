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
	public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
	{
		private readonly IRepository<Feature> _repository;

		public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetFeatureByIdQueryResult
			{
				FeatureID = values.FeatureID,
				Name = values.Name
			};
		}
	}
}
