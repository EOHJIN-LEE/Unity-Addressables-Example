using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class LoadAssetAsyncExample : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Button loadButton;
    [SerializeField] private Button unLoadButton;

    private void Awake()
    {
        loadButton.onClick.AddListener(Load);
        unLoadButton.onClick.AddListener(UnLoad);
    }

    private AsyncOperationHandle _handle;

    private void Load()
    {
        Addressables.LoadAssetAsync<Sprite>("SampleImage").Completed += handle =>
        {
            _handle = handle;
            image.sprite = handle.Result;
        };
    }

    private void UnLoad()
    {
        Addressables.Release(_handle);
        image.sprite = null;
    }
}
