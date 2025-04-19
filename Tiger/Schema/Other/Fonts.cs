﻿namespace Tiger.Schema.Other;

// C7478080 shadowkeep
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0F3C8080", 0x18)]
public struct D2Class_0F3C8080
{
    public long FileSize;
    public DynamicArray<D2Class_113C8080> FontParents;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "113C8080", 0x04)]
public struct D2Class_113C8080
{
    public Tag<D2Class_123C8080> FontParent;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "123C8080", 0x20)]
public struct D2Class_123C8080
{
    public long FileSize;
    public TigerFile FontFile;
    [SchemaField(0x10)]
    public StringPointer FontName;
    public long FontFileSize;
}
