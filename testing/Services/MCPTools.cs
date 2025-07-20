namespace testing.Services;

using MCPSharp;
using testing.Interfaces;

public class MCPTools: IMCPTools
{
    [McpTool(name: "StudentCources", description: "This will return all student cources")]
    public async Task<List<Items>> GetStudentCources()
    {
        return new List<Items> {
            new Items { Name = "Math 101", Description = "Basic Mathematics" },
            new Items { Name = "History 201", Description = "World History" }
        };
    }

    [McpTool(name: "FacultyCources", description: "This will return all faculty cources")]
    public async Task<List<Items>> GetFacultyCources()
    {
        return new List<Items> {
            new Items { Name = "Physics", Description = "Basic Physics" },
            new Items { Name = "Biology", Description = "Basic Biology" }
        };
    }

    [McpTool(name: "StaffDuties", description: "This will return all Staff's duties")]
    public async Task<List<Items>> GetStaffDuties()
    {
        return new List<Items> {
            new Items { Name = "Teaching", Description = "Teaching at 10th std" }
        };
    }
}
