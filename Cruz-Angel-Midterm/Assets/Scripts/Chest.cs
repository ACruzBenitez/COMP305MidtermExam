using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [Header("Spawner")]
    public int starAmount = 10;
    public GameObject [] Stars;

    public float startDelay = 0;
    public float repeatRate = 10;
    private Vector2 spawnPos;

    private PlayerScript _playerController;
    
    [Header("Animation")]
    public bool openchest = false;
    public bool startanim = false;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spawnPos = transform.position;
        InvokeRepeating("SpawnStar", startDelay, repeatRate);

    }

    void Update()
    {
        if (openchest==true && Input.GetKey(KeyCode.E))
            {     
            animator.SetTrigger("Open");
            openchest=false;
            startanim=true;
            }
    }
    void SpawnStar()
    {
        if(startanim==true)
        {
            for(int i = 0; i < starAmount; i++) {
        GameObject starPrefab = Stars[Random.Range(0, Stars.Length)];
        Instantiate(starPrefab, spawnPos, starPrefab.transform.rotation);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player"){
            openchest = true;
        }
        else{
            openchest = false;
        }
    }
}
