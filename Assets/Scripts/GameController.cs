using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject EnemyFolder;
    public GameObject GameOverPanel;
    public GameObject[] LifeIcon;
    public GameObject ScoreObject;

    private int Life;
    private int Score;
    private Text ScoreText;
    
    void Start()
    {
        ScoreText = ScoreObject.GetComponent<Text>();

        Time.timeScale = 1;
        Score = 0;
        Life = 2;

        ShowScore();
        StartCoroutine("RandomCreateEnemy");
    }
    
    private IEnumerator RandomCreateEnemy()
    {
        float duration = Random.Range(0.2f, 2f);
        yield return new WaitForSeconds(duration);
        CreateEnemy();
        StartCoroutine("RandomCreateEnemy");
    }

    void CreateEnemy()
    {
        float posX = Random.Range(-2f, 2f);
        GameObject newEnemy = Instantiate(Enemy, EnemyFolder.transform);
        newEnemy.transform.position += new Vector3(posX, 0, 0);
    }

    public void Damage()
    {
        Life--;
        LifeIcon[Life].SetActive(false);
        if(Life == 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
    }

    public void Retry()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }

    public void ScoreAdd(int add)
    {
        Score += add;
        ShowScore();
    }

    private void ShowScore()
    {
        ScoreText.text = Score.ToString();
    }
}
