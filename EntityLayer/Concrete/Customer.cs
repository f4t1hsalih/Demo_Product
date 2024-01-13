namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }

        //İlişki kurmak için gerekli olan kodlar
        public int JobID { get; set; }
        public Job? Job { get; set; }
    }
}
