using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class InstantiateAsyncExample : MonoBehaviour
{
    [SerializeField] private Transform root;
    [SerializeField] AssetReference reference;

    private GameObject _cacheObject;

    private void Start()
    {
        reference.InstantiateAsync(root).Completed += handle =>
        {
            _cacheObject = handle.Result;
            
            Invoke(nameof(ReleaseDestroy), 3f); //元々Invokeみたいなもので実装するのはよくないけどExampleなので簡単な実装のために使う
        };
    }

    private void ReleaseDestroy()
    {
        reference.ReleaseInstance(_cacheObject);
    }
}
