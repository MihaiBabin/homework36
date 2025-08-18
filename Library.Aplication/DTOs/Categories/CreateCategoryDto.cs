namespace Library.Aplication.DTOs.Categories
{
    public class CategoryDto : CreateCategoryDto
    {
        public int Id { get; set; }

        public int Books { get; init; }

        public override string ToString()
        {
            return $"CategoryId: {Id} \n" +
                   $"CategoryName: {Name}";
        }
    }
}