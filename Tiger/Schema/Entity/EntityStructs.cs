using Tiger.Schema.Audio;
using Tiger.Schema.Investment;
using Tiger.Schema.Model;
using Tiger.Schema.Shaders;

namespace Tiger.Schema.Entity;

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D89A8080", 0x98)]
public struct SEntity
{
    public long FileSize;

    [SchemaField(0x08, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<D2Class_CD9A8080> EntityResources;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F09A8080", 8)]
public struct D2Class_F09A8080
{
    public TigerHash Unk00;
    public ushort Unk04;
    public ushort Unk06;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "ED9A8080", 0x28)]
public struct D2Class_ED9A8080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "EB9A8080", 0x18)]
public struct D2Class_EB9A8080
{
}

[SchemaStruct("06008080", 0x2)]
public struct S06008080
{
    public short Unk0;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CD9A8080", 0xC)]
public struct D2Class_CD9A8080  // entity resource entry
{
    public FileHash Resource; // Can sometimes be a non-entity resource in D1, for whatever reason
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "069B8080", 0xA0)]
public struct D2Class_069B8080  // Entity resource
{
    public long FileSize;

    [SchemaField(0x10)]
    public ResourcePointer Unk10; // this isnt any of the ones in Entity.Load in beyond light
    public ResourcePointer Unk18;

    [SchemaField(0x80, TigerStrategy.MARATHON_ALPHA)]
    public Tag UnkHash80;
}


/*
 * The external material map provides the mapping of external material index -> material tag
 * could be these external materials are dynamic themselves - we'll extract them all but select the first
 */
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "8F6D8080", 0x450)]
public struct D2Class_8F6D8080
{
    [SchemaField(0x224, TigerStrategy.MARATHON_ALPHA)]
    public EntityModel Model;

    [SchemaField(0x310, TigerStrategy.MARATHON_ALPHA)]
    public Tag<D2Class_1C6E8080> TexturePlates;

    [SchemaField(0x3C0, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<SExternalMaterialMapEntry> ExternalMaterialsMap;

    [SchemaField(0x3F0, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<D2Class_986D8080> Unk3F0;

    [SchemaField(0x400, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<D2Class_14008080> ExternalMaterials;
}

// Physics model resource, same layout as normal model resource?
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "6C6D8080", 0x480)]
public struct D2Class_6C6D8080
{
    [SchemaField(0x224, TigerStrategy.MARATHON_ALPHA)]
    public EntityModel PhysicsModel;

    [SchemaField(0x3C0, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<SExternalMaterialMapEntry> ExternalMaterialsMap;

    [SchemaField(0x400, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<D2Class_14008080> ExternalMaterials;
}

#region Texture Plates

/// <summary>
/// Texture plate header that stores all the texture plates used for the EntityModel.
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "1C6E8080", 0x38)]
public struct D2Class_1C6E8080
{
    public long FileSize;

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public TexturePlate AlbedoPlate;
    public TexturePlate NormalPlate;
    public TexturePlate GStackPlate;
    public TexturePlate DyemapPlate;
}

/// <summary>
/// Texture plate that stores the data for placing textures on a canvas.
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "919E8080", 0x20)]
public struct D2Class_919E8080
{
    public long FileSize;
    [SchemaField(0x10)]
    public DynamicArrayUnloaded<D2Class_939E8080> PlateTransforms;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "939E8080", 0x14)]
public struct D2Class_939E8080
{
    public Texture Texture;
    public IntVector2 Translation;
    public IntVector2 Scale;
}

#endregion

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "986D8080", 0x8)]
public struct D2Class_986D8080
{
    public ushort Unk00;
    public ushort Unk02;
    public ushort Unk04;
    public ushort Unk06;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "976D8080", 0xC)]
public struct SExternalMaterialMapEntry
{
    public int MaterialCount;
    public int MaterialStartIndex;
    public int Unk08;  // maybe some kind of LOD or dynamic marker
}

[SchemaStruct("14008080", 0x4)]
public struct D2Class_14008080
{
    public Material Material;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "8A6D8080", 0x2E0)]
