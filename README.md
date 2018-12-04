# TelloUDPController
自分用に組んだTelloControllerPackage
死蔵するのもアレなんで公開

# 導入方法
1.[Release](https://github.com/GONBEEEproject/TelloUDPController/releases)から最新のUnityPackageをダウンロードしてください。

2.UnityPackageをインポートします。

# 使い方
詳細はTelloController.cs及びSample.csをよんでね

全機能がNameSpace```GON.TelloController```にあります。
実際に入力系を組み込むスクリプトで
~~~
using GON.TelloController;
~~~
で導入してください。

# 詳細コード
```Initialize()```  TelloにUDP接続します。

```Connect()``` TelloにSDKモード開始コマンドを送ります。

```TakeOff()``` 離陸します。

```Land()```  着陸します。

```EmergencyStop()``` 緊急停止します。

他はそのうち書きます（おなかすいた

# 今後
Telloから飛んできてるレスポンスメッセージのレシーバーを組む予定です。
