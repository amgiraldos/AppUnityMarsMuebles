using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefabs : MonoBehaviour
{
    public GameObject bed;
    public GameObject lamp;
    public GameObject nightStand;

    public GameObject sphere;
    public GameObject cube;

    public GameObject bedButton;
    public GameObject lampButton;
    public GameObject nightStandButton;

    private void Update()
    {
        if (cube.activeInHierarchy)
        {
            bedButton.SetActive(true);
            nightStandButton.SetActive(true);
        }

        if (sphere.activeInHierarchy)
        {
            lampButton.SetActive(true);
        }
    }

    [ContextMenu("Bed")]
    public void InstantiateBed()
    {
        bed.SetActive(true);
    }

    [ContextMenu("Lamp")]
    public void InstantiateLamp()
    {
        lamp.SetActive(true);
    }

    [ContextMenu("Night Stand")]
    public void InstantiateNightStand()
    {
        nightStand.SetActive(true);
    }
}