public struct D2Class_8A6D8080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DD818080", 0x100)]
public struct D2Class_DD818080
{
    [SchemaField(0x30)]
    public DynamicArray<D2Class_DC818080> Unk30;
    public DynamicArray<D2Class_40868080> Unk40;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DC818080", 0x40)]
public struct D2Class_DC818080
{
    [SchemaField(0x20, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_4F9F8080> Unk20;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "4F9F8080", 0x20)]
public struct D2Class_4F9F8080
{
    public Tiger.Schema.Vector4 Rotation;
    public Tiger.Schema.Vector4 Translation;
}

[SchemaStruct("40868080", 8)]
public struct D2Class_40868080
{
    public ushort Unk00;
    public ushort Unk02;
    public uint Unk04;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DE818080", 0x108)]
public struct D2Class_DE818080
{
    [SchemaField(0x88, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash Unk88;
    public TigerHash Unk8C;  // this is actually zeros in SK


    [SchemaField(0x90, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<D2Class_42868080> NodeHierarchy;
    public DynamicArrayUnloaded<D2Class_4F9F8080> DefaultObjectSpaceTransforms;
    public DynamicArrayUnloaded<D2Class_4F9F8080> DefaultInverseObjectSpaceTransforms;
    public DynamicArrayUnloaded<S06008080> RangeIndexMap;
    public DynamicArrayUnloaded<S06008080> InnerIndexMap;

    [SchemaField(TigerStrategy.MARATHON_ALPHA)]
    public Vector4 UnkE0;

    [SchemaField(0xF0, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<D2Class_E1818080> UnkF0; // lod distance?
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "42868080", 0x10)]
public struct D2Class_42868080
{
    public TigerHash NodeHash;
    public int ParentNodeIndex;
    public int FirstChildNodeIndex;
    public int NextSiblingNodeIndex;
}

[SchemaStruct("E1818080", 0x18)]
public struct D2Class_E1818080
{
    public ResourceInTagPointer Unk00;
    public long Unk10;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "076F8080", 0xA0)]
public struct SEntityModel  // Entity model
{
    public long FileSize;
    [SchemaField(0x10)]
    public DynamicArrayUnloaded<SEntityModelMesh> Meshes;

    [SchemaField(0x20)]
    public Vector4 Unk20;
    public long Unk30;

    [SchemaField(0x38)]
    public long UnkFlags38;

    [SchemaField(0x50, TigerStrategy.MARATHON_ALPHA)]
    public Vector4 ModelScale;
    public Vector4 ModelTranslation;
    public Vector2 TexcoordScale;
    public Vector2 TexcoordTranslation;
    public Vector4 Unk80;

    public TigerHash Unk90;
    public TigerHash Unk94;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C56E8080", 0x80)]
public struct SEntityModelMesh
{
    public VertexBuffer Vertices1;  // vert file 1 (positions)
    public VertexBuffer Vertices2;  // vert file 2 (texcoords/normals)
    public VertexBuffer OldWeights;  // old weights
    public TigerHash Unk0C;  // nothing ever
    public IndexBuffer Indices;  // indices
    public VertexBuffer VertexColour;  // vertex colour
    public VertexBuffer SinglePassSkinningBuffer;  // single pass skinning buffer
    public int Zeros1C;
    public DynamicArrayUnloaded<D2Class_CB6E8080> Parts;

    /// Range of parts to render per render stage
    /// Can be obtained as follows:
    ///
    ///     - Start = part_range_per_render_stage[stage]
    ///     - End = part_range_per_render_stage[stage + 1]

    [SchemaField(TigerStrategy.MARATHON_ALPHA, ArraySizeConst = 25)] // ArraySizeConst being the number of elements
    public short[] PartRangePerRenderStage;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, ArraySizeConst = 24)]
    public byte[] InputLayoutPerRenderStageBL;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, Obsolete = true)]
    public short[] InputLayoutPerRenderStageSK;

    public Range GetRangeForStage(int stage)
    {
        int start = PartRangePerRenderStage[stage];
        int end = PartRangePerRenderStage[stage + 1];
        return new Range(start, end);
    }

    public int GetInputLayoutForStage(int stage)
    {
        return InputLayoutPerRenderStageBL[stage];
    }
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CB6E8080", 0x24)]
public struct D2Class_CB6E8080  // TODO use DCG to figure out what this is
{
    public Material Material;  // AA6D8080
    public short VariantShaderIndex;  // variant_shader_index
    public short PrimitiveType;
    public uint IndexOffset;
    public uint IndexCount;
    public uint Unk10;  // might be number of strips?

    [SchemaField(0x14, TigerStrategy.MARATHON_ALPHA)]
    public short ExternalIdentifier;  // external_identifier
    public byte Unk16;
    public byte Unk17;

    // need to check this on WQ, theres no way its an int
    [SchemaField(TigerStrategy.MARATHON_ALPHA)]
    public int FlagsD2;

    [SchemaField(0x1C, TigerStrategy.MARATHON_ALPHA)]
    public byte GearDyeChangeColorIndex;   // sbyte gear_dye_change_color_index
    public ELodCategory LodCategory;
    public byte Unk1E;
    public byte LodRun;  // lod_run
    public int Unk20; // variant_shader_index?

    public int GetFlags()
    {
        return FlagsD2;
    }
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "5B6D8080", 0x320)]
public struct D2Class_5B6D8080
{
}

[SchemaStruct("0B008080", 4)]
public struct D2Class_0B008080
{
    public uint Unk00;
}

[SchemaStruct("668B8080", 0x70)]
public struct D2Class_668B8080
{
    [SchemaField(0x30)]
    public DynamicArrayUnloaded<D2Class_628B8080> Unk30;
}

[SchemaStruct("628B8080", 0x30)]
public struct D2Class_628B8080
{
    public Vector4 Unk00;
}

[SchemaStruct("0F008080", 4)]
public struct D2Class_0F008080
{
    public float Unk00;
}

[SchemaStruct("90008080", 0x10)]
public struct D2Class_90008080
{
    public Vector4 Unk00;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DA5E8080", 0x150)]
public struct D2Class_DA5E8080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DB5E8080", 0x240)]
public struct D2Class_DB5E8080
{
    [SchemaField(0x108, TigerStrategy.MARATHON_ALPHA)]
    public Tag<D2Class_23978080> Unk108;
}

[SchemaStruct("23978080", 0x48)]
public struct D2Class_23978080
{
    public long FileSize;
    public StringHash EntityName;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "12848080", 0x50)]
public struct D2Class_12848080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0E848080", 0xA0)]
public struct D2Class_0E848080
{
    [SchemaField(0x88, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_1B848080> Unk88;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "1B848080", 0x18)]
public struct D2Class_1B848080
{
    [SchemaField(0x8, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_1D848080> Unk08;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "1D848080", 0x18)]
public struct D2Class_1D848080
{
    public int Unk00;
    public int Unk04;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Entity;
}

[SchemaStruct("07008080", 4)]
public struct D2Class_07008080
{
    public uint Unk00;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "81888080", 0xEC)]
public struct D2Class_81888080
{
    [SchemaField(0x74)]
    public Tag Entity;
}

// General, parents that reference Entity

[SchemaStruct("30898080", 0x28)]
public struct D2Class_30898080
{
    public long FileSize;
    public DynamicArray<D2Class_34898080> Unk08;
    public DynamicArray<D2Class_33898080> Unk18;
}

[SchemaStruct("34898080", 0x20)]
public struct D2Class_34898080
{
}

[SchemaStruct("33898080", 0x20)]
public struct D2Class_33898080
{
    public StringPointer TagPath;
    [SchemaField(Tag64 = true)]
    public Tag Tag;  // if .pattern.tft, then Entity - if .budget_set.tft, then parent of itself
    public StringPointer TagNote;
}

[SchemaStruct("ED9E8080", 0x58)]
public struct D2Class_ED9E8080
{
    public long FileSize;
    [SchemaField(0x18)]
    public Tag Unk18;
    [SchemaField(0x28)]
    public DynamicArray<D2Class_F19E8080> Unk28;
}

[SchemaStruct("F19E8080", 0x18)]
public struct D2Class_F19E8080
{
    public StringPointer TagPath;
    [SchemaField(0x8, Tag64 = true)]
    public Tag Tag;  // if .pattern.tft, then Entity
}

[SchemaStruct("7E988080", 8)]
public struct D2Class_7E988080
{
    public Tag Unk00;
    public Tag Unk08;
}

[SchemaStruct("44318080", 8)]
public struct D2Class_44318080
{
    public long FileSize;
    [SchemaField(0x8, Tag64 = true)]
    public Entity? Entity;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "3B9A8080", 0x50)]
public struct D2Class_3B9A8080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "8F948080", 0xC8)]
public struct D2Class_8F948080
{
    [SchemaField(0xA8)]
    public DynamicArray<D2Class_56838080> UnkA8;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "56838080", 0x68)]
public struct D2Class_56838080
{
    [SchemaField(0x8)]
    public DynamicArray<D2Class_58838080> Table1; // Why...Are these all the same...?
    public DynamicArray<D2Class_58838080> Table2;
    public DynamicArray<D2Class_58838080> Table3;
    public DynamicArray<D2Class_58838080> Table4;
    public DynamicArray<D2Class_58838080> Table5;
    public DynamicArray<D2Class_58838080> Table6;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "58838080", 0x18)]
