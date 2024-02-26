using CarBook.Application.Features.Mediator.Results.FeatureResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.FeatureQueries
{
	public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
	{
		public int Id { get; set; }

		public GetFeatureByIdQuery(int id)
		{
			Id = id;
		}

	}
}
