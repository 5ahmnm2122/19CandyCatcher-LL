using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNudelwalker : MonoBehaviour
{
    public Nudelwalker nudelwalkerPrefab;
    public GameObject badParent;

    private void Update()
    {
        
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnNudelWalker_();
        }

    }

    private void SpawnNudelWalker_()
    {
        Nudelwalker nudelwalkerClone = (Nudelwalker)Instantiate(nudelwalkerPrefab, transform.position, transform.rotation);
        float nudelwalkerSize = 0.25f;
        nudelwalkerClone.transform.localScale = new Vector3(nudelwalkerSize, nudelwalkerSize, 0);
        nudelwalkerClone.transform.SetParent(badParent.transform);
        nudelwalkerClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), badParent.transform.position.y, 0f);
        nudelwalkerClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-5, -1));

    }

}