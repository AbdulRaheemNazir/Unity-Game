using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetReady : MonoBehaviour
{
    public Bird bird;

    void OnGetReadyAnimEnds()
    {
        bird.OnGetReadyAnimFinished();
    }
}
