using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingGame : MonoBehaviour
{
    [SerializeField] private GameObject emptySpace;
    public GameObject player;
    public Camera newCamera;
    public GameObject NewCameraObject;
    public GameObject MozaiekUI;
    public GameObject MozaiekPanel;
    public GameObject exitButton;
    public GameObject raam;
    public GameObject WinScreen;
    [SerializeField] private TileScript[] tiles;
    private int emptySpaceIndex;
    public bool hasShuffled;
    public bool hasShuffledOnce;
    public bool hasClicked;

    [SerializeField] private int clickTimes = 1;
     void Awake() {
        player.SetActive(false);
        MozaiekUI.SetActive(true);
        NewCameraObject.SetActive(true);
        hasShuffled = false;
        hasClicked = false;
        Shuffle();
      
    }
     void Update()
     {
        if (player)
        {
            player.SetActive(false);
            NewCameraObject.SetActive(true);
            MozaiekUI.SetActive(true);
        }
        StartCoroutine("MoveTile");
     }

    IEnumerator MoveTile()
    {
        if (Input.GetMouseButtonDown(0) && clickTimes == 1)
        {
            RaycastHit hit;
            Ray ray = newCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (Vector3.Distance(emptySpace.transform.position, hit.transform.position) < 4.25f)
                {
                    hasClicked = true;
                    Vector3 lastEmptySpacePosition = emptySpace.transform.position;
                    TileScript thisTile = hit.transform.GetComponent<TileScript>();
                    emptySpace.transform.position = thisTile.targetPosition;
                    emptySpace.transform.position = hit.transform.position;
                    thisTile.targetPosition = lastEmptySpacePosition;
                    int tileIndex = findIndex(thisTile);
                    Debug.Log(hasClicked);
                    clickTimes--;
                    yield return new WaitForSeconds(0.9f);
                    if (clickTimes == 0)
                    {
                        clickTimes = 1; //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA I did it :)
                    }
                }
                else
                    Debug.Log("is not adjecent to empty");  
            }
            else
                Debug.Log("has not hit");

            hasClicked = false;
        }
        int correctTiles = 0;
        foreach (var a in tiles)
        {
            if (a != null)
            {

                if (a.inRightPlace)
                    correctTiles++;
            }
        }
        if (correctTiles == tiles.Length)
        {
            emptySpace.GetComponent<SpriteRenderer>().enabled = true;
            WinScreen.SetActive(true);
            player.SetActive(true);
            raam.SetActive(true);
            MozaiekPanel.SetActive(false);
            exitButton.SetActive(false);
        }
    }
    public void Shuffle()
    {
        hasShuffled = true;
        hasShuffledOnce = false;
        int invertion;
        do
        {
            for (int i = 0; i < 7; i++)
            {
                var lastPos = tiles[i].targetPosition;
                int randomIndex = Random.Range(0, 7);
                tiles[i].targetPosition = tiles[randomIndex].targetPosition;
                tiles[randomIndex].targetPosition = lastPos;
                var tile = tiles[i];
                tiles[i] = tiles[randomIndex];
                tiles[randomIndex] = tile;
            }
            invertion = GetInversions();
            Debug.Log("puzzle shuffled");
        } 
       while (invertion%2 != 0);
        hasShuffledOnce = true;
    }
    public int findIndex(TileScript ts)
    {
        for(int i = 0; i < tiles.Length; i++)
        {
            if(tiles[i] != null)
            {
                if(tiles[i] == ts)
                {
                    return i;
                }
            }
        }
        return -1;
    }
    int GetInversions()
    {
        int InversionsSum = 0;
        for(int i = 0; i < tiles.Length; i++)
        {
            int thisTileInversion = 0;
            for (int j = i; j < tiles.Length; j++) {
                if (tiles[j] != null)
                {
                    if (tiles[i].number > tiles[j].number)
                    {
                        thisTileInversion++;
                    }
            } 
          }
            InversionsSum += thisTileInversion;
        }
        return InversionsSum;
    }

    public void Completion()
    {
        //completion button closing the game
    }
}
