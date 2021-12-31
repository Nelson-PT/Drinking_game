using UnityEngine;
using UnityEngine.UI;
using System;

public class GameControl : MonoBehaviour {

    //private static GameObject whoWinsTextShadow; //, player1MoveText, player2MoveText;

    public static GameObject player1, player2, player3,player4,player5,player6,player7,player8,player9,player10;

    private GameObject button_chose1,button_chose2;

   // public static String text, text1, text2, text3, text4, text5, text6, text7text8, text9, text10, text11, text12, text13, text14, text15, text16, text17, text18, text19, text20, text21, text22, text23, text24, text25, text26, text27, text28, text29, text30;

    public static int diceSideThrown = 0;
    /*public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;
    public static int player5StartWaypoint = 0;
    public static int player6StartWaypoint = 0;
    public static int player7StartWaypoint = 0;
    public static int player8StartWaypoint = 0;
    public static int player9StartWaypoint = 0;
    public static int player10StartWaypoint = 0;*/
    public static int number_players=2;
    public static GameObject[] players;
    public static bool gameOver = false;
    public static bool just_a_roll = false;
    public static GameObject just_a_roll_player;
    public static bool if_six_start=false;

    // Use this for initialization 
    void Start () {

        //whoWinsTextShadow = GameObject.Find("WhoWinsText");
        //player1MoveText = GameObject.Find("Player1MoveText");
        //player2MoveText = GameObject.Find("Player2MoveText");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        player5 = GameObject.Find("Player5");
        player6 = GameObject.Find("Player6");
        player7 = GameObject.Find("Player7");
        player8 = GameObject.Find("Player8");
        player9 = GameObject.Find("Player9");
        player10 = GameObject.Find("Player10");
        button_chose1 = GameObject.Find("choose1");
        button_chose2 = GameObject.Find("choose2");
        button_chose1.SetActive(false);
        button_chose2.SetActive(false);

        players = new GameObject[] { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10 };


        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;
        player5.GetComponent<FollowThePath>().moveAllowed = false;
        player6.GetComponent<FollowThePath>().moveAllowed = false;
        player7.GetComponent<FollowThePath>().moveAllowed = false;
        player8.GetComponent<FollowThePath>().moveAllowed = false;
        player9.GetComponent<FollowThePath>().moveAllowed = false;
        player10.GetComponent<FollowThePath>().moveAllowed = false;

        //whoWinsTextShadow <SetActive> ();
        //player1MoveText.gameObject.SetActive(true);
        //player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1.GetComponent<FollowThePath>().playerStartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player1))
                player1.GetComponent<FollowThePath>().playerStartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player1);

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2.GetComponent<FollowThePath>().playerStartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player2))
                player2.GetComponent<FollowThePath>().playerStartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player2);

        if (player3.GetComponent<FollowThePath>().waypointIndex >
            player3.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player3.GetComponent<FollowThePath>().moveAllowed = false;
            player3.GetComponent<FollowThePath>().playerStartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player3))
                player3.GetComponent<FollowThePath>().playerStartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex ;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player3);

        if (player4.GetComponent<FollowThePath>().waypointIndex >
            player4.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player4.GetComponent<FollowThePath>().moveAllowed = false;
            player4.GetComponent<FollowThePath>().playerStartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player4))
                player4.GetComponent<FollowThePath>().playerStartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player4);

        if (player5.GetComponent<FollowThePath>().waypointIndex >
            player5.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player5.GetComponent<FollowThePath>().moveAllowed = false;
            player5.GetComponent<FollowThePath>().playerStartWaypoint = player5.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player5))
                player5.GetComponent<FollowThePath>().playerStartWaypoint = player5.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player5);

        if (player6.GetComponent<FollowThePath>().waypointIndex >
             player6.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player6.GetComponent<FollowThePath>().moveAllowed = false;
            player6.GetComponent<FollowThePath>().playerStartWaypoint = player6.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player6))
                player6.GetComponent<FollowThePath>().playerStartWaypoint = player6.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player6);

        if (player7.GetComponent<FollowThePath>().waypointIndex >
            player7.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player7.GetComponent<FollowThePath>().moveAllowed = false;
            player7.GetComponent<FollowThePath>().playerStartWaypoint = player7.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player7))
                player7.GetComponent<FollowThePath>().playerStartWaypoint = player7.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player7);

        if (player8.GetComponent<FollowThePath>().waypointIndex >
            player8.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player8.GetComponent<FollowThePath>().moveAllowed = false;
            player8.GetComponent<FollowThePath>().playerStartWaypoint = player8.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player8))
                player8.GetComponent<FollowThePath>().playerStartWaypoint = player8.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player8);

        if (player9.GetComponent<FollowThePath>().waypointIndex >
           player9.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player9.GetComponent<FollowThePath>().moveAllowed = false;
            player9.GetComponent<FollowThePath>().playerStartWaypoint = player9.GetComponent<FollowThePath>().waypointIndex - 1;
            if(Moveback(player9))
                player9.GetComponent<FollowThePath>().playerStartWaypoint = player9.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player9);

        if (player10.GetComponent<FollowThePath>().waypointIndex >
            player10.GetComponent<FollowThePath>().playerStartWaypoint + diceSideThrown)
        {
            player10.GetComponent<FollowThePath>().moveAllowed = false;
            player10.GetComponent<FollowThePath>().playerStartWaypoint = player10.GetComponent<FollowThePath>().waypointIndex - 1;
            if (Moveback(player10))
                player10.GetComponent<FollowThePath>().playerStartWaypoint = player10.GetComponent<FollowThePath>().waypointIndex;
            Dice.play_player.text = "Player " + Dice.whosTurn + " to play!";
            Dice.coroutineAllowed = true;
        }
        else Stopmoveback(player10);






        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            gameOver = true;
        }
    }

    private bool Moveback(GameObject player)
    {
        bool movedback = false;
        //Debug.Log(player.GetComponent<FollowThePath>().waypointIndex);
        switch (player.GetComponent<FollowThePath>().waypointIndex)
        {
             case 10: //go back 3
                player.GetComponent<FollowThePath>().movebackAllowed = true;
                player.GetComponent<FollowThePath>().waypointIndex = player.GetComponent<FollowThePath>().waypointIndex - 4;
                movedback = true;
                break;
                //case 13: //all players go back 1 
             case 15: //chose drink 3 or go back 8
                button_chose1.SetActive(true);
                button_chose2.SetActive(true);
                button_chose1.GetComponent<Button>().onClick.AddListener(Drink3);
                button_chose1.GetComponent<Button>().onClick.AddListener(delegate {Goback8(player);});
                break;
             case 22: //go back 10
                player.GetComponent<FollowThePath>().movebackAllowed = true;
                player.GetComponent<FollowThePath>().waypointIndex = player.GetComponent<FollowThePath>().waypointIndex - 11;
                movedback = true;
                break;
             case 23: //roll the dice if 6 go back to start
                if_six_start = true;
                break;
                //case 25: //talvez! coin head or tails!
             case 26: //roll the dice, drink and go back the result
                just_a_roll = true;
                just_a_roll_player = player;
                break;
             case 28: //drink and miss a turn
                player.GetComponent<FollowThePath>().turn_miss = true;
                break;
             case 30: //go back 8
                player.GetComponent<FollowThePath>().movebackAllowed = true;
                player.GetComponent<FollowThePath>().waypointIndex = player.GetComponent<FollowThePath>().waypointIndex - 9;
                movedback = true;
                break;
             case 31: //go back to start
                player.GetComponent<FollowThePath>().movebackAllowed = true;
                player.GetComponent<FollowThePath>().waypointIndex = 0;
                movedback = true;
                break;
        }
        return movedback;
    }
    private void Stopmoveback(GameObject player)
    {
        if (player.GetComponent<FollowThePath>().movebackAllowed && player.GetComponent<FollowThePath>().transform.position == player.GetComponent<FollowThePath>().waypoints[player.GetComponent<FollowThePath>().waypointIndex].transform.position)
            player.GetComponent<FollowThePath>().movebackAllowed = false;
    }


    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 5:
                player5.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 6:
                player6.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 7:
                player7.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 8:
                player8.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 9:
                player9.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 10:
                player10.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
    void Drink3()
    {
        button_chose1.SetActive(false);
        button_chose2.SetActive(false);
    }
    void Goback8(GameObject player)
    {
        button_chose1.SetActive(false);
        button_chose2.SetActive(false);
        player.GetComponent<FollowThePath>().movebackAllowed = true;
        player.GetComponent<FollowThePath>().waypointIndex = player.GetComponent<FollowThePath>().waypointIndex - 9;
        player.GetComponent<FollowThePath>().playerStartWaypoint = player.GetComponent<FollowThePath>().waypointIndex;
    }
    public static void Moveback_AUX(GameObject player, int dice)
    {
        player.GetComponent<FollowThePath>().movebackAllowed = true;
        player.GetComponent<FollowThePath>().waypointIndex = player.GetComponent<FollowThePath>().waypointIndex - dice+1;
        player.GetComponent<FollowThePath>().playerStartWaypoint = player.GetComponent<FollowThePath>().waypointIndex;
    }
}
