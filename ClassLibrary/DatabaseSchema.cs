namespace ClassLibrary;

/// <summary>
/// Contains the entire database schema
/// </summary>
public class DatabaseSchema
{
    public List<TableSchema> Tables = [];
    public List<ViewSchema> Views = [];
}