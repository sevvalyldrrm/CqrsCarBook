using CarBook.Application.Features.Mediator.Results.FeatureResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.FeatureQueries
{
	public class GetFeatureQuery :IRequest<List<GetFeatureQueryResult>>
	{
	}
}
