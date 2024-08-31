using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models.Model;

public class TodoTask
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Text { get; set; }
    public string? Description { get; set; }
    [Required]
    public bool isComplete { get; set; }

}