
using Internal.Fbx;

namespace Tiger.Schema.Entity;

public class EntitySkeleton : EntityResource
{
    public EntitySkeleton(FileHash resource) : base(resource)
    {
    }

    public List<BoneNode> GetBoneNodes()
    {
        using TigerReader reader = GetReader();
        var nodes = new List<BoneNode>();
        dynamic? resource = _tag.Unk18.GetValue(reader);

        if (resource is SB79F8080 skelInfo)
        {
            for (int i = 0; i < skelInfo.NodeHierarchy.Count; i++)
            {
                BoneNode node = new();
                node.ParentNodeIndex = skelInfo.NodeHierarchy[reader, i].ParentNodeIndex;
                node.Hash = skelInfo.NodeHierarchy[reader, i].NodeHash;
                node.DefaultObjectSpaceTransform = new ObjectSpaceTransform
                {
                    QuaternionRotation = skelInfo.DefaultObjectSpaceTransforms[reader, i].Rotation,
                    Translation = skelInfo.DefaultObjectSpaceTransforms[reader, i].Translation.ToVec3(),
                    Scale = skelInfo.DefaultObjectSpaceTransforms[reader, i].Translation.W
                };
                node.DefaultInverseObjectSpaceTransform = new ObjectSpaceTransform
                {
                    QuaternionRotation = skelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Rotation,
                    Translation = skelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Translation.ToVec3(),
                    Scale = skelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Translation.W
                };
                nodes.Add(node);
            }
        }
        else if (resource is SAF9F8080 weirdSkelInfo)
        {
            Console.WriteLine($"Whack");
            for (int i = 0; i < weirdSkelInfo.NodeHierarchy.Count; i++)
            {
                BoneNode node = new();
                node.ParentNodeIndex = weirdSkelInfo.NodeHierarchy[reader, i].ParentNodeIndex;
                node.Hash = weirdSkelInfo.NodeHierarchy[reader, i].NodeHash;
                node.DefaultInverseObjectSpaceTransform = new ObjectSpaceTransform
                {
                    QuaternionRotation = weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Rotation,
                    Translation = weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Translation.ToVec3(),
                    Scale = weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Translation.W
                };
                // no DOST, so calculate inverse DIOST
                Vector4 inverseRotation = weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Rotation;
                inverseRotation.W = -inverseRotation.W;

                Vector4 inverseTranslation = weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Translation;
                inverseTranslation = Vector4.QuaternionMultiply(inverseRotation, inverseTranslation);
                inverseTranslation = Vector4.QuaternionMultiply(inverseTranslation, weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Rotation);
                node.DefaultObjectSpaceTransform = new ObjectSpaceTransform
                {
                    QuaternionRotation = inverseRotation,
                    Translation = inverseTranslation.ToVec3(),
                    Scale = weirdSkelInfo.DefaultInverseObjectSpaceTransforms[reader, i].Translation.W
                };
                nodes.Add(node);
            }
        }

        return nodes;
    }
}


public struct ObjectSpaceTransform
{
    public Vector4 QuaternionRotation;
    public Vector3 Translation;
    public float Scale;
}
public struct BoneNode
{
    public ObjectSpaceTransform DefaultObjectSpaceTransform;
    public ObjectSpaceTransform DefaultInverseObjectSpaceTransform;
    public int ParentNodeIndex;
    public TigerHash Hash;
    public FbxNode Node;
}
