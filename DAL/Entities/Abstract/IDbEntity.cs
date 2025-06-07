using System.ComponentModel.DataAnnotations;

namespace DAL.Entities.Abstract;

public interface IDbEntity
{
    [Key]
    int Id { get; set; }
}
