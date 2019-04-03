﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;         // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔法力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic(int reducemp){
        if (mp >= reducemp)
        {
            //残りmpを減らす
            this.mp -= reducemp;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}


public class Test : MonoBehaviour{


    void Start() {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を呼び出す
        int[] mpoints = { 5, 5, 5, 5, 5, 5, 5, 5, 5,5,5};
        for (int i = 0; i < mpoints.Length; i++) {
            lastboss.Magic(mpoints[i]);
        }

 }

    // Update is called once per frame
    void Update(){

    }
}