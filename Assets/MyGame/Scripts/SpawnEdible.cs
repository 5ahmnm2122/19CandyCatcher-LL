using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEdible : MonoBehaviour
{
    public Edible1 edible1Prefab;
    public Edible2 edible2Prefab;
    public Edible3 edible3Prefab;
    public Edible4 edible4Prefab;
    public Edible5 edible5Prefab;

    public GameObject edibleParent;

    IEnumerator Start()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(1);
            SpawnEdible1();

            yield return new WaitForSeconds(1);
            SpawnEdible2();

            yield return new WaitForSeconds(1);
            SpawnEdible3();

            yield return new WaitForSeconds(1);
            SpawnEdible4();

            yield return new WaitForSeconds(2);
            SpawnEdible5();
        }

    }

    void SpawnEdible1()
    {
        Edible1 edible1Clone = (Edible1)Instantiate(edible1Prefab, transform.position, transform.rotation);
        float edible1Size = 0.25f;
        edible1Clone.transform.localScale = new Vector3(edible1Size, edible1Size, 0);
        edible1Clone.transform.SetParent(edibleParent.transform);
        edible1Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), edibleParent.transform.position.y, 0f);
        edible1Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(0, 0), UnityEngine.Random.Range(-3, -3));
    }

    private void SpawnEdible2()
    {
        Edible2 edible2Clone = (Edible2)Instantiate(edible2Prefab, transform.position, transform.rotation);
        float edible2Size = 0.25f;
        edible2Clone.transform.localScale = new Vector3(edible2Size, edible2Size, 0);
        edible2Clone.transform.SetParent(edibleParent.transform);
        edible2Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), edibleParent.transform.position.y, 0f);
        edible2Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-3, -3));
    }

    private void SpawnEdible3()
    {
        Edible3 edible3Clone = (Edible3)Instantiate(edible3Prefab, transform.position, transform.rotation);
        float edible3Size = 0.25f;
        edible3Clone.transform.localScale = new Vector3(edible3Size, edible3Size, 0);
        edible3Clone.transform.SetParent(edibleParent.transform);
        edible3Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), edibleParent.transform.position.y, 0f);
        edible3Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-3, -3));


    }

    private void SpawnEdible4()
    {
        Edible4 edible4Clone = (Edible4)Instantiate(edible4Prefab, transform.position, transform.rotation);
        float edible4Size = 0.25f;
        edible4Clone.transform.localScale = new Vector4(edible4Size, edible4Size, 0);
        edible4Clone.transform.SetParent(edibleParent.transform);
        edible4Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), edibleParent.transform.position.y, 0f);
        edible4Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-3, -3));

    }

    private void SpawnEdible5()
    {
        Edible5 edible5Clone = (Edible5)Instantiate(edible5Prefab, transform.position, transform.rotation);
        float edible5Size = 0.25f;
        edible5Clone.transform.localScale = new Vector3(edible5Size, edible5Size, 0);
        edible5Clone.transform.SetParent(edibleParent.transform);
        edible5Clone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), edibleParent.transform.position.y, 0f);
        edible5Clone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-0, 0), UnityEngine.Random.Range(-3, -3));

    }

}
