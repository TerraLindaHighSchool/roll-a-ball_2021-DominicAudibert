using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject closeCamera;
    public GameObject mainCamera;
    private void OnTriggerEnter(Collider other)
    {
        closeCamera.SetActive(true);
        mainCamera.SetActive(false);
    }

}
