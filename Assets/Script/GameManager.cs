using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TextMeshProUGUI HPIndicator;
    float time = 0;
    public GameObject PlayerCharacter;
    void Start()
    {
        GetComponent<Stats>().hp = GetComponent<Stats>().maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        HPIndicator.text = GetComponent<Stats>().hp.ToString();
    }

    void gameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    public void TakeDamage(float damageAmount)
    {
        GetComponent<Stats>().hp -= damageAmount;
        if (GetComponent<Stats>().hp <= 0)
        {
            gameOver();
        }
    }
    
    void OnCollisionStay2D(Collision2D collision)
    {
        TakeDamage(1);
    }
}