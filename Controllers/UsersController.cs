using CreatioUserApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatioUserApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly CreatioUserApiContext _context;

		/// <summary>
		/// Конструктор с передачей подключения к БД.
		/// </summary>
		/// <param name="context">Контекст БД.</param>
		public UsersController(CreatioUserApiContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		/// <summary>
		/// Получение пользователей.
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public ActionResult<List<SysAdminUnit>> Get()
		{
			return new ObjectResult(_context.SysAdminUnit.Where(u => u.SysAdminUnitTypeValue == 4).ToList());
		}

		/// <summary>
		/// Получение информации о пользователе.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public ActionResult<SysAdminUnit> Get(Guid id)
		{
			if (id == Guid.Empty)
			{
				return BadRequest(new ArgumentNullException(nameof(id)));
			}

			var user = _context.SysAdminUnit.Where(u => u.Id == id && u.SysAdminUnitTypeValue == 4).FirstOrDefault();

			return user != null ? new ObjectResult(user) : NotFound();
		}

		/// <summary>
		/// Добавление пользователя.
		/// </summary>
		/// <param name="sysAdminUnit"></param>
		/// <returns></returns>
		[HttpPost]
		public ActionResult Post(SysAdminUnit sysAdminUnit)
		{
			if (sysAdminUnit == null)
			{
				return BadRequest(new ArgumentNullException(nameof(sysAdminUnit)));
			}

			_context.Add(sysAdminUnit);
			return Ok(sysAdminUnit);
		}

		/// <summary>
		/// Деактивация пользователя.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpDelete("{id}")]
		public ActionResult Delete(Guid id)
		{
			if (id == Guid.Empty)
			{
				return BadRequest(new ArgumentNullException(nameof(id)));
			}

			var user = _context.SysAdminUnit.Where(u => u.Id == id && u.SysAdminUnitTypeValue == 4).FirstOrDefault();
			user.Active = false;
			_context.SaveChanges();
			return user != null ? Ok(user) : NotFound();
		}
	}
}
