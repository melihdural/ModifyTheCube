using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public Vector3 randomPos;

    public float speed = 1.0f;

   
    

    void Start()
    {
        RandomPosition();

        transform.localScale = randomPos * 1.3f;
        
        Material material = Renderer.material;

        material.color = new Color(Random.Range(0,1f), Random.Range(0,1f), Random.Range(0,1f), 1f);
    }
    
    void Update()
    {
        speed = Random.Range(1, 100f);
        transform.Rotate(0.0f, 10.0f * Time.deltaTime * speed, 0.0f);
    }

    private void RandomPosition()
    {
        float xPos = Random.Range(0, 5f);
        float yPos = Random.Range(0, 5f);
        float zPos = Random.Range(0, 5f);
        randomPos = new Vector3(xPos, yPos, zPos);
        
        transform.position = randomPos;


    }
}
