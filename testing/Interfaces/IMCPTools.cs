namespace testing.Interfaces;

public interface IMCPTools
{
    Task<List<Items>> GetStudentCources();
    Task<List<Items>> GetFacultyCources();
    Task<List<Items>> GetStaffDuties();
}

public class Items
{
    public string Name { get; set; }
    public string Description { get; set; }
}
