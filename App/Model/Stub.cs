namespace SME.Model;

public record Stub
{
    public int Id { get; set; }
    public string? Uri { get; set; }

    public string Text()
    {
        throw new NotImplementedException();
    }
}