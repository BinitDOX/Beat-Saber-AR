﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    public GameObject img;
    private GameObject temp;
    private float wait = 0.3615f;
    //private float wait = 0.358f;
    private float wait2 = 0.104f;
    //private float wait2 = 0.095f;
    private float offset = 12f;
    private float offset2 = 25f;
    private float offset3 = 7f;
    private float offsetY = 17f;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("spawn", 3);
        StartCoroutine(spawn2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, 5f);
    }

    IEnumerator spawn2()
    {
        yield return new WaitForSeconds(20f);
        yield return new WaitForSeconds(4.8f);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait-0.26f);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(0.32f);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset3);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset3);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, -offset2);
        yield return new WaitForSeconds(wait2);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, 0, offset2);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, -offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);
        yield return new WaitForSeconds(wait);
        temp = Instantiate(cube, transform.position, Quaternion.identity, img.transform);
        temp.transform.Translate(0, offsetY, offset2);
        temp.transform.Rotate(45, 0, 0);


    }
}
