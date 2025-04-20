namespace Tiger.Schema.Audio;

[SchemaStruct("B8978080", 0x28)]
public struct SDialogueTable
{
    public long FileSize;
    public DynamicArray<S28978080> Unk08;
    public DynamicArray<S29978080> Unk18;
}

[SchemaStruct("28978080", 8)]
public struct S28978080
{
    public TigerHash Unk00;
}

[SchemaStruct("29978080", 0x10)]
public struct S29978080
{
    public TigerHash Unk00;
    [SchemaField(0x8)]
    public ResourcePointer Unk08;
}

/// <summary>
/// Group of S33978080, used for accessing random sounds to play out of a bundle.
/// </summary>
[SchemaStruct("2F978080", 0x48)]
public struct S2F978080
{
    [SchemaField(0x10, Tag64 = true)]
    public Tag Unk10;
    //[SchemaField(0x1C)]
    public TigerHash Unk20;
    public TigerHash Unk24;
    public TigerHash Unk28;
    public TigerHash Unk2C;
    [SchemaField(0x38)]
    public float Unk38;
    [SchemaField(0x40)]
    public ResourcePointer Unk40; // 2A978080, 2D978080
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "2A978080", 0x38)]
public struct S2A978080
{
    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S2F978080> Unk28;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "33978080", 0x8C)]
public struct S33978080
{
    // Male
    [SchemaField(0x18, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public WwiseSound SoundM;

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public StringReference64 VoicelineM;

    // Female
    [SchemaField(0x48, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public WwiseSound SoundF;

    [SchemaField(0x58, TigerStrategy.MARATHON_ALPHA)]
    public StringReference64 VoicelineF;

    [SchemaField(0x7C, TigerStrategy.MARATHON_ALPHA)]
    public StringHash NarratorString;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "2D978080", 0x30)]
public struct S2D978080
{
    [SchemaField(0x20, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S30978080> Unk20;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "30978080", 0x28)]
public struct S30978080
{
    [SchemaField(Tag64 = true)]
    public Tag Unk00;
    public TigerHash Unk10;
    public TigerHash Unk14;
    public TigerHash Unk18;
    public TigerHash Unk1C;
    public ResourcePointer Unk20; //33978080 or 2A978080
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "38978080", 0x38)]
public struct S38978080
{
    public long FileSize;
    public StringHash SoundbankName;

    [SchemaField(0x18, TigerStrategy.MARATHON_ALPHA)]
    public Tag<S63838080> Soundbank;

    [SchemaField(0x20, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<Wem> Wems;
}

[SchemaStruct("418A8080", 0x38)]
public struct S418A8080
{
    public long Unk00;
    public float Unk08;
}

[SchemaStruct("63838080", 4)]
public struct S63838080
{
    public BKHD SoundBank;
}

[SchemaStruct("438A8080", 0x28)]
public struct S438A8080
{
    public long FileSize;
}





