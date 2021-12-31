using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dice : MonoBehaviour {
    private static InputField input_box;
    public static Text play_player;
    public static int number_players=2;
    private bool first_time = true;
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public static int whosTurn = 1;
    public static int whosTurn_6 = 0;
    public static bool coroutineAllowed = true;

	// Use this for initialization
	private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
        play_player = GameObject.Find("play_player").GetComponent<Text>();
	}

    private void OnMouseDown()
    {
        if (first_time)
        {
            input_box = GameObject.Find("InputField").GetComponent<InputField>();
            input_box.interactable=false;
            first_time = false;
            try{
                number_players = Int32.Parse(input_box.text);
            }
            catch
            {
                number_players = 2;
            }
            if (number_players < 2)
                number_players = 2;
            else if (number_players > 10)
                number_players = 10;
            for (int i=0; i<10-number_players; i++)
            {
                GameControl.players[i + number_players].SetActive(false);
            }
            //Debug.Log(number_players);
        }
        if (GameControl.if_six_start)
        {
            StartCoroutine(Go_back_if_6());
        }else if(GameControl.just_a_roll)
        {
            GameControl.just_a_roll = false;
            StartCoroutine(Just_a_roll());
        }else if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = UnityEngine.Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        switch (whosTurn)
        {
            case 1:
                GameControl.MovePlayer(1);
                break;
            case 2: 
                GameControl.MovePlayer(2);
                break;
            case 3:
                GameControl.MovePlayer(3);
                break;
            case 4:
                GameControl.MovePlayer(4);
                break;
            case 5:
                GameControl.MovePlayer(5);
                break;
            case 6:
                GameControl.MovePlayer(6);
                break;
            case 7:
                GameControl.MovePlayer(7);
                break;
            case 8:
                GameControl.MovePlayer(8);
                break;
            case 9:
                GameControl.MovePlayer(9);
                break;
            case 10:
                GameControl.MovePlayer(10);
                break;
        }
        whosTurn++;
        if (whosTurn > number_players)
            whosTurn = 1;
        if (GameControl.players[whosTurn].GetComponent<FollowThePath>().turn_miss)
        {
            whosTurn++;
            GameControl.players[whosTurn].GetComponent<FollowThePath>().turn_miss = false;
            if (whosTurn > number_players)
                whosTurn = 1;
        }
        

        //play_player.text = "Player " + whosTurn + " to play!";
    }
    private  IEnumerator Just_a_roll()
    {
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = UnityEngine.Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        //GameControl.diceSideThrown = randomDiceSide + 1;
        GameControl.Moveback_AUX(GameControl.just_a_roll_player,randomDiceSide + 1);
        whosTurn++;
    }
    private IEnumerator Go_back_if_6()
    {
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = UnityEngine.Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        if(randomDiceSide+1==6)
            GameControl.Moveback_AUX(GameControl.players[whosTurn - 1], GameControl.players[whosTurn - 1].GetComponent<FollowThePath>().waypointIndex);
        if (whosTurn == whosTurn_6)
            GameControl.if_six_start = false;
        whosTurn++;
        if (whosTurn > number_players)
            whosTurn = 1;
    }
}
