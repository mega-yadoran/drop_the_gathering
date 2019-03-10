using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FloorController : MonoBehaviour
{
    public int force;
    public GameObject GameControllerObj;
    public GameObject ScoreZone;
    
    private bool isMoving;
    private ScorezoneController scorezoneController;
    private GameController gameController;

    void Start()
    {
        isMoving = false;
        gameController = GameControllerObj.GetComponent<GameController>();
        scorezoneController = ScoreZone.GetComponent<ScorezoneController>();
    }
    
    void Update()
    {
        
    }

    public void Open()
    {
        if (!isMoving)
        {
            scorezoneController.SetIsFloorOpen(true);
            isMoving = true;
            transform.DORotate(
                new Vector3(90f, 0f, 0f),
                0.5f
            ).OnComplete(() =>
            {
                transform.DORotate(
                   new Vector3(0f, 0f, 0f),
                   1.0f
               ).OnComplete(() =>
               {
                   scorezoneController.SetIsFloorOpen(false);
                   int count = scorezoneController.GetAndResetCount();
                   int score = GetScore(count);
                   gameController.ScoreAdd(score);

                   isMoving = false;
               });
            });

        }
    }
    private int GetScore(int count)
    {
        switch (count)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 5;
            case 3:
                return 10;
            case 4:
                return 30;
            case 5:
                return 50;
            case 6:
                return 100;
            default:
                return 200;
        }
    }
}
