using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RowBoatBehavior : MonoBehaviour
{
    public GameObject board;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        print("collider: " + collider.tag);
        SceneManager.LoadScene("poly_island");
    }
}
