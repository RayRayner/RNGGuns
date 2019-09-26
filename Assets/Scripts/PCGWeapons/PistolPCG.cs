using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPCG : MonoBehaviour
{
    public GameObject basePrefab;

    public GameObject[] barrel, body, grip, sight;
    public bool barrelDone, bodyDone, gripDone, sightDone;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GameObject pistol = (GameObject)Instantiate(basePrefab);
            pistol.AddComponent<PistolDamage>();
            if (!bodyDone)
            {
                Transform bodyPos = pistol.transform.Find("Body").gameObject.transform;
                Instantiate(body[Random.Range(0, body.Length - 1)], bodyPos);
                //bodyDone = true;
            }
            if (!barrelDone)
            {
                Transform barrelPos = pistol.transform.Find("Barrel").gameObject.transform;
                Instantiate(barrel[Random.Range(0, barrel.Length - 1)], barrelPos);
                //barrelDone = true;
            }
            if (!sightDone)
            {
                Transform sightPos = pistol.transform.Find("Sight").gameObject.transform;
                Instantiate(sight[Random.Range(0, sight.Length - 1)], sightPos);
                //sightDone = true;
            }
            if (!gripDone)
            {
                Transform gripPos = pistol.transform.Find("Grip").gameObject.transform;
                Instantiate(grip[Random.Range(0, barrel.Length - 1)], gripPos);
                //gripDone = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            Destroy(GameObject.Find("Pistol(Clone)"));
        }

    }
}
