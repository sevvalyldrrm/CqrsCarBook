using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarCommands
{
	public class RemoveCarCommand
	{
		public RemoveCarCommand(int id)
		{
			Id= id;
		}

		public int Id { get; set; }


	}
}
