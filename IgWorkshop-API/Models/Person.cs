using System;
using System.ComponentModel.DataAnnotations;

namespace IgWorkshop.Models
{
  public class Person
  {
    [Key]
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }
  }
}
