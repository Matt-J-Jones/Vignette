using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMissionEnd : MonoBehaviour
{
    public GameObject levelTransition;
    // Start is called before the first frame update
    void Start()
    {
        levelTransition.gameObject.SetActive(true);
    }
}
