namespace CalculatorLibraries.History;

public class History
{
    public List<HistoryItem> Items { get; private set; } = new List<HistoryItem>();
    public bool CanUndo { get { return Items.Count > 0; } }
    public bool CanRedo { get { return Items.Count > 0 && CurrentOperation < Items.Count; } }
    public int CurrentOperation { get; private set; } = 0;

    public void Add(HistoryItem item)
    {
        Items = Items.Take(CurrentOperation).ToList();
        Items.Add(item);
        CurrentOperation++;
    }

    public void Undo()
    {
        if (!CanUndo)
            return;

        CurrentOperation--;
    }

    public void Redo()
    {
        if (!CanRedo)
            return;

        CurrentOperation++;
    }
}
