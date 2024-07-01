using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> road;
    [SerializeField] private GameObject Player;
    public int score = 0;
    [SerializeField] private AudioSource oncudoner;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    private void Start()
    {
        scoreText.text = score.ToString("Score = 0");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float distance;
        if (collision.gameObject.CompareTag("road"))
        {
            foreach (GameObject go in road)
            {
                distance = Player.transform.position.x - go.transform.position.x;
                if (distance > 10)
                {
                    go.transform.position += new Vector3(48, 0, 0);
                    go.GetComponent<WallManager>().Change();
                }
            }
        }
        if (collision.gameObject.CompareTag("scorepoint"))
        {
            score++;
            oncudoner.Play();
            scoreText.text = score.ToString("Score = 0");
        }
     
    }


}
