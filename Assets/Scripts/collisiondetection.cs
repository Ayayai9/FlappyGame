using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetection : MonoBehaviour
{
    [SerializeField] private GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision detected");
        if (col.gameObject.tag == "Pipe")
        {
            Debug.Log("entered detected");
            Time.timeScale = 0;
            end.SetActive(true);
        }
    }
}
