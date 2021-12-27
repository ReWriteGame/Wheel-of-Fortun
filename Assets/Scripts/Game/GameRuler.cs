using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Arrow arrow2;
    [SerializeField] private ScoreCounter scoreCounter;
   
    public UnityEvent winEvent;
    public UnityEvent loseEvent;



    public void StartGame()
    {
      
     
    }

    public void StopGame()
    {

        if(arrow1.collidedObject.GetComponent<Cell>().Value == arrow2.collidedObject.GetComponent<Cell>().Value)
            winEvent?.Invoke();
        else loseEvent?.Invoke();

    }

    private IEnumerator StopMachineCor()
    {
        yield break;
    }
}
