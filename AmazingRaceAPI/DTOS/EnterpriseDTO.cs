namespace AmazingRaceAPI.DTOS
{
    public class EnterpriseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public string? PicFileName { get; set; }
        public byte[]? PicData { get; set; }
    }
}
