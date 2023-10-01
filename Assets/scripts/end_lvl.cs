using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_lvl : MonoBehaviour
{
private AudioSource lvlDone;
    private bool levelCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        lvlDone = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            lvlDone.Play();
            Invoke("FinLevel", 2f);
        }
    }

    private void FinLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