public struct D2Class_58838080
{
    public ResourceInTablePointer<SMapDataEntry>? Datatable;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "B67E8080", 0x34)]
public struct D2Class_B67E8080
{
    [SchemaField(0x20)]
    public StringHash EntityName;
}

#region Named entities

//I think this is the old struct for named bags, it seems like it changed to 1D478080?

//[SchemaStruct("C96C8080", 0x50)]
//public struct D2Class_75988080
//{
//    public long FileSize;
//    // [DestinyField(FieldType.RelativePointer)]
//    // public string DestinationGlobalTagBagName;
//    public FileHash DestinationGlobalTagBag;
//    // [SchemaField(0x20)]
//    // public FileHash PatrolTable1;
//    // [SchemaField(0x28), DestinyField(FieldType.RelativePointer)]
//    // public string PatrolTableName;
//    // public FileHash PatrolTable2;
//}

[SchemaStruct("1D478080", 0x18)]
public struct D2Class_1D478080
{
    public long FileSize;
    public DynamicArray<D2Class_D3598080> DestinationGlobalTagBags;
}

[SchemaStruct("D3598080", 0x10)]
public struct D2Class_D3598080
{
    public FileHash DestinationGlobalTagBag;
    [SchemaField(0x8)]
    public StringPointer DestinationGlobalTagBagName;
}

