using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;
using TMPro;

public class EnemyFactory : MonoBehaviour
{
    public static EnemyFactory instance;

    public GameObject copPrefab;
    private float copFrequency = 5;
    private float copTimer = 0;

    public GameObject catPrefab;
    private float catFrequency = 30;
    private float catTimer = 0;

    public GameObject platforms;

    List<Enemy> enemies;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        copTimer += Time.deltaTime;
        if (copTimer > copFrequency)
        {
            Debug.Log("COP");
            copTimer = 0;
            float randPos = UnityEngine.Random.Range(-20f, +20f);
            GameObject enemy = Instantiate(copPrefab, new Vector3(randPos, 7.0f, 0.0f), Quaternion.identity);
            bool direction = UnityEngine.Random.value > 0.5f;
            if (direction)
            {
                enemy.transform.Rotate(Vector3.up, 90.0f);
            }
            else
            {
                enemy.transform.Rotate(Vector3.up, -90.0f);
            }
        }

        catTimer += Time.deltaTime;
        if (catTimer > catFrequency)
        {
            catTimer = 0;
            int randObject = UnityEngine.Random.Range(0, platforms.transform.childCount - 1);
            float randPos = UnityEngine.Random.Range(-2, +2f);
            GameObject enemy = Instantiate(catPrefab, new Vector3(randPos, 1.0f, 0.0f), Quaternion.identity, platforms.transform.GetChild(randObject));
        }
    }

    public void SetCatSpawnFrequency(float freq)
    {
        catFrequency = freq;
    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    var enemyTypes = Assembly.GetAssembly(typeof(Enemy)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Enemy)));
    //
    //    enemies = new List<Enemy>();
    //
    //    foreach(var type in enemyTypes)
    //    {
    //        var tempEffect = Activator.CreateInstance(type) as Enemy;
    //        enemies.Add(tempEffect);
    //    }
    //
    //    ButtonPanel();
    //}
    //
    //public Enemy GetEnemy(string enemyType)
    //{
    //
    //    foreach(Enemy enemy in enemies)
    //    {
    //        // Debug.Log(enemy.Name);
    //        if(enemy.Name == enemyType)
    //        {
    //            Debug.Log("enemy found");
    //            var target = Activator.CreateInstance(enemy.GetType()) as Enemy;
    //
    //            return target;
    //        }
    //    }
    //
    //    return null;
    //}
    //
    //public void ButtonPanel()
    //{
    //    foreach(Enemy enemy in enemies)
    //    {
    //        var button = Instantiate(buttonPrefab);
    //        button.transform.SetParent(buttonPanel.transform);
    //        button.gameObject.name = enemy.Name + " Button";
    //        button.GetComponentInChildren<TextMeshProUGUI>().text = enemy.Name;
    //    }
    //}
}
