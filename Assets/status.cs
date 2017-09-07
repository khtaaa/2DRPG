using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class status : MonoBehaviour {
	public int HP=100;//体力
	public int MAXHP=100;//最大体力
	public int charge;//チャージ

	public string[] waza;//技の名前
	public int[] waza_power;//技の効果値
	public string[] waza_tipe;//技のタイプ
	public string name;//キャラの名前
	public string STATE;//キャラの状態
}
