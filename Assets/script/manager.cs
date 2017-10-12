using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour {
	public Text text;
	public Text logtext;
	public Image[] player;
	public Image[] enemy;
	public status[] PS = new status[4];
	public status[] ES =new status[4];
	public int Rand;
	public string TURN;
	public Sprite[] texture;
	public Image image;
	public float time;
	public int turnnonber;
	public int wazaN;
	// Use this for initialization
	void Start ()
	{
		for(int i=0;i<player.Length;i++)
		{
			PS [i] = player[i].GetComponent<status> ();
			player [i].GetComponent<Outline> ().enabled = false;
		}

		for(int i=0;i<enemy.Length;i++)
		{
			ES [i] = enemy [i].GetComponent<status> ();
			enemy [i].GetComponent<Outline> ().enabled = false;
		}

		Rand = (int)Random.Range (0, 2);
		if (Rand == 0) {
			TURN = "enemy";
			image.GetComponent<Image>().sprite= texture [0];
		} else {
			TURN = "player";
			image.GetComponent<Image>().sprite= texture [1];
		}
		image.enabled = true;
		time = 0;

	}
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time > 1.5f)
			image.enabled = false;
		
		if (Input.GetKeyDown (KeyCode.Space))
			SceneManager.LoadScene ("map");

		if (TURN == "player") {
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				if (wazaN > 4)
					wazaN = 0;
				else
					wazaN++;
			}
			


			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				if (wazaN < 0)
					wazaN = 4;
				else
					wazaN--;
			}

			for (int k = 0; k < player.Length; k++) {
				if (k == turnnonber)
					player [k].GetComponent<Outline> ().enabled = true;
				else
					player [k].GetComponent<Outline> ().enabled = false;
			}
			


			switch (wazaN) {
			case 0:
				text.GetComponent<Text> ().text = "\t〇1" + PS [turnnonber].waza [0] + "\n\t\t2" + PS [turnnonber].waza [1] + "\n\t\t3" + PS [turnnonber].waza [2] + "\n\t\t4" + PS [turnnonber].waza [3];
				if (Input.GetKeyDown (KeyCode.Return)) {
					logtext.GetComponent<Text> ().text = PS [turnnonber].name + "の" + PS [turnnonber].waza [0];
					turnnonber++;
				}
				break;
			case 1:
				text.GetComponent<Text> ().text = "\t\t1" + PS [turnnonber].waza [0] + "\n\t〇2"+ PS [turnnonber].waza [1]+"\n\t\t3"+ PS [turnnonber].waza [2]+"\n\t\t4"+ PS [turnnonber].waza [3];
				if (Input.GetKeyDown (KeyCode.Return)) {
					logtext.GetComponent<Text> ().text = PS [turnnonber].name + "の" + PS [turnnonber].waza [1];
					turnnonber++;
				}
				break;
			case 2:
				text.GetComponent<Text> ().text = "\t\t1" + PS [turnnonber].waza [0] + "\n\t\t2"+ PS [turnnonber].waza [1]+"\n\t〇3"+ PS [turnnonber].waza [2]+"\n\t\t4"+ PS [turnnonber].waza [3];
				if (Input.GetKeyDown (KeyCode.Return)) {
					logtext.GetComponent<Text> ().text = PS [turnnonber].name + "の" + PS [turnnonber].waza [2];
					turnnonber++;
				}
				break;
			case 3:
				text.GetComponent<Text> ().text = "\t\t1" + PS [turnnonber].waza [0] + "\n\t\t2"+ PS [turnnonber].waza [1]+"\n\t\t3"+ PS [turnnonber].waza [2]+"\n\t〇4"+ PS [turnnonber].waza [3];
				if (Input.GetKeyDown (KeyCode.Return)) {
					logtext.GetComponent<Text> ().text = PS [turnnonber].name + "の" + PS [turnnonber].waza [3];
					turnnonber++;
				}
				break;
				
			}
			if (turnnonber > 3){
				turnnonber = 0;
				TURN = "enemy";
			}
			}
		}
}
