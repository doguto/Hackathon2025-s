# Hackathon2025-s
Winc2025夏季ハッカソン用リポジトリ

## Overview

このプロジェクトはWinc2025夏季ハッカソンで開発されたUnityゲームプロジェクトです。

## UsedTech
* C#
* Unity (2022.3.62f1)
* UniRx
* UniTask
* DOTween
* Addressable
* MasterMemory
* MessagePack

## Architecture

プロジェクトのアーキテクチャについては開発進行に伴い更新予定です。

## Directory structure

```
├── Assets/                    # Unityアセットフォルダ
│   ├── AddressableAssetsData/ # Addressableアセットの設定データ
│   ├── Plugins/              # サードパーティプラグイン
│   ├── Project/              # プロジェクト固有のアセット
│   │   ├── DataStore/        # データストレージ (MasterMemory用バイナリデータ等)
│   │   ├── Editor/           # エディタ拡張スクリプト
│   │   ├── Scenes/           # ゲームシーン
│   │   ├── Scripts/          # C#スクリプト
│   │   └── Textures/         # テクスチャファイル
│   └── Resources/            # Resourcesフォルダ
├── Packages/                 # Unity Package Manager設定
├── ProjectSettings/          # Unityプロジェクト設定
└── README.md                 # プロジェクト説明ファイル
```

## Contributors

* [kuto (doguto)](https://github.com/doguto)