#endregion

#region Audio

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "6E358080", 0x6b8)]
public struct D2Class_6E358080
{
    [SchemaField(0x648, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_9B318080> PatternAudioGroups;

    //[SchemaField(0x4E8, TigerStrategy.DESTINY1_RISE_OF_IRON)]
    //[SchemaField(TigerStrategy.DESTINY2_WITCHQUEEN_6307, Obsolete = true)]
    //[SchemaField(0x610, TigerStrategy.DESTINY2_LATEST)] // unsure if actually tag64
    //public Tag<D2Class_A36F8080> FallbackAudioGroup;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "9B318080", 0x128)]
public struct D2Class_9B318080
{
    public TigerHash WeaponContentGroup1Hash;
    [SchemaField(0x8)]
    public TigerHash Unk08;
    //[SchemaField(0x18, Tag64 = true)]
    //public FileHash StringContainer;  // idk why but i presume debug strings, not important

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash WeaponContentGroup2Hash;  // "weaponContentGroupHash" from API
    // theres other stringcontainer stuff but skipping it

    [SchemaField(0xA0, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Entity? WeaponSkeletonEntity;

    [SchemaField(0xD0, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag<D2Class_A36F8080> AudioGroup;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0D8C8080", 0x18)]
public struct D2Class_0D8C8080
{
    public long FileSize;
    public DynamicArray<D2Class_0F8C8080> Audio;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0F8C8080", 0x18)]
public struct D2Class_0F8C8080
{
    public TigerHash WwiseEventHash;
    [SchemaField(0x8)]
    public DynamicArray<D2Class_138C8080> Sounds;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "138C8080", 0x28)]
public struct D2Class_138C8080
{
    public short Unk00;
    public short Unk02;
    [SchemaField(0x8)]
    public TigerHash Unk08;
    [SchemaField(0x10)]
    public StringPointer WwiseEventName;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public FileHash Data; // Can be WwiseSound or pattern entity
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "97318080", 0x540)]
public struct D2Class_97318080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F62C8080", 0xB0)]
public struct D2Class_F62C8080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F42C8080", 0x338)]
public struct D2Class_F42C8080
{
    [SchemaField(0x2C8, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_FA2C8080> PatternAudioGroups;

    //[SchemaField(0xD0, TigerStrategy.DESTINY1_RISE_OF_IRON)]
    //[SchemaField(TigerStrategy.DESTINY2_WITCHQUEEN_6307, Obsolete = true)]
    //[SchemaField(0xD0, TigerStrategy.DESTINY2_LATEST, Tag64 = true)]
    //public Entity? FallbackAudio1;

    //[SchemaField(0xF0, TigerStrategy.DESTINY1_RISE_OF_IRON)]
    //[SchemaField(TigerStrategy.DESTINY2_WITCHQUEEN_6307, Obsolete = true)]
    //[SchemaField(0x100, TigerStrategy.DESTINY2_LATEST, Tag64 = true)]
    //public Entity? FallbackAudio2;

    //[SchemaField(0x118, TigerStrategy.DESTINY2_LATEST, Tag64 = true)]
    //public Entity? FallbackAudio3;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "FA2C8080", 0x258)]
public struct D2Class_FA2C8080
{
    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash WeaponContentGroupHash; // "weaponContentGroupHash" from API
    public TigerHash Unk14;
    public TigerHash Unk18;

    [SchemaField(0x30, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash WeaponTypeHash1; // "weaponTypeHash" from API

    [SchemaField(0x60, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk60;

    [SchemaField(0x78, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk78;

    [SchemaField(0x90, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk90;

    [SchemaField(0xA8, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag UnkA8;

    [SchemaField(0xC0, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag UnkC0;

    [SchemaField(0xD8, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag UnkD8;

    [SchemaField(0xF0, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag<D2Class_A36F8080> AudioEntityParent;

    [SchemaField(0x120, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash WeaponTypeHash2; // "weaponTypeHash" from API

    [SchemaField(0x130, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk130;

    [SchemaField(0x148, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk148;

    [SchemaField(0x118, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk118;

    [SchemaField(0x1C0, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk1C0;

    [SchemaField(0x1D8, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk1D8;

    // public DynamicArray<D2Class_87978080> Unk1E8;
    // public DynamicArray<D2Class_84978080> Unk1F8;
    // public DynamicArray<D2Class_062D8080> Unk208;

    [SchemaField(0x248, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag Unk248;
}

[SchemaStruct("092D8080", 0xA0)]
public struct D2Class_092D8080
{
    public long FileSize;
    public TigerHash Unk08;
    [SchemaField(0x18, Tag64 = true)]
    public Entity? Unk18;
    [SchemaField(0x30, Tag64 = true)]
    public Entity? Unk30;
    [SchemaField(0x48, Tag64 = true)]
    public Entity? Unk48;
    [SchemaField(0x60, Tag64 = true)]
    public Entity? Unk60;
    [SchemaField(0x78, Tag64 = true)]
    public Entity? Unk78;
    [SchemaField(0x90, Tag64 = true)]
    public Entity? Unk90;
}


// Turns out this can be used for more than just sounds, recent findings have seen it used for map global channels?
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "79818080", 0x390)]
public struct D2Class_79818080
{
    [SchemaField(0x1A8, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_F1918080> Array1;

    [SchemaField(0x1B8, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<D2Class_F1918080> Array2;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F1918080", 0x18)]
public struct D2Class_F1918080
{
    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk10; // B9678080, 40668080
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "40668080", 0x68)]
public struct D2Class_40668080
{
    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public WwiseSound Sound;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "B9678080", 0x110)]
public struct D2Class_B9678080
{
    [SchemaField(0x28)]
    public DynamicArray<D2Class_BB678080> Unk28;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "BB678080", 0x18)]
public struct D2Class_BB678080
{
    [SchemaField(0x10)]
    public Tag<D2Class_20698080> FXContainer;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "20698080", 0x40)]
public struct D2Class_20698080
{
    public FileHash Unk00;
    [SchemaField(0x18)] // idfk why not having the above FileHash makes this read at 0x0??
    public Material UnkMat;
    [SchemaField(0x20, Tag64 = true)]
    public Tag<D2Class_29698080> ModelContainer;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "29698080", 0x18)]
public struct D2Class_29698080
{
    [SchemaField(0x10)]
    public DynamicArray<D2Class_066F8080> Models;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "066F8080", 4)]
public struct D2Class_066F8080
{
    public EntityModel Model;
}

[SchemaStruct("72818080", 0x18)]
public struct D2Class_72818080
{
}

[SchemaStruct("00488080", 0x20)]
public struct D2Class_00488080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "79948080", 0x300)]
public struct D2Class_79948080
{
}

[SchemaStruct("E3918080", 0x40)]
public struct D2Class_E3918080
{
}

[SchemaStruct("0A2D8080", 0x4C)]
public struct D2Class_0A2D8080
{
    [SchemaField(0x8, Tag64 = true)]
    public Entity? Unk08;
    [SchemaField(0x20, Tag64 = true)]
    public Entity? Unk20;
    [SchemaField(0x38, Tag64 = true)]
    public Entity? Unk38;
}

#endregion

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "95668080", 0x1E0)]
public struct SMapCubemapResource //Dataresource for cubemaps
{
    [SchemaField(0x20)]
    public Vector4 CubemapSize; //XYZ, no W
    public Vector4 CubemapPosition; // Not actually right afaik

    [SchemaField(0xB0)]
    public long WorldID; // Same as the ID in the datatable entry

    [SchemaField(0x100, TigerStrategy.MARATHON_ALPHA)]
    public Vector4 CubemapRotation;

    [SchemaField(0x1B0, TigerStrategy.MARATHON_ALPHA)]
    public StringPointer CubemapName;

    [SchemaField(0x1B8, TigerStrategy.MARATHON_ALPHA)]
    public Texture CubemapTexture;

    [SchemaField(0x1C0, TigerStrategy.MARATHON_ALPHA)]
    public Texture CubemapIBLTexture; //Sometype of reflection tint texture idk
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D8928080", 0x190)]
public struct D2Class_D8928080
{
    [SchemaField(0x84)]
    public Tag<SMapDataTable> Unk84;
    [SchemaField(0x90)]
    public Vector4 Rotation;
    public Vector4 Translation;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "EF8C8080", 0x60)]
public struct D2Class_EF8C8080
{
    [SchemaField(0x58)]
    public Tag<SMapDataTable> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "FA988080", 0x80)]
public struct D2Class_FA988080
{
    [SchemaField(0x28)]
    public TigerHash FNVHash;
    [SchemaField(0x30)]
    public ulong WorldID;
    [SchemaField(0x58)]
    public DynamicArray<D2Class_05998080> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F88C8080", 0x80)]
public struct D2Class_F88C8080
{
    [SchemaField(0x28)]
    public TigerHash FNVHash;
    [SchemaField(0x30)]
    public ulong WorldID;
    [SchemaField(0x58)]
    public DynamicArray<D2Class_05998080> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "EF988080", 0x80)]
public struct D2Class_EF988080
{
    [SchemaField(0x28)]
    public TigerHash FNVHash;
    [SchemaField(0x30)]
    public ulong WorldID;
    [SchemaField(0x58)]
    public DynamicArray<D2Class_05998080> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "6F418080", 0xE0)]
public struct D2Class_6F418080
{
    [SchemaField(0x28)]
    public TigerHash FNVHash;
    [SchemaField(0x30)]
    public ulong WorldID;
    [SchemaField(0x58)]
    public DynamicArray<D2Class_05998080> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "26988080", 0x98)]
public struct D2Class_26988080
{
    [SchemaField(0x28)]
    public TigerHash FNVHash;
    [SchemaField(0x30)]
    public ulong WorldID;
    [SchemaField(0x58)]
    public DynamicArray<D2Class_05998080> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "95468080", 0x90)]
public struct D2Class_95468080
{
    [SchemaField(0x28)]
    public TigerHash FNVHash;
    [SchemaField(0x30)]
    public ulong WorldID;
    [SchemaField(0x58)]
    public DynamicArray<D2Class_05998080> Unk58;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "05998080", 0x10)]
public struct D2Class_05998080
{
    public TigerHash FNVHash;
    [SchemaField(0x8)]
    public ulong WorldID;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "6B908080", 0x28)]
public struct D2Class_6B908080
{
    [SchemaField(0x8)]
    public DynamicArray<D2Class_029D8080> Unk08;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "029D8080", 0x10)]
public struct D2Class_029D8080
{
    public ResourceInTablePointer<D2Class_4D898080> Unk00;
    public RelativePointer Unk08;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "4D898080", 0xC)]
public struct D2Class_4D898080
{
    public StringPointer Name;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "357C8080", 0x1BD0)]
public struct D2Class_357C8080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "18808080", 0x478)]
public struct D2Class_18808080
{
    [SchemaField(0x3C0, TigerStrategy.MARATHON_ALPHA)]
    public Tag<D2Class_4D7E8080> Unk3C0;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "4D7E8080", 0x30)]
public struct D2Class_4D7E8080
{
    [SchemaField(0x2C, TigerStrategy.MARATHON_ALPHA)]
    public StringHash EntityName;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0E478080", 0x110)]
public struct D2Class_0E478080
{
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "B5468080", 0x150)]
public struct D2Class_B5468080
{
    [SchemaField(0x80)]
    public DynamicArray<D2Class_96468080> Unk80;

    [SchemaField(0xC0)]
    public Vector4 Rotation;
    public Vector4 Translation;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "96468080", 0x80)]
public struct D2Class_96468080
{
    [SchemaField(0x28, Tag64 = true)]
    public Tag<SMapDataTable> DataTable;
    public StringHash Name;
}
