using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APITest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        print(Mathf.PI);
        print("隨機值 預設 : " + Random.value);

        Time.timeScale = 5;

        int a = -999;
        print("|a| = " + Mathf.Abs(a));

        print("隨機值 1~100 : " + Random.Range(1, 100));
        */

        // print("全部攝影機數量 : " + Camera.allCamerasCount);
        // Cursor.visible = false;
        // print("設定鼠標隱藏");

        // Application.OpenURL("https://www.google.co.jp/");
        print("去小數點 : " + Mathf.FloorToInt(5.1f));
    }

    private void Update()
    {
        // print("是否按下按鈕 : " + Input.anyKey)
        // print("偵測遊戲時間 : " + Time.time);
        print("按下空白 : " + Input.GetKeyDown(KeyCode.Space));

    }
}
