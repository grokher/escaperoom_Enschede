using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Vector3 targetPosition;
    private Vector3 beginPos;
    public GameObject puzzle;
    public int number;
    private float correctX;
    private float correctY;
    private float correctZ;
    public bool inRightPlace;
    
    void Awake()
    {
   
        beginPos = transform.position;
        targetPosition = transform.position;
    }


    void Update()
    {
        MoveTile();
        
    }

    void MoveTile()
    {
        if (puzzle.GetComponent<SlidingGame>().hasClicked == true)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);
        }
        if(puzzle.GetComponent<SlidingGame>().hasShuffledOnce == true)
            transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);
        if (puzzle.GetComponent<SlidingGame>().hasShuffled == true)
        {
            correctX = Mathf.Abs(transform.position.x - beginPos.x);
            correctY = Mathf.Abs(transform.position.y - beginPos.y);
            correctZ = Mathf.Abs(transform.position.z - beginPos.z);
        }
        if (correctX <= 0.1f && correctY <= 0.1f && correctZ <= 0.1f)
        {
            inRightPlace = true;

        }
        else
        {
            inRightPlace = false;
        }
    }
    
}
