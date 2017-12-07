using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //要素(箱)の数
        int[] array = new int[5];

        array[0] = 20;
        array[1] = 34;
        array[2] = 30;
        array[3] = 40;
        array[4] = 38;

        //要素の表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss Magic = new Boss();

        // 攻撃用の関数を呼び出す
        Magic.Attack();
        // 防御用の関数を呼び出す
        Magic.Defence(3);
        //Magic関数を呼び出す
        for (int i = 0; i < 11; i++)//Magic関数を10回使った後に、更にMagic関数を呼び出すと
        {
            Magic.Magic(5);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}



//発展課題


public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //MP　変数の初期化

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // マジックの関数
    public void Magic(int mp)
    {

        if (this.mp >= 5)  {
            //　残りmpを減らす
            this.mp -= mp;
         //mpが３以上だった場合
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            //mpが3未満だった場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}
