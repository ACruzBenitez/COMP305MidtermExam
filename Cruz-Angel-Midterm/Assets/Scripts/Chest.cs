using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private PlayerScript _playerController;
    // Start is called before the first frame update
    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if(_playerController.chestclass)
        {
            Debug.Log("alo");
        }        
    }
}
