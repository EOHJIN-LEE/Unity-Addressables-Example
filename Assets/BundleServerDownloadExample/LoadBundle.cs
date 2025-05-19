using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadBundle : MonoBehaviour
{
    public void Load()
    {
        Addressables.InstantiateAsync("Gold", new Vector3(0,0,0), Quaternion.identity);
    }
}
