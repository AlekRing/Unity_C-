using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Spinner : MonoBehaviour
{
    [SerializeField] float randomSpinnerRotation = 720f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, randomSpinnerRotation * Time.deltaTime);
    }
}
