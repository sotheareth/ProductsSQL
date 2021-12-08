namespace Core.DTO
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
