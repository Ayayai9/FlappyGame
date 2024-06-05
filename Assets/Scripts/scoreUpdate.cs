using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUpdate : MonoBehaviour
{
    public TextMeshProUGUI text;
    public BirdPoint bp;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        increaseScore();
    }
    public void increaseScore()
    {
        text.text = bp.getScore().ToString();
    }
}
