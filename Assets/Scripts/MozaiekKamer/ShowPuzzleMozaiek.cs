using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPuzzleMozaiek : MonoBehaviour
{
    [SerializeField] private Camera camera;
    public GameObject puzzle;
    // Start is called before the first frame update
    void Awake()
    {
        puzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.GetComponent<MouseSelect>().activated && camera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name&&Input.GetMouseButtonDown(0))
        {
            puzzle.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
