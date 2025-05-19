# Addressableを活用してServerと通信する サンプルプロジェクト

このリポジトリは、UnityのAddressableとアマゾンのS3を使ってS3にあるアセバンのAddressable Assetを呼んでみます。

実際にゲームに使用する時はラベルを通じてダウンロードするDownloadDependenciesAsyncを使ってダウンロードして呼んだがいいですが今回の簡単なプロジェクトなの直接でAddressableKeyでS3からAssetを呼びます。

---

## 使用している技術

- Unity 6.0
- Amazon S3
- Addressable
- uGUI
- C#

---

## 実行手順

1. AddressableServerDownloadExampleを開いてPlay
<img width="1381" alt="image" src="https://github.com/user-attachments/assets/de5d1b7d-0113-456c-becc-baea2374def3" />

2. Buttonをクリック

3. Gold＆Silverのイメージが出たら成功
<img width="1348" alt="image" src="https://github.com/user-attachments/assets/21a620db-aead-4387-a9b8-a1f7e9f3b053" />

## このプロジェクトでやっていること

1. 出したいイメージPrefabをAddressable化してKeyを設定
   
2. 出したいイメージPrefab（今回はGold＆Silverイメージ）をRemote Bundleに追加してビルド
<img width="744" alt="image" src="https://github.com/user-attachments/assets/c3eca24a-a0b2-4aef-bfad-ae67ecefb2db" />
（上のイメージではビルドを終わった後Assetを削除したのでRemoteBundleに何もないけどビルドする前にはPrefabはRemoteBundleの下にあるべき）

3.ビルドしたBundleをS3にアップロード
![image](https://github.com/user-attachments/assets/95dcae0c-22f3-40a5-a202-4722809486b2)

4.S3のGetのアクセス権限を許可にする

5.アップロードしたBundleのURLをコーピ

6.Addressable ProfilesのLoadPathに貼る
<img width="911" alt="image" src="https://github.com/user-attachments/assets/2b092b52-8546-4616-86fa-1439f260ca77" />

7.Addressables.InstantiateAsyncで1で設定したKeyを呼ぶ

---

