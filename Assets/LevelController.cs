using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static int _nextLevelIndex = 1;
    private Enemy[] _enemies;
    private boss[] _boss;
    private string nextLevelName = " ";
    // Start is called before the first frame update
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
        _boss = FindObjectsOfType<boss>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if (enemy != null)
            return;
        }

            foreach(boss boss in _boss)
            {
                if (boss != null)
                return;
            }
        
       StartCoroutine(nextLevel());
    }

    public string getLevel()
    {
        return "level" + _nextLevelIndex;
    }

    IEnumerator nextLevel()
    {
        yield return new WaitForSeconds(1);
        _nextLevelIndex++;
        nextLevelName = "level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
