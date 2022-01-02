using UnityEngine;

public class FollowThePath : MonoBehaviour {

    public Transform[] waypoints;
    

    [SerializeField]
    private float moveSpeed = 1f;
    

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;
    public bool movebackAllowed = false;
    public bool turn_miss = false;
    public int playerStartWaypoint = 0;
    public bool already_did_this_tile = false;
    public bool developer = false;
    public int dev_tile = 0;

    // Use this for initialization
    private void Start () {
        transform.position = waypoints[waypointIndex].transform.position;
	}
	
	// Update is called once per frame
	private void Update () {
        if (moveAllowed)
        {
            Move();
            already_did_this_tile = false;
        }
        if (movebackAllowed)
        {
            MoveBack();
            already_did_this_tile = false;
        }
        if (developer)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[dev_tile].transform.position,
            moveSpeed * Time.deltaTime);
            waypointIndex = dev_tile;
            playerStartWaypoint = dev_tile;
            //developer = false;
}
	}

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
    public void MoveBack()
    {
        transform.position = Vector2.MoveTowards(transform.position,
        waypoints[waypointIndex].transform.position,
        moveSpeed * Time.deltaTime);

        /*if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex -= 1;
        }*/
    }
}
