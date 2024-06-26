#nullable disable
namespace ClassLibrary;

/// <summary>
/// Contains the schema of a single DB column.
/// </summary>
public class ColumnSchema
{
    public string ColumnName;

    public string ColumnType;

    public int Length;

    public bool IsNullable;

    public string DefaultValue;

    public bool IsIdentity;

    public bool? IsCaseSensitivite = null;
}