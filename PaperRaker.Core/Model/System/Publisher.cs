namespace PaperRaker.Core.Model.System
{
    /// <inheritdoc />
    /// <summary>
    /// Identifies a Publisher who prints and releases Paper works
    /// </summary>
    public class Publisher : BaseEntity
    {
        public int PublisherId { get; set; }
        
        public string Name { get; set; }
        
        public string City { get; set; }
        public string Country { get; set; }
    }
}