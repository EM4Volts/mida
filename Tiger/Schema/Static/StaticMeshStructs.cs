using Tiger.Schema.Model;
using Tiger.Schema.Shaders;

namespace Tiger.Schema.Static;

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "80808635", 0x70)]
public struct SStaticMesh
{
    public long FileSize;
    public IStaticMeshData StaticData;

    [SchemaField(0x10)]
    public DynamicArray<SMaterialHash> Materials;
    public DynamicArray<SStaticMeshDecal> Decals;

    [SchemaField(0x3C)]  // revise this, not correct. maybe correct for decals?
    public Vector3 Scale;
    [SchemaField(0x50)]
    public Vector4 Offset;

    public Vector4 ModelTransform;
    public Vector2 TexcoordScale;
    public Vector2 TexcoordTranslation;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "14008080", 0x4)]
public struct SMaterialHash
{
    public Material Material;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "1F868080", 0x20)]
public struct SStaticMeshDecal
{
    [SchemaField(TigerStrategy.MARATHON_ALPHA)]
    public byte RenderStageBL;
    [SchemaField(TigerStrategy.MARATHON_ALPHA)]
    public byte VertexLayoutIndexBL;

    //----------------

    [SchemaField(2, TigerStrategy.MARATHON_ALPHA)]
    public sbyte LODLevel;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, Obsolete = true)]
    public sbyte Unk03;

    [SchemaField(3, TigerStrategy.MARATHON_ALPHA)]
    public byte PrimitiveType;

    [SchemaField(0x4, TigerStrategy.MARATHON_ALPHA)]
    public IndexBuffer Indices;
    public VertexBuffer Vertices0;
    public VertexBuffer Vertices1;
    public VertexBuffer? VertexColor;
    public uint IndexOffset;
    public uint IndexCount;
    public Material Material;

    public int GetVertexLayoutIndex()
    {
        return VertexLayoutIndexBL;
    }

    public int GetRenderStage()
    {
        return RenderStageBL;
    }
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "80808620", 0x60)]
public struct SStaticMeshData_BL
{
    public long FileSize;
    public DynamicArray<SStaticMeshMaterialAssignment_WQ> MaterialAssignments;
    public DynamicArray<SStaticMeshPart> Parts;
    public DynamicArray<SStaticMeshBuffers> Meshes;

    [SchemaField(0x40, TigerStrategy.MARATHON_ALPHA)]
    public Vector4 ModelTransform;
    public float TexcoordScale;
    public Vector2 TexcoordTranslation;
    public uint MaxVertexColorIndex;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "28868080", 0x6)]
public struct SStaticMeshMaterialAssignment_WQ
{
    public ushort PartIndex;
    public byte RenderStage;  // TFX render stage
    public byte VertexLayoutIndex;
    public ushort Unk04;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "27868080", 0xC)]
public struct SStaticMeshPart
{
    public uint IndexOffset;
    public uint IndexCount;
    public ushort BufferIndex;
    public sbyte DetailLevel;
    public sbyte PrimitiveType;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "26868080", 0x10)]
public struct SStaticMeshBuffers
{
    public IndexBuffer Indices;
    public VertexBuffer Vertices0;
    public VertexBuffer? Vertices1;
    public VertexBuffer VertexColor;
}
