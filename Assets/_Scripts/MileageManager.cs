using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MileageManager : MonoBehaviour
{
    public static MileageManager instance;

    private float mileage = 0.0f;
    private bool running = true;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            mileage += Time.deltaTime;
            //Debug.Log(mileage);
            if (mileage > 2000)
                EnemyFactory.instance.SetCatSpawnFrequency(10);
            else if (mileage > 1000)
                EnemyFactory.instance.SetCatSpawnFrequency(20);
            else if (mileage < 1)
                EnemyFactory.instance.SetCatSpawnFrequency(30);
        }
    }

    public void Pause()
    {
        running = false;
    }

    public void Resume()
    {
        running = true;
    }

    public void Clear()
    {
        mileage = 0;
    }
}
