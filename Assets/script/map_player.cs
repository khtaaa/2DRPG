using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map_player : MonoBehaviour { 
	public GameObject[] point;//マップのポイントオブジェクト
	public bool ok;//進めるか
	public float Speed;//playerのマップの移動速度
	public static int nonber;//マップの移動するポイント番号
	public static int now;//現在のポイント番号

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (point [nonber].transform.position.x, point [nonber].transform.position.y);//nonberの位置に移動
		ok = true;//移動可能
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Vector2.MoveTowards (this.transform.position,new Vector2(point[nonber].transform.position.x, point[nonber].transform.position.y), Speed * Time.deltaTime);//nonberの位置にスライド移動

		//ポイントについたらbattleシーンに切り替え
		if (transform.position.x == point [nonber].transform.position.x && transform.position.y == point [nonber].transform.position.y && now!=nonber){
			now = nonber;//現在のポイントをnonberに変更
			ok = true;//移動可能
			Fade_Out.next="battle";
			Fade_Out.fade_ok = true;
		}
			
		//スペースを押したとき移動可能でマップの最後ではなければnonberを次の数にして移動
		if (Input.GetKeyDown (KeyCode.Space) ){
			if(ok==true && nonber<point.Length-1) 
			{
			nonber++;
			ok = false;//移動不可
			} 

			if (ok == true && nonber < point.Length) {
				Fade_Out.next = "clear";
				Fade_Out.fade_ok = true;
			}
		}
		
			
			
	}
}
