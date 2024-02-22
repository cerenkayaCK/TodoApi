using System.ComponentModel.DataAnnotations;

namespace TodoApi.Dtos
{
    public class PostTodoItemDto
    {
        [Required]
        public string Title { get; set; } = null!;

        public bool Done { get; set; }
    }
}
