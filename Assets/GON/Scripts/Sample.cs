using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GON.TelloController;

public class Sample : MonoBehaviour {
	// Use this for initialization
	void Start () {
        //UDPクライアントを接続する
        Controller.Initialize();
	}
	
	// Update is called once per frame
	void Update () {

        //Telloに実際にConnectするのはInitializeと同時じゃ動かなかった
        if (Input.GetKeyDown(KeyCode.C))
        {
            Controller.Connect();
        }

        //離陸しましょ
        if (Input.GetKeyDown(KeyCode.T))
        {
            Controller.TakeOff();
        }

        //着陸しましょ
        if (Input.GetKeyDown(KeyCode.L))
        {
            Controller.Land();
        }

        //緊急停止しましょ
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Controller.EmergencyStop();
        }

        //微速前進！
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Controller側で設定されてる移動速度を使う
            Controller.Forward();

            //全速前進！
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //速度をオーバーライドする
                Controller.Forward(100);
            }
        }

        //微速後退！
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Controller側で設定されてる移動速度を使う
            Controller.Backward();

            //全速後退！
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //速度をオーバーライドする
                Controller.Backward(100);
            }
        }

        //右いきまひょ
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Controller.Right();
        }

        //左いきまひょ
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Controller.Left();
        }

        //アゲアゲ
        if (Input.GetKey(KeyCode.U))
        {
            Controller.Up();
        }

        //sage
        if (Input.GetKey(KeyCode.D))
        {
            Controller.Down();
        }

        /*　左右上下も前進後退と同じく速度オーバーライドがあります。
         */


    }
}
