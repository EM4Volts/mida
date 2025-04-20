
namespace Tiger.Schema.Strings;

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "EF998080", 0x50)]
public struct SLocalizedStrings
{
    public ulong ThisSize;
    public SortedDynamicArray<SStringHash> StringHashes;
    // [DestinyField(FieldType.FileHash), MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
    // public StringData[] StringData;
    // [SchemaField(FieldType.FileHash)]  // only working with english rn for speed
    public LocalizedStringsData EnglishStringsData;    // actually StringData class
}

[SchemaStruct("70008080", 0x4)]
public struct SStringHash
{
    public StringHash StringHash;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F1998080", 0x48)]
public struct SLocalizedStringsData
{
    public long ThisSize;
    public DynamicArrayUnloaded<SStringPart> StringParts;
    // might be a colour table here

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<SStringCharacter> StringCharacters;
    public DynamicArrayUnloaded<SStringPartDefinition> StringCombinations;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F7998080", 0x20)]
public struct SStringPart
{
    [SchemaField(0x8)]
    public RelativePointer StringPartDefinitionPointer;    // this doesn't get accessed so no need to make this easy to access
    // public TigerHash Unk10;
    [SchemaField(0x14)]
    public ushort ByteLength;    // these can differ if multibyte unicode
    public ushort StringLength;
    public ushort CipherShift;    // now always zero
}

[SchemaStruct("05008080", 0x01)]
public struct SStringCharacter
{
    public byte Character;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F5998080", 0x10)]
public struct SStringPartDefinition
{
    public RelativePointer StartStringPartPointer;
    public long PartCount;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "02218080", 0x68)]
public struct S02218080
{
    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S0E3C8080> Unk28;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0E3C8080", 0x28)]
public struct S0E3C8080
{
    //[SchemaField(Tag64 = true)]
    //public Tag Unk00; // Always FFFFFFFF?

    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk10; // Can be string container or something else
}
