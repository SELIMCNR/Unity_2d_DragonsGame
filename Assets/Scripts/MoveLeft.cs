using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float hizlanma;
    public GameObject drangs;

    // Update is called once per frame
    void Update()
    {
        float index = UnityEngine.Random.RandomRange(-2.0f, 2f);
        transform.Translate(Vector2.left * Time.deltaTime*hizlanma);

        if(transform.position.x < -9.49)
        {
            transform.position = new Vector2(9.49f, -3.3f);
            drangs.transform.position = new Vector2(9.40f, -0.1f +index);
            RandomSprite();
        }

    }

    private void RandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for (int  i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }
}
