using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //要素5の配列を初期化する
        int[] array = { 100, 80, 150, 200, 190 };

        //配列の要素数の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //要素5の配列を初期化する
        int[] points = { 100, 80, 150, 200, 190 };

        //配列の要素数の分だけ処理を繰り返す
        for (int i = points.Length-1;i >= 0; i--)
        {
                Debug.Log(points[i]);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
