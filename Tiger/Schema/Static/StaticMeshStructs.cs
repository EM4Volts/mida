﻿using Tiger.Schema.Model;
using Tiger.Schema.Shaders;

namespace Tiger.Schema.Static;

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "A7718080", 0x90)]
[SchemaStruct(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, "446D8080", 0x70)]
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

    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601)]
    public Vector4 ModelTransform;
    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601)]
    public Vector2 TexcoordScale;
    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601)]
    public Vector2 TexcoordTranslation;
}

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "14008080", 0x4)]
[SchemaStruct(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, "14008080", 0x4)]
public struct SMaterialHash
{
    public Material Material;
}

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "93718080", 0x20)]
[SchemaStruct(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, "2F6D8080", 0x24)]
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "1F868080", 0x20)]
public struct SStaticMeshDecal
{
    // ugh this is ugly
    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601)]
    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, Obsolete = true)]
    public short RenderStageSK;
    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601)]
    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, Obsolete = true)]
    public short VertexLayoutIndexSK;

    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601, Obsolete = true)]
    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    public byte RenderStageBL;
    [SchemaField(TigerStrategy.DESTINY2_SHADOWKEEP_2601, Obsolete = true)]
    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    public byte VertexLayoutIndexBL;

    //----------------

    [SchemaField(4, TigerStrategy.DESTINY2_SHADOWKEEP_2601)]
    [SchemaField(2, TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    public sbyte LODLevel;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, Obsolete = true)]
    public sbyte Unk03;

    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    [SchemaField(3, TigerStrategy.MARATHON_ALPHA)]
    public byte PrimitiveType; // TODO FIX, ONLY A BYTE IN MARATHON 

    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    [SchemaField(TigerStrategy.MARATHON_ALPHA, Obsolete = true)]
    public short Unk06;

    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    [SchemaField(0x4, TigerStrategy.MARATHON_ALPHA)]
    public IndexBuffer Indices;
    public VertexBuffer Vertices0;
    public VertexBuffer Vertices1;
    [SchemaField(TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    public VertexBuffer? VertexColor;
    public uint IndexOffset;
    public uint IndexCount;
    public Material Material;

    public int GetVertexLayoutIndex()
    {
        if (Strategy.CurrentStrategy >= TigerStrategy.DESTINY2_BEYONDLIGHT_3402)
            return VertexLayoutIndexBL;
        else
            return VertexLayoutIndexSK;
    }

    public int GetRenderStage()
    {
        if (Strategy.CurrentStrategy >= TigerStrategy.DESTINY2_BEYONDLIGHT_3402)
            return RenderStageBL;
        else
            return RenderStageSK;
    }
}

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "94718080", 0x40)]
public struct SStaticMeshData_SK
{
    public long FileSize;
    public DynamicArray<SStaticMeshMaterialAssignment_SK> MaterialAssignments;
    public DynamicArray<SStaticMeshPart> Parts;
    public DynamicArray<SStaticMeshBuffers> Buffers;
}

[SchemaStruct(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, "306D8080", 0x70)]
[SchemaStruct(TigerStrategy.DESTINY2_WITCHQUEEN_6307, "306D8080", 0x60)]
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "80808620", 0x60)]
public struct SStaticMeshData_BL
{
    public long FileSize;
    public DynamicArray<SStaticMeshMaterialAssignment_WQ> MaterialAssignments;
    public DynamicArray<SStaticMeshPart> Parts;
    public DynamicArray<SStaticMeshBuffers> Meshes;

    [SchemaField(0x50, TigerStrategy.DESTINY2_BEYONDLIGHT_3402)]
    [SchemaField(0x40, TigerStrategy.DESTINY2_WITCHQUEEN_6307)]
    public Vector4 ModelTransform;
    public float TexcoordScale;
    public Vector2 TexcoordTranslation;
    public uint MaxVertexColorIndex;
}

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "9B718080", 0x8)]
public struct SStaticMeshMaterialAssignment_SK
{
    public ushort PartIndex;
    public ushort RenderStage;  // TFX render stage
    public short VertexLayoutIndex;
    public ushort Unk06;
}

[SchemaStruct(TigerStrategy.DESTINY2_WITCHQUEEN_6307, "386D8080", 0x6)]
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "28868080", 0x6)]
public struct SStaticMeshMaterialAssignment_WQ
{
    public ushort PartIndex;
    public byte RenderStage;  // TFX render stage
    public byte VertexLayoutIndex;
    public ushort Unk04;
}

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "9A718080", 0xC)]
[SchemaStruct(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, "376D8080", 0xC)]
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "27868080", 0xC)]
public struct SStaticMeshPart
{
    public uint IndexOffset;
    public uint IndexCount;
    public ushort BufferIndex;
    public sbyte DetailLevel;
    public sbyte PrimitiveType;
}

[SchemaStruct(TigerStrategy.DESTINY2_SHADOWKEEP_2601, "99718080", 0x10)]
[SchemaStruct(TigerStrategy.DESTINY2_BEYONDLIGHT_3402, "366D8080", 0x14)]
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "26868080", 0x10)]
public struct SStaticMeshBuffers
{
    public IndexBuffer Indices;
    public VertexBuffer Vertices0;
    public VertexBuffer? Vertices1;

    [SchemaField(TigerStrategy.DESTINY2_WITCHQUEEN_6307)]
    public VertexBuffer VertexColor;

    [SchemaField(TigerStrategy.MARATHON_ALPHA, Obsolete = true)] // ??
    public uint UnkOffset;
}

[SchemaStruct(TigerStrategy.DESTINY1_RISE_OF_IRON, "D61B8080", 0x18)]
public struct SStaticMeshData_D1
{
    public VertexBuffer Vertices0;
    public VertexBuffer Vertices1;
    public IndexBuffer Indices;
    public sbyte UnkC;
    public sbyte UnkD;
    public sbyte DetailLevel;
    public sbyte PrimitiveType;
    public uint IndexOffset;
    public uint IndexCount;
}
