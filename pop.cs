using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pop : MonoBehaviour
{
    int scalingFramesLeft = 0;
    public TextMeshProUGUI name;
    

    // Start is called before the first frame update
    void Start()
    {
        //name = GetComponent<TextMeshProUGUI>();
        
    }
    // Update is called once per frame
    private void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        //Debug.Log("enter");
        name.transform.localScale += new Vector3(1.0F, 1.0f, 1.0f); //adjust these values as you see fit
    }


    public void OnMouseExit()
    {
        //Debug.Log("left");
        name.transform.localScale = new Vector3(1, 1, 1);  // assuming you want it to return to its original size when your mouse leaves it.
    }

}
