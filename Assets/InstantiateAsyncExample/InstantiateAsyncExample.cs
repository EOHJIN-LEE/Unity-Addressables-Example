using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class InstantiateAsyncExample : MonoBehaviour
{
    [SerializeField] private Transform root;
    [SerializeField] AssetReference reference;

    private void Start()
    {
        reference.InstantiateAsync(root);
    }
}
