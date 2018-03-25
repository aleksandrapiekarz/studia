using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generationMap : MonoBehaviour
{

    // Use this for initialization
    public GameObject[] _myPrefabs;

    void Start()
    {

        CreatePrefab();
    }

    void CreatePrefab()
    {
        GameObject clone = Instantiate(_myPrefabs[RandomNumber()]) as GameObject;
    }

    int RandomNumber()
    {
        System.Random rand = new System.Random();
        return rand.Next(0, _myPrefabs.Length);
    }

}