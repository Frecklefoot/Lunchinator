using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Lunchinator.Data.Entities
{
	/// <summary>
	/// The definition for the Restaurant table.  (do not pluralize table names)
	/// </summary>
	[Table("Restaurant")]                               // DBA's prefer singular. (EF pluralizes by default)
	public class Restaurant
    {
		[Key]
		[Required]
		public int Id { get; set; }

		public int Count { get; set; }

		public int? HealthRating { get; set; }

		[Required]
		[Column(TypeName = "varchar(64)")]          // DBA's compained about using "nvarchar(max)" as default.
		public string Name { get; set; }

		[Required]
		public DateTime CreatedDate { get; set; }
	}
}