using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parkcolor2019 : MonoBehaviour
{

    public Color color;
    public static Color jetPackKeyColor;
        public static Color gunKeyColor;
   

    public static bool passJetPack;
    public static bool passGun;
    public List<int> nonEmittingList;
    public List<int> emittingList;
    public GameObject wGun1;
    public GameObject wGun2;
    public GameObject wGun3;
    public GameObject wGun4;
    public GameObject wGun5;
    public GameObject wGun6;

    public GameObject wJetPack1;
    public GameObject wJetPack2;
    public GameObject wJetPack3;
    public GameObject wJetPack4;
    public GameObject wJetPack5;



    public GameObject GroundColorEmitter;
    public GameObject Tree1;
    public GameObject Tree2;
    public GameObject Tree3;
    public GameObject Tree4;
    public GameObject Tree5;
    public GameObject Tree6;
    public GameObject Tree7;
    public GameObject Tree8;
    public GameObject Tree9;
    public GameObject Tree10;
    public GameObject Tree11;
    public GameObject Tree12;

    public GameObject FutureCar;
    public GameObject CopCar;
    public GameObject ClassicCar;
    float newEmitter;
    public GameObject groundEmitter;
    public static int emitterCount;
    public static List<bool> emittersActivated = new List<bool>() { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {

     
        passJetPack = false;
        passGun = false;

        for (int i = 0; i < 15; i++)
            nonEmittingList.Add(i);
        color = Random.ColorHSV(0, 1, 1, 1, 1, 1);
        // color.a = 255.0f;

        wGun1.GetComponent<Renderer>().material.color = color;
        wGun2.GetComponent<Renderer>().material.color = color;
        wGun3.GetComponent<Renderer>().material.color = color;
        wGun4.GetComponent<Renderer>().material.color = color;
        wGun5.GetComponent<Renderer>().material.color = color;
        wGun6.GetComponent<Renderer>().material.color = color;

        gunKeyColor = color;
        color = Random.ColorHSV(0, 1, 1, 1, 1, 1);

        wJetPack1.GetComponent<Renderer>().material.color = color;
        wJetPack5.GetComponent<Renderer>().material.color = color;
        wJetPack4.GetComponent<Renderer>().material.color = color;
        wJetPack3.GetComponent<Renderer>().material.color = color;
        wJetPack2.GetComponent<Renderer>().material.color = color;

        jetPackKeyColor = color;

        newEmitter = 0;
        emitterCount = 0;
        //  for (int i = 0; i < 15; i++)
        {
            //      Debug.Log("Adding " + (emittersActivated.Count - 1));
            //   emittersActivated.Add(false);
        }

        DeActivateParticleSystem(Tree1);
        DeActivateParticleSystem(Tree2);
        DeActivateParticleSystem(Tree3);
        DeActivateParticleSystem(Tree4);
        DeActivateParticleSystem(Tree5);
        DeActivateParticleSystem(Tree6);
        DeActivateParticleSystem(Tree7);
        DeActivateParticleSystem(Tree8);
        DeActivateParticleSystem(Tree9);
        DeActivateParticleSystem(Tree10);
        DeActivateParticleSystem(Tree11);
        DeActivateParticleSystem(Tree12);
        DeActivateParticleSystem(FutureCar);
        DeActivateParticleSystem(CopCar);
        DeActivateParticleSystem(ClassicCar);


    }

    public int GetRandomIndex()
    {

        Debug.Log(nonEmittingList.Count + " is nel");
        //if(nonEmittingList.Count == 0)
        return nonEmittingList[Random.Range(0, nonEmittingList.Count)];
    }

    public void DeActivateParticleSystem(GameObject gameObject)
    {

        //  Transform[] transforms = gameObject.GetComponentsInChildren<Transform>();

        // transforms[transforms.Length - 1].gameObject.SetActive(false);
    }

    public void GenerateNewParticleEmitter(GameObject aGameObject)
    {

        GameObject newColorEmitter = Instantiate(groundEmitter, aGameObject.transform);


        // Debug.Log(gameObject.name);
        Component[] ps = newColorEmitter.GetComponentsInChildren(typeof(ParticleSystem), true);

        Transform[] transforms = newColorEmitter.GetComponentsInChildren<Transform>();

        // transforms[transforms.Length - 1].gameObject.SetActive(true);
        var main = transforms[transforms.Length - 1].GetComponent<ParticleSystem>().main;

        aGameObject.GetComponent<ChooseColor>().updateColor();
        main.startColor = aGameObject.GetComponent<ChooseColor>().color;


    }
    public ParticleSystem ActivateParticleSystem(GameObject aGameObject)
    {
        //Transform[] transforms = gameObject.GetComponentsInChildren<Transform>();

        GameObject newColorEmitter = Instantiate(groundEmitter, aGameObject.transform);


        // Debug.Log(gameObject.name);
        Component[] ps = newColorEmitter.GetComponentsInChildren(typeof(ParticleSystem), true);

        Transform[] transforms = newColorEmitter.GetComponentsInChildren<Transform>();

        // transforms[transforms.Length - 1].gameObject.SetActive(true);
        var main = transforms[transforms.Length - 1].GetComponent<ParticleSystem>().main;

        main.startColor = aGameObject.GetComponent<ChooseColor>().color;


        //Debug.Log(gameObject.name);
        //  ps[0].gameObject.SetActive(true);
        //Debug.Log(ps[0].gameObject.name);
        return (ParticleSystem)ps[0];

    }
    public void ActivateEmitter(int index)
    {

        nonEmittingList.Remove(index);
       // Debug.Log( index + " IN activeateEmitter");
        if (index == 0)
        {
            GenerateNewParticleEmitter(Tree1);
            emittersActivated[0] = true;
        }
        else if (index == 1)
        {
            GenerateNewParticleEmitter(Tree2);

            emittersActivated[1] = true;
        }
        else if (index == 2) { 
            GenerateNewParticleEmitter(Tree3);
            emittersActivated[2] = true;
        }
        else if (index == 3) {
            GenerateNewParticleEmitter(Tree4);
            emittersActivated[3] = true;
        }
        else if (index == 4) {
            GenerateNewParticleEmitter(Tree5);
            emittersActivated[4] = true;
        }
        else if (index == 5) {
            GenerateNewParticleEmitter(Tree6);
            emittersActivated[5] = true;
        }
        else if (index == 6) {
            GenerateNewParticleEmitter(Tree7);
            emittersActivated[6] = true;
        }
        else if (index == 7) {
            GenerateNewParticleEmitter(Tree8);
            emittersActivated[7] = true;
        }
        else if (index == 8) {
            GenerateNewParticleEmitter(Tree9);
            emittersActivated[8] = true;
        }
        else if (index == 9) {
            GenerateNewParticleEmitter(Tree10);
            emittersActivated[9] = true;
        }
        else if (index == 10) {
            GenerateNewParticleEmitter(Tree11);
            emittersActivated[10] = true;
        }
        else if (index == 11) {
            GenerateNewParticleEmitter(Tree12);
            emittersActivated[11] = true;
        }
        else if (index == 12) {
            GenerateNewParticleEmitter(FutureCar);
            emittersActivated[12] = true;
        }
        else if (index == 13) {
            GenerateNewParticleEmitter(ClassicCar);
            emittersActivated[13] = true;
        }
        else {
            GenerateNewParticleEmitter(CopCar);
            emittersActivated[14] = true;
        }






        // var emission = ps.emission;
        // var main = ps.main;

        //main.startSize = 5.0f;
        //emission.enabled = true;
        //emission.enabled = true;


        //Debug.Log(emission.enabled);
        emitterCount++;


    }

    public bool containsValue (int index)
        {

        for(int i = 0; i<nonEmittingList.Count; i++)
        {
            if (nonEmittingList[i] == index)
            {
             //   Debug.Log("Found");
                return true;
            }

        }
        return false;


        }
    public void checkForNonEmitting()
    {
        for(int i =0;i< emittersActivated.Count; i++)
        {

            if (!emittersActivated[i])
            {
                if (!containsValue(i))
                {
                    nonEmittingList.Add(i);

                    Debug.Log("Non emitting  " + i);
                }
            }
        }


    }
    public void GetRandomEmitterToActivate()
    {

       
        int index = GetRandomIndex();

        //emittingList.Add(index);

       // Debug.Log(index + " is index");
     //   Debug.Log(emitterCount);
        if(!emittersActivated[index])
        {

            emittersActivated[index] = true;
            //if it is not activated call function again. 15 objects need 5 active at all times
            ActivateEmitter(index);


        }
        else
        {
          //  GetRandomEmitterToActivate();

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(emitterCount);

        checkForNonEmitting();
        newEmitter += Time.deltaTime;
      //  Debug.Log(emitterCount);
        if (emitterCount < 5)
        {
            //if (newEmitter > 5)
            {
                // int x = Random.Range(1, 15);
                //   int z = Random.Range(1, 15);

                if(nonEmittingList.Count > 0)
                GetRandomEmitterToActivate();
              //  Instantiate(groundEmitter, new Vector3(x, 0.0f, z), Quaternion.identity);

             //   newEmitter = 0;

             //   emitterCount++;
            }
        }

    }
}
