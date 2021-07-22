using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Habits;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
	public class HabitsController : BaseApiController
	{


		[HttpGet]
		public async Task<ActionResult<List<Habit>>> GetHabits()
		{
			return await Mediator.Send(new List.Query());
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Habit>> GetHabit(Guid id)
		{
			return await Mediator.Send(new Details.Query { Id = id });
		}

		[HttpPost]
		public async Task<IActionResult> CreateHabit(Habit habit)
		{
			return Ok(await Mediator.Send(new Create.Command { Habit = habit }));
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> EditHabit(Guid id, Habit habit)
		{
			habit.Id = id;
			return Ok(await Mediator.Send(new Edit.Command { Habit = habit }));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteHabit(Guid id)
		{
			return Ok(await Mediator.Send(new Delete.Command { Id = id }));
		}
	}
}