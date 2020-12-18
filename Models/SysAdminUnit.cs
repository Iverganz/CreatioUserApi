using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreatioUserApi.Models
{
	/// <summary>
	/// Пользователь.
	/// </summary>
	public class SysAdminUnit
	{
		/// <summary>
		/// Идентификатор пользователя.
		/// </summary>
		[Required]
		public Guid Id { get; set; }

		[Required]
		/// <summary>
		/// Имя пользователя.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Тип пользователя.
		/// </summary>
		public int SysAdminUnitTypeValue { get; set; }

		/// <summary>
		/// Активен ли пользователь.
		/// </summary>
		public bool Active { get; set; }

		/// <summary>
		/// Контакт пользователя.
		/// </summary>
		public Guid ContactId { get; set; }


		/// <summary>
		/// Контакт.
		/// </summary>
		[ForeignKey("ContactId")]
		public Contact Contact { get; set; }
	}
}
