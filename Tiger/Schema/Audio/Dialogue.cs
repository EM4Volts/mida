namespace Tiger.Schema.Audio;

public class Dialogue : Tag<SDialogueTable>
{
    public Dialogue(FileHash hash) : base(hash)
    {

    }

    /// <summary>
    /// Generates a nested list of different sequences of audio, collapsing redundant structures.
    /// </summary>
    /// <returns>A dynamic list of S33978080, in lists of their sequence and structure.</returns>
    public List<dynamic?> Load()
    {
        List<dynamic?> result = new();
        foreach (var entry1 in _tag.Unk18)
        {
            foreach (var u in _tag.Unk18)
            {
                var entry = u.Unk08.GetValue(GetReader());
                switch (entry)
                {
                    case S2D978080:
                        List<dynamic?> res2d = Collapse2D97(entry);
                        if (res2d.Count > 0)
                        {
                            result.Add(res2d.Count > 1 ? res2d : res2d[0]);
                        }
                        break;
                    case S2A978080:
                        List<dynamic?> res2a = Collapse2A97(entry);
                        if (res2a.Count > 0)
                        {
                            result.Add(res2a.Count > 1 ? res2a : res2a[0]);
                        }
                        break;
                    case S33978080:
                        result.Add(entry);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        return result;
    }

    private List<dynamic?> Collapse2D97(S2D978080 entry)
    {
        List<dynamic?> sounds = new();
        foreach (dynamic? e in entry.Unk20.Select(u => u.Unk20.GetValue(GetReader())))
        {
            switch (e)
            {
                case S2A978080:
                    List<dynamic?> result = Collapse2A97(e);
                    if (result.Count > 0)
                    {
                        sounds.Add(result.Count > 1 ? result : result[0]);
                    }
                    break;
                case S33978080:
                    sounds.Add(e);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        return sounds;
    }

    private List<dynamic?> Collapse2A97(S2A978080 entry)
    {
        List<dynamic?> sounds = new();

        // todo GetReader() here is wrong
        // todo do a performance comparison of using the manual GetReader vs loading automatically and ignoring it
        foreach (var e in entry.Unk28.Select(u => u.Unk40.GetValue(GetReader())))
        {
            switch (e)
            {
                case S2A978080:
                    List<dynamic?> result = Collapse2A97(e);
                    if (result.Count > 0)
                    {
                        sounds.Add(result.Count > 1 ? result : result[0]);
                    }
                    break;
                case S2D978080:
                    List<dynamic?> result2 = Collapse2D97(e);
                    if (result2.Count > 0)
                    {
                        sounds.Add(result2.Count > 1 ? result2 : result2[0]);
                    }
                    break;
                case S33978080:
                    sounds.Add(e);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        return sounds;
    }
}
