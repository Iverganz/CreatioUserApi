using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CreatioUserApi.Models
{
	/// <summary>
	/// Контакт.
	/// </summary>
	public class Contact
	{
		/// <summary>
		/// Id.
		/// </summary>
		[Required]
		public Guid Id { get; set; }

		/// <summary>
		/// ФИО.
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// Дата рождения.
		/// </summary>
		public DateTime? BirthDate { get; set; }

		/// <summary>
		/// Мобильный телефон.
		/// </summary>
		public string MobilePhone { get; set; }

		/// <summary>
		/// Почта.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Конструктор для инициализации пустыми значениями.
		/// </summary>
		public Contact()
		{
			Email = "";
			MobilePhone = "";
			BirthDate = null;
		}

		/// <summary>
		/// Объект администрирования.
		/// </summary>
		public List<SysAdminUnit> SysAdminUnits { get; set; }

	}
}
