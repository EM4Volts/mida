using Tiger.Schema.Entity;
using Tiger.Schema.Strings;

namespace Tiger.Schema.Investment;

/// <summary>
/// Stores all the inventory item definitions in a huge hashmap.
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "97798080", 0x18)]
public struct S97798080
{
    public long FileSize;
    public DynamicArrayUnloaded<S9B798080> InventoryItemDefinitionEntries;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "9B798080", 0x20)]
public struct S9B798080
{
    public TigerHash InventoryItemHash;
    [SchemaField(0x10), NoLoad]
    public InventoryItem InventoryItem;
}

#region InventoryItemDefinition

/// <summary>
/// Inventory item definition.
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "9D798080", 0x120)]
public struct S9D798080
{
    public long FileSize;
    public ResourcePointer Unk08;  // SE4768080, 16198080 D1
    [SchemaField(0x18)]
    public ResourcePointer Unk18;  // SE7778080, 06178080 D1

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk28;  // SC5738080, 'gearset'

    [SchemaField(0x30, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk30;  // SB6738080, lore entry index (map CF508080 BDA1A780)

    [SchemaField(0x38, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk38;  // B0738080, 'objectives'

    [SchemaField(0x48)]
    public ResourcePointer Unk48;  // 15108080 D1, A1738080 D2 'plug'

    [SchemaField(0x50)]
    public ResourcePointer Unk50; // 8B178080 D1

    [SchemaField(0x70, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk70;  // C0778080 socketEntries

    [SchemaField(0x78, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk78;  // S81738080, BD178080 D1

    //[SchemaField(0x88, TigerStrategy.MARATHON_ALPHA)]
    //public ResourcePointer Unk88;  // S7F738080

    [SchemaField(0x90, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk90;  // S77738080

    [SchemaField(0xA8, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash InventoryItemHash;
    public TigerHash UnkAC;
    public byte SeasonIndex; // 'seasonHash', not used for gear

    [SchemaField(0xC2, TigerStrategy.MARATHON_ALPHA)]
    public byte ItemRarity;

    [SchemaField(0xC4, TigerStrategy.MARATHON_ALPHA)]
    public byte UnkC4; // 'isInstanceItem'?

    [SchemaField(0xCA, TigerStrategy.MARATHON_ALPHA)]
    public byte RecipeItemIndex; // 'recipeItemHash'

    [SchemaField(0x108, TigerStrategy.MARATHON_ALPHA)]
    public short SummaryItemIndex;

    [SchemaField(0x110, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S05798080> TraitIndices;
}

[SchemaStruct("E4768080", 0x90)]
public struct SE4768080
{
    [SchemaField(0x48)]
    public TigerHash Unk48;
    public TigerHash Unk4C;
    [SchemaField(0x54)]
    public int Unk54;
    [SchemaField(0x70)]
    public int Unk70;
    [SchemaField(0x88)]
    public float Unk88;
}

/// <summary>
/// D2 "equippingBlock"
/// </summary>
[SchemaStruct("E7778080", 0x20)]
public struct SE7778080
{
    public DynamicArray<S387A8080> Unk00;
    [SchemaField(0x14)]
    public StringHash UniqueLabel;
    public TigerHash UniqueLabelHash;
    public byte EquipmentSlotTypeIndex; // 'equipmentSlotTypeHash'
    public byte Attributes; // EquippingItemBlockAttributes (just 0 or 1)
}

[SchemaStruct("387A8080", 0x10)]
public struct S387A8080
{
    public DynamicArray<S3A7A8080> Unk00;
}

[SchemaStruct("3A7A8080", 8)]
public struct S3A7A8080
{
    public int Unk00;
    public int Unk04;
}

// 'quality'
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DC778080", 0x70)]
public struct SDC778080
{
    [SchemaField(0x08)]
    public short ProgressionLevelRequirementIndex; // 'progressionLevelRequirementHash'
    //[SchemaField(0x10)]
    //public DynamicArray<SStringHash> InfusionCategoryHashes;

    [SchemaField(0x28)]
    public DynamicArray<S2D788080> DisplayVersionWatermarkIcons; // Unsure

    [SchemaField(0x60, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<SDE778080> Versions;
}

[SchemaStruct("2D788080", 2)]
public struct S2D788080
{
    public short IconIndex;
}

[SchemaStruct("DE778080", 2)]
public struct SDE778080
{
    public short PowerCapIndex; // 'powerCapHash' DestinyPowerCapDefinition
}

[SchemaStruct("05798080", 2)]
public struct S05798080
{
    public short Unk00;
}

[SchemaStruct("81738080", 0x30)]
public struct S81738080
{
    public DynamicArray<S86738080> InvestmentStats;  // "investmentStats" from API
    public DynamicArray<S87738080> Perks;  // 'perks'
}

/// <summary>
/// "investmentStat" from API
/// </summary>
[SchemaStruct("86738080", 0x28)]
public struct S86738080
{
    public int StatTypeIndex;  // "statTypeHash" from API
    public int Value;  // "value" from API
}

[SchemaStruct("86738080", 0x18)]
public struct S87738080
{
    public int PerkIndex;  // "perkHash" from API
}

[SchemaStruct("7F738080", 2)]
public struct S7F738080
{
    public short Unk00;
}

[SchemaStruct("B6738080", 0x4)]
public struct SB6738080
{
    public short LoreEntryIndex;
}

// 'gearset'
[SchemaStruct("C5738080", 0x38)]
public struct SC5738080
{
    public DynamicArray<S26908080> ItemList;
}

[SchemaStruct("26908080", 0x2)]
public struct S26908080
{
    public short ItemIndex;
}

/// <summary>
/// "translationBlock" from API, "equippingBlock" in D1
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "77738080", 0x60)]
public struct S77738080
{
    // D1 has "customDyeExpression" at 0x40 but idk what its used for

    public DynamicArrayUnloaded<S7D738080> Arrangements;  // "arrangements" from API

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S7B738080> CustomDyes;  // "customDyes" from API

    [SchemaField(0x38, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S7B738080> DefaultDyes;  // "defaultDyes" from API

    [SchemaField(0x48, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<S7B738080> LockedDyes;  // "lockedDyes" from API

    [SchemaField(0x58, TigerStrategy.MARATHON_ALPHA)]
    public short WeaponPatternIndex;  // "weaponPatternHash" from API, "weaponSandboxPatternIndex" in D1
}

/// <summary>
/// "arrangement" from API
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "7D738080", 4)]
public struct S7D738080
{
    public short ClassHash;  // "classHash" from API
    public short ArtArrangementHash;  // "artArrangementHash" from API, "gearArtArrangementIndex" in D1
}

/// <summary>
/// "lockedDyes" from API
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "7B738080", 4)]
public struct S7B738080
{
    public short ChannelIndex;  // "channelHash" from API
    public short DyeIndex;  // "dyeHash" from API
}

#endregion

#region Stats
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "BE548080", 0x18)]
public struct SBE548080
{
    public ulong FileSize;
    public DynamicArrayUnloaded<SC4548080> StatGroupDefinitions;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C4548080", 0x38)]
public struct SC4548080
{
    public TigerHash StatGroupHash;
    public short Unk04;
    [SchemaField(0x8)]
    public TigerHash Unk08;
    [SchemaField(0x10)]
    public DynamicArray<SC8548080> ScaledStats;
    [SchemaField(0x30)]
    public int MaximumValue;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C8548080", 0x18)]
public struct SC8548080
{
    public byte StatIndex; // 'statHash'
    public byte DisplayAsNumeric;
    public byte Unk02;
    public byte IsLinear; // not in api, means the value "isnt" interpolated? WYSIWYG
    [SchemaField(0x8)]
    public DynamicArray<S257A8080> DisplayInterpolation;

}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "257A8080", 0x8)]
public struct S257A8080
{
    public int Value;
    public int Weight;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "6B588080", 0x18)]
public struct S6B588080
{
    public ulong FileSize;
    public DynamicArrayUnloaded<S6F588080> StatDefinitions;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "6F588080", 0x24)]
public struct S6F588080
{
    public TigerHash StatHash;
    public StringIndexReference StatName;
    public StringIndexReference StatDescription;
    public short StatIconIndex;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C9798080", 0x18)]
public struct SC9798080
{
    [SchemaField(0x8)]
    public DynamicArray<SCF798080> PowerCapDefinitions;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CF798080", 0x8)]
public struct SCF798080
{
    public TigerHash PowerCapHash;
    public float PowerCap; // needs multiplied by 10 for some reason?
}
#endregion

#region String Stuff

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "99548080", 0x18)]
public struct S99548080
{
    public long FileSize;
    public DynamicArrayUnloaded<S9D548080> StringThings;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "9D548080", 0x20)]
public struct S9D548080
{
    public TigerHash ApiHash;

    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public Tag<S9F548080> StringThing;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "9F548080", 0x130)]
public struct S9F548080
{
    public long FileSize;

    [SchemaField(0x38, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk38;  // SD8548080

    [SchemaField(0x40, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk40;  // SD7548080

    [SchemaField(0x60, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk60;  // SCF548080

    [SchemaField(0x78, TigerStrategy.MARATHON_ALPHA)]
    public ResourcePointer Unk78;  // SB4548080

    [SchemaField(0x88, TigerStrategy.MARATHON_ALPHA)]
    public short IconIndex;
    public short FoundryIconIndex; // the banner that appears on foundry weapons (Hakke, veist, etc)
    public short EmblemContainerIndex; // Can be the emblem or foundry container post-TFS

    [SchemaField(0x8C, TigerStrategy.MARATHON_ALPHA)]
    public StringIndexReference ItemName;  // "displayProperties" -> "name"

    [SchemaField(0x98, TigerStrategy.MARATHON_ALPHA)]
    public StringIndexReference ItemType;  // "itemTypeDisplayName"

    [SchemaField(0xA0, TigerStrategy.MARATHON_ALPHA)]
    public StringIndexReference ItemDisplaySource; // "displaySource"

    [SchemaField(0xB0, TigerStrategy.MARATHON_ALPHA)]
    public StringIndexReference ItemFlavourText;  // "flavorText"

    [SchemaField(0xB8, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArrayUnloaded<SF1598080> UnkB8;

    public TigerHash UnkC8;  // "bucketTypeHash" / "equipmentSlotTypeHash"
    public TigerHash UnkCC;  // DestinySandboxPatternDefinition hash
    public TigerHash UnkD0;  // DestinySandboxPatternDefinition hash
    public TigerHash UnkD4;

    public DestinyTooltipStyle TooltipStyle; // 'tooltipStyle' as fnv hash
    public DestinyUIDisplayStyle DisplayStyle; // 'uiItemDisplayStyle'

    [SchemaField(0xE0, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<SB2548080> TooltipNotifications;
    // ive missed lots of stuff here

    //[SchemaField(TigerStrategy.DESTINY1_RISE_OF_IRON, Obsolete = true)]
    //[SchemaField(0x120, TigerStrategy.MARATHON_ALPHA)]
    //[SchemaField(0x128, TigerStrategy.DESTINY2_LATEST)]
    //public DynamicArrayUnloaded<S59238080> Unk120;
}

[SchemaStruct("D8548080", 0x88)]
public struct SD8548080
{
    [SchemaField(0x10)]
    public DynamicArray<SDC548080> InsertionRules;
}

[SchemaStruct("DC548080", 0x8)]
public struct SDC548080
{
    public StringIndexReference FailureMessage;
}

[SchemaStruct("D7548080", 0x20)]
public struct SD7548080 // 'preview'
{
    public DestinyScreenStyle ScreenStyle; // screenStyle
    public int PreviewVendorIndex; // previewVendorHash
    public StringIndexReference PreviewActionString; // previewActionString
}

[SchemaStruct("CF548080", 0x8)]
public struct SCF548080 // 'details'
{
    public StringIndexReference DetailsActionString;
}

[SchemaStruct("B2548080", 0x20)]
public struct SB2548080
{
    [SchemaField(0x10)]
    public StringIndexReference DisplayString;
    public StringHash DisplayStyle; // No actual strings, fnv (B4437851 = ui_display_style_item_add_on)
}

[SchemaStruct("F1598080", 2)]
public struct SF1598080
{
    public short Unk00;
}

[SchemaStruct("59238080", 0x18)]
public struct S59238080
{
    [SchemaField(0x10)]
    public short Unk10;
    [SchemaField(0x14)]
    public TigerHash Unk14;
}


/// <summary>
/// Item destruction, includes the term "Dismantle".
/// </summary>
[SchemaStruct("EF548080", 0x1C)]
public struct SEF548080
{
    public StringIndexReference DestructionTerm;
    // some other terms, integers
}

[SchemaStruct("E7548080", 8)]
public struct SE7548080
{
    public short Unk00;
}

[SchemaStruct("E5548080", 0x28)]
public struct SE5548080
{
    public short Unk00;
    public short Unk02;
    public short Unk04;
    [SchemaField(0x8)]
    public DynamicArray<SF2598080> Unk08;
    public DynamicArray<SAE578080> Unk18;
}

[SchemaStruct("F2598080", 8)]
public struct SF2598080
{
    public short Unk00;
    [SchemaField(0x4)]
    public TigerHash Unk04;
}

[SchemaStruct("AE578080", 2)]
public struct SAE578080
{
    public short Unk00;
}

[SchemaStruct("E4548080", 8)]
public struct SE4548080
{
    public short Unk00;
    [SchemaField(0x4)]
    public TigerHash Unk04;
}

[SchemaStruct("CA548080", 0x18)]
public struct SCA548080
{
    [SchemaField(0x1)]
    public byte StatGroupIndex; // TFS Episode 2
}

/// <summary>
/// Item inspection, includes the term "Details".
/// </summary>
[SchemaStruct("B4548080", 0x18)]
public struct SB4548080
{
    public TigerHash Unk00;
    public TigerHash Unk04;
    [SchemaField(0xC)]
    public StringIndexReference InspectionTerm;
    public int StatGroupIndex;
}

[SchemaStruct("FFFFFFFF", 0x0)] // TODO FIX HASH AND SIZE, CURRENT CONFLICT WITH OLD CLASS HASH
public struct S2D548080
{
    public long FileSize;
    public DynamicArrayUnloaded<S33548080> SandboxPerkDefinitionEntries;
}

[SchemaStruct("33548080", 0x28)]
public struct S33548080
{
    public TigerHash SandboxPerkHash;
    public TigerHash Unk04;
    public StringIndexReference SandboxPerkName;
    public StringIndexReference SandboxPerkDescription;
    public short IconIndex;
}

[SchemaStruct("AA768080", 0x18)]
public struct SAA768080
{
    public long FileSize;
    public DynamicArrayUnloaded<SAE7680800> SandboxPerkDefinitionEntries;
}

[SchemaStruct("AE768080", 0xC)]
public struct SAE7680800
{
    public TigerHash SandboxPerkHash;
    public int UnkIndex;
    public int Unk08;
}

#endregion

#region ArtArrangement

/// <summary>
/// Stores all the art arrangement hashes in an index-accessed DynamicArray.
/// </summary>
[SchemaStruct("F2708080", 0x18)]
public struct SF2708080
{
    public long FileSize;
    public DynamicArrayUnloaded<SED6F8080> ArtArrangementHashes;
}

[SchemaStruct("ED6F8080", 4)]
public struct SED6F8080
{
    public TigerHash ArtArrangementHash;
}

#endregion

#region ApiEntities

/// <summary>
/// Entity assignment tag header. The assignment can be accessed via the art arrangement index.
/// The file is massive so I don't auto-parse it.
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CE558080", 0x28)]
public struct SCE558080
{
    public long FileSize;
    public DynamicArrayUnloaded<SD4558080> ArtArrangementEntityAssignments;
    // [DestinyField(FieldType.TablePointer)]
    // public DynamicArray<SD8558080> FinalAssignment;  // this is not needed as the above table has resource pointers
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D4558080", 0x20)]
public struct SD4558080
{
    [SchemaField(TigerStrategy.MARATHON_ALPHA)]
    public TigerHash ArtArrangementHash;

    [SchemaField(0x8, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash MasculineSingleEntityAssignment; // things like armour only have 1 entity, so can skip the jumps
    public TigerHash FeminineSingleEntityAssignment;

    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<SD7558080> MultipleEntityAssignments;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D7558080", 8)]
public struct SD7558080
{
    public ResourceInTablePointer<SD8558080> EntityAssignmentResource;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D8558080", 0x18)]
public struct SD8558080
{
    public long Unk00;
    public DynamicArray<SDA558080> EntityAssignments;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DA558080", 4)]
public struct SDA558080
{
    public TigerHash EntityAssignmentHash;
}

/// <summary>
/// The "final" assignment map of assignment hash : entity hash
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "434F8080", 0x18)]
public struct S434F8080
{
    public long FileSize;
    // This is large but kept as a DynamicArray so we can perform binary searches... todo implement binary search for DynamicArray
    // We could do binary searches... or we could not and transform into a dictionary
    public DynamicArrayUnloaded<S454F8080> EntityArrangementMap;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "454F8080", 8)]
public struct S454F8080 : IComparer<S454F8080>
{
    public TigerHash AssignmentHash;
    [NoLoad]
    public Tag<SA36F8080> EntityParent;

    public int Compare(S454F8080 x, S454F8080 y)
    {
        if (x.AssignmentHash.Equals(y.AssignmentHash)) return 0;
        return x.AssignmentHash.CompareTo(y.AssignmentHash);
    }
}

[SchemaStruct("A44E8080", 0x38)]
public struct SA44E8080
{
    public long FileSize;
    [SchemaField(0x10, Tag64 = true)]
    public Tag<S8C978080> SandboxPatternAssignmentsTag;
    [SchemaField(0x28, Tag64 = true)]
    public Tag<S434F8080> EntityAssignmentsMap;
}

/// <summary>
/// The assignment map for api entity sandbox patterns, for things like skeletons and audio || OR art dye references
/// </summary>
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "8C978080", 0x28)]
public struct S8C978080
{
    public long FileSize;
    public DynamicArrayUnloaded<S0F878080> AssignmentBSL;
    [SchemaField(TigerStrategy.MARATHON_ALPHA)]
    public DynamicArray<SUint32> Unk18;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0F878080", 0x18)]
public struct S0F878080 : IComparer<S0F878080>
{
    public TigerHash ApiHash;

    [SchemaField(0x8, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public FileHash EntityRelationHash;  // can be entity or smth else, if SandboxPattern is entity if ArtDyeReference idk

    public int Compare(S0F878080 x, S0F878080 y)
    {
        if (x.ApiHash.Equals(y.ApiHash)) return 0;
        return x.ApiHash.CompareTo(y.ApiHash);
    }
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "AA528080", 0x18)]
public struct SAA528080
{
    public long FileSize;
    public DynamicArrayUnloaded<SAE528080> SandboxPatternGlobalTagId;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "AE528080", 0x30)]
public struct SAE528080
{
    [SchemaField(0, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash PatternHash;  // "patternHash" from API

    [SchemaField(0x4, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash PatternGlobalTagIdHash;  // "patternGlobalTagIdHash" from API

    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash WeaponContentGroupHash; // "weaponContentGroupHash" from API
    public TigerHash WeaponTypeHash; // "weaponTypeHash" from API
    // filters are also in here but idc
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "A36F8080", 0x18)]
public struct SA36F8080
{
    public long FileSize;

    [SchemaField(8, TigerStrategy.MARATHON_ALPHA, Tag64 = true)]
    public FileHash EntityData;  // can be entity, can be audio group for entity
}

#endregion

#region InventoryItem hashmap

[SchemaStruct("8C798080", 0x28)]
public struct S8C798080
{
    public long FileSize;
    // These tables are just placeholders, instead we transform the bytes into a dict for best performance
    public DynamicArray<S96798080> ExoticHashmap;
    public DynamicArray<S96798080> GeneralHashmap;
}

[SchemaStruct("96798080", 8)]
public struct S96798080
{
    public TigerHash ApiHash;
    public int HashIndex;
}

#endregion

#region InventoryItem Icons

[SchemaStruct("015A8080", 0x18)]
public struct S015A8080
{
    public long FileSize;
    public DynamicArrayUnloaded<S075A8080> InventoryItemIconsMap;
}

[SchemaStruct("075A8080", 0x20)]
public struct S075A8080
{
    public TigerHash InventoryItemHash;
    [SchemaField(0x10, Tag64 = true)]
    public Tag<SB83E8080> IconContainer;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "B83E8080", 0x80)]
public struct SB83E8080
{
    public long FileSize;
    [SchemaField(0x10)]
    public TigerHash Unk10;
    public Tag<SCF3E8080> IconPrimaryContainer;

    [SchemaField(0x18, TigerStrategy.MARATHON_ALPHA)]
    public Tag<SCF3E8080> IconAdContainer; //Eververse item advertisement

    [SchemaField(0x1C, TigerStrategy.MARATHON_ALPHA)]
    public Tag<SCF3E8080> IconBGOverlayContainer;

    [SchemaField(0x20, TigerStrategy.MARATHON_ALPHA)]
    public Tag<SCF3E8080> IconBackgroundContainer;

    [SchemaField(0x24, TigerStrategy.MARATHON_ALPHA)]
    public Tag<SCF3E8080> IconOverlayContainer;

    [SchemaField(0x28, TigerStrategy.MARATHON_ALPHA)]
    public Tag<SCF3E8080> IconSpecialContainer;
}


[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CF3E8080", 0x18)]
public struct SCF3E8080
{
    public long FileSize;
    [SchemaField(0x10)]
    public ResourcePointer Unk10;  // cd3e8080, CD298080
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CD3E8080", 0x20)]
public struct SCD3E8080
{
    public DynamicArrayUnloaded<SD23E8080> Unk00;
}

[SchemaStruct("CB3E8080", 0x20)]
public struct SCB3E8080
{
    public DynamicArrayUnloaded<SD03E8080> Unk00;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D23E8080", 0x10)]
public struct SD23E8080
{
    public DynamicArrayUnloaded<SD53E8080> TextureList;
}

[SchemaStruct("D03E8080", 0x10)]
public struct SD03E8080
{
    public DynamicArrayUnloaded<SD43E8080> TextureList;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D53E8080", 4)]
public struct SD53E8080
{
    public Texture IconTexture;
}

[SchemaStruct("D43E8080", 4)]
public struct SD43E8080
{
    public Texture IconTexture;
}


#endregion

#region Dyes

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C2558080", 0x18)]
public struct SC2558080
{
    public long FileSize;
    public DynamicArrayUnloaded<SC6558080> ArtDyeReferences;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C6558080", 8)]
public struct SC6558080
{
    [SchemaField(0, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash ArtDyeHash;
    [SchemaField(4, TigerStrategy.MARATHON_ALPHA)]
    public TigerHash DyeManifestHash;
}

[SchemaStruct("E36C8080", 8)]
public struct SE36C8080
{
    public long FileSize;
    [SchemaField(0x0C)]
    public Dye Dye;
    // same thing + some unknown flags and info
}


[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "F2518080", 0x18)]
public struct SDyeChannels
{
    public long FileSize;
    public DynamicArrayUnloaded<SDyeChannelHash> ChannelHashes;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "2C4F8080", 4)]
public struct SDyeChannelHash
{
    public TigerHash ChannelHash;
}


#endregion

#region String container hash + indexmap

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "095A8080", 0x18)]
public struct S095A8080
{
    public long FileSize;
    public DynamicArrayUnloaded<S0E5A8080> StringContainerMap;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "0E5A8080", 0x18)]
public struct S0E5A8080
{
    public TigerHash BankFnvHash;  // some kind of name for the bank

    [SchemaField(0x8, TigerStrategy.MARATHON_ALPHA, Tag64 = true), NoLoad]
    public LocalizedStrings LocalizedStrings;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "CF508080", 0x18)]
public struct SCF508080
{
    public long FileSize;
    public DynamicArrayUnloaded<SD3508080> LoreStringMap;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D3508080", 0x28)]
public struct SD3508080
{
    public long Unk00;
    public TigerHash LoreHash;
    public StringIndexReference LoreName;
    public StringIndexReference LoreSubtitle;
    public StringIndexReference LoreDescription;
}

#endregion

#region Socket+Plug Entries
[SchemaStruct("C0778080", 0x20)]
public struct SC0778080
{
    public DynamicArray<SC3778080> SocketEntries;
    public DynamicArray<SC8778080> IntrinsicSockets;
}

/// <summary>
/// "socketEntries" from API
/// </summary>
[SchemaStruct("C3778080", 0x58)]
public struct SC3778080
{
    public short SocketTypeIndex; // 'socketTypeHash' 
    public short Unk02;
    public short Unk04;
    public short SingleInitialItemIndex; // 'singleInitialItemHash'
    [SchemaField(0x10)]
    public short ReusablePlugSetIndex1; // randomizedPlugSetHash -> reusablePlugItems
    //[SchemaField(0x18)]
    //public DynamicArray<S3A7A8080> Unk18;
    [SchemaField(0x28)]
    public short ReusablePlugSetIndex2; // randomizedPlugSetHash -> reusablePlugItems
    [SchemaField(0x48)]
    public DynamicArray<SD5778080> PlugItems; // reusablePlugSetHash -> reusablePlugItems
}

[SchemaStruct("CD778080", 0x18)]
public struct SCD778080
{
    public long FileSize;
    public DynamicArrayUnloaded<SD3778080> PlugSetDefinitionEntries;
}

[SchemaStruct("D3778080", 0x18)]
public struct SD3778080
{
    public TigerHash PlugSetHash;
    [SchemaField(0x8)]
    public DynamicArray<SD5778080> ReusablePlugItems;
}

[SchemaStruct("D5778080", 0x40)]
public struct SD5778080
{
    [SchemaField(0x20)]
    public int PlugInventoryItemIndex;
    [SchemaField(0x28)]
    public DynamicArray<S3A7A8080>? UnkUnlocks;
}

[SchemaStruct("C8778080", 0x4)]
public struct SC8778080
{
    public short SocketTypeIndex; // socketTypeHash
    public short PlugItemIndex; // plugItemHash
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "A1738080", 0x128)]
public struct SA1738080
{
    public TigerHash PlugCategoryHash;
    [SchemaField(0xF8, TigerStrategy.MARATHON_ALPHA)]
    public StringHash PlugStyle; // 'uiPlugLabel', theres only none (invalid) and masterwork (6048A01E)
}

#endregion

#region Socket Category
[SchemaStruct("B6768080", 0x18)]
public struct SB6768080
{
    public long FileSize;
    public DynamicArrayUnloaded<SBA768080> SocketTypeEntries;
}

[SchemaStruct("BA768080", 0x68)]
public struct SBA768080
{
    public TigerHash SocketTypeHash;
    public short Unk04;
    public short SocketCategoryIndex; // 'socketCategoryHash'
    public int SocketVisiblity; // 'visibility'

    [SchemaField(0x30)]
    public DynamicArray<SC5768080> PlugWhitelists;
}

[SchemaStruct("C5768080", 0x8)]
public struct SC5768080
{
    public TigerHash PlugCategoryHash;
    public short Unk04;
}

[SchemaStruct("594F8080", 0x18)]
public struct S594F8080
{
    public long FileSize;
    public DynamicArrayUnloaded<S5D4F8080> SocketCategoryEntries;
}

[SchemaStruct("5D4F8080", 0x18)]
public struct S5D4F8080
{
    public TigerHash SocketCategoryHash;
    public StringIndexReference SocketName;
    public StringIndexReference SocketDescription;
    public uint CategoryStyle; // 'uiCategoryStyle'
}
#endregion

#region Collectables

[SchemaStruct("28788080", 0x18)]
public struct S28788080
{
    public long FileSize;
    public DynamicArrayUnloaded<S2C788080> CollectibleDefinitionEntries;
}

[SchemaStruct("2C788080", 0xB0)]
public struct S2C788080
{
    [SchemaField(0x18)]
    public DynamicArray<SF7788080> ParentNodeHashes;
    public TigerHash CollectibleHash;
    public short InventoryItemIndex;
    [SchemaField(0x30)]
    public DynamicArray<S3A7A8080> UnkUnlock30;
    [SchemaField(0x60)]
    public DynamicArray<S3A7A8080> UnkUnlockClass;
    public DynamicArray<S3A7A8080> Unk70;
}

[SchemaStruct("F7788080", 2)]
public struct SF7788080
{
    public short ParentNodeHashIndex;
}


[SchemaStruct("BF598080", 0x18)]
public struct SBF598080
{
    public long FileSize;
    public DynamicArrayUnloaded<SC3598080> CollectibleDefinitionStringEntries;
}

[SchemaStruct("C3598080", 0x60)]
public struct SC3598080
{
    public TigerHash CollectibleHash;
    public int Unk04;
    public StringIndexReference CollectibleName;
    [SchemaField(0x18)]
    public StringIndexReference SourceName;
    public StringIndexReference RequirementDescription;
}

#endregion

#region Objectives
// objective definition
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "3C758080", 0x18)]
public struct S3C758080
{
    [SchemaField(0x8)]
    public DynamicArrayUnloaded<S40758080> ObjectiveDefinitionEntries;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "40758080", 0xB0)]
public struct S40758080
{
    public TigerHash ObjectiveHash;
    [SchemaField(0x10, TigerStrategy.MARATHON_ALPHA)]
    public int CompletionValue;
}

// objective definition strings
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "4C588080", 0x18)]
public struct S4C588080
{
    [SchemaField(0x8)]
    public DynamicArrayUnloaded<S50588080> ObjectiveDefinitionStringEntries;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "50588080", 0x58)]
public struct S50588080
{
    public TigerHash ObjectiveHash;
    public short IconIndex;
    [SchemaField(0x18)]
    public StringIndexReference ProgressDescription;
    public byte InProgressValueStyle; // enum DestinyUnlockValueUIStyle ?
    public byte CompletedValueStyle;
    public short LocationIndex; // 'locationHash' DestinyLocationDefinition
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "B0738080", 0x28)]
public struct SB0738080
{
    public DynamicArray<S15908080> Objectives;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "15908080", 0x2)]
public struct S15908080
{
    public short ObjectiveIndex;
}
#endregion

#region DestinyPresentationNodeDefinitions
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "D7788080", 0x18)]
public struct SD7788080
{
    [SchemaField(0x8)]
    public DynamicArray<SDB788080> PresentationNodeDefinitions;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "DB788080", 0xC8)]
public struct SDB788080
{
    [SchemaField(0x18)]
    public DynamicArray<SF7788080> ParentNodes;
    [SchemaField(0x2C)]
    public int MaxCategoryRecordScore;
    [SchemaField(0x30)]
    public TigerHash Hash;
    public byte NodeType;
    public byte Scope;
    [SchemaField(0x58)]
    public short ObjectiveIndex;
    public short CompletionRecordIndex; // completionRecordHash
    [SchemaField(0x70)]
    public DynamicArray<SED788080> PresentationNodes; // children -> presentationNodes
    public DynamicArray<SEA788080> Collectables; // children -> collectibles
    public DynamicArray<SE7788080> Records; // children -> records
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "ED788080", 0x18)]
public struct SED788080
{
    public short Unk00; // nodeDisplayPriority? Always 0 in api though
    public short PresentationNodeIndex; // presentationNodeHash
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "EA788080", 0x4)]
public struct SEA788080
{
    public short Unk00;
    public short CollectableIndex; // Collectable index
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "E7788080", 0x6)]
public struct SE7788080
{
    public short Unk00;
    public short RecordDefinitionIndex; // RecordDefinition index
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "03588080", 0x18)]
public struct S03588080
{
    [SchemaField(0x8)]
    public DynamicArray<S07588080> PresentationNodeDefinitionStrings;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "07588080", 0x2C)]
public struct S07588080
{
    public TigerHash NodeHash;
    public int IconIndex;
    public StringIndexReference Name;
    public StringIndexReference Description;
}
#endregion

#region DestinyRecordDefinition
[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "1F718080", 0x18)]
public struct S1F718080
{
    [SchemaField(0x8)]
    public DynamicArray<SC16F8080> RecordDefinitions;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C16F8080", 0xE8)]
public struct SC16F8080
{
    [SchemaField(0x18)]
    public DynamicArray<SF7788080> ParentNodeHashes;

    [SchemaField(0x30)]
    public TigerHash Hash;
    public short LoreIndex;

    [SchemaField(0x38)]
    public DynamicArray<SC96F8080> ObjectiveHashes;

    [SchemaField(0x64)]
    public int ScoreValue;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "C96F8080", 0x2)]
public struct SC96F8080
{
    public short ObjectiveIndex;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "87588080", 0x18)]
public struct S87588080
{
    [SchemaField(0x8)]
    public DynamicArray<S8B588080> RecordDefinitionStrings;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "8B588080", 0x90)]
public struct S8B588080
{
    public TigerHash Hash;
    public int IconIndex;
    public StringIndexReference Name;
    public StringIndexReference Description;
    public StringIndexReference RecordTypeName;
    public StringIndexReference ObscuredName;
    public StringIndexReference ObscuredDescription;

    [SchemaField(0x50)]
    public DynamicArray<S93588080> RewardItems;
}

[SchemaStruct(TigerStrategy.MARATHON_ALPHA, "93588080", 0x18)]
public struct S93588080
{
    public int ItemIndex; // InventoryItem index
    public int Quantity;
}
#endregion

