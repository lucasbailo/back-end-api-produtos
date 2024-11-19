namespace InternshipTestDB.Models
{
    public class ProdutoClass
    {
        public int ID { get; set; }
        public string? nome { get; set; }
        public float custo { get; set; }
        public float venda { get; set; }
        public int quantidade { get; set; }

        public int isActive { get; set; }
    }
}
