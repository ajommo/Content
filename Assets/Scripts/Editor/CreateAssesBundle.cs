using UnityEditor;

public class CreateAssetBundle : Editor
{
    [MenuItem("Assets/Build Bundles")]
    static void BuildAllAssetBundles()
    {
        BuildPipeline.BuildAssetBundles(@"C:\Game\Data", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }
}