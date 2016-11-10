using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.Lunchinator.Data.Entities
{
	[Table("Preference")]                               // DBA's prefer singular. (EF pluralizes by default)
	public class Preference
    {
		[Key]
		[Required]
		public int Id { get; set; }

		public Person Person { get; set; }

		public Restaurant Restaurant { get; set; }
	}
}