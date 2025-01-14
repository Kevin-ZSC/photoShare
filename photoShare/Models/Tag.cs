namespace photoShare.Models
{
    public class Tag
    {
        //primary key
        public int TagId { get; set; }

        public string Name { get; set; } = string.Empty;

        // Foreign key
        public int PhotoId { get; set; }

        // Navigation property
        public Photo?Photo { get; set; } //nullable

    }

}
