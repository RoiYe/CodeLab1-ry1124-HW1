using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public int goal;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        countText.text = "Goal: " + count.ToString() + "/" + goal;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (count < goal - 1)
        {
            transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), -1);
        }
        else
        {
            gameObject.SetActive(false);
            winText.text = "You Win!";
            winText.gameObject.SetActive(true);
        }
        count = count + 1;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Goal: " + count.ToString() + "/" + goal;
    }
}
