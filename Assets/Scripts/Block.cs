using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breaksound;

    //Cached Reference
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakablocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breaksound, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
    }

}
