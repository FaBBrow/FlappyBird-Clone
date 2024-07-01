using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> Wall;
    float axisY;


    private void Start()
    {
        Change();
    }

    public void Change()
    {
        float rand;
        foreach (var w in Wall)
        {
            rand = Random.Range(-5, 5);
           
          
            axisY = rand / 10;
            Debug.Log(axisY);   
            w.transform.localPosition = new Vector2(w.transform.localPosition.x, axisY);
        }
    }
}
