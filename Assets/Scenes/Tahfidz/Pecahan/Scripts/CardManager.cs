﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour
{

    //All Cards Objects in the Scene
    [SerializeField]
    List<Card> Cards; //16

    //the Final all cards that is going to be added
    List<Card> CardsWithSprite; //16

    //FaceDown Card Sprite
    [SerializeField]
    Sprite FaceDownCard;

    [Space]

    [SerializeField]
    GameObject WinText;
    public AudioSource moo;


    int CardsCount = 0;
    //the cards that have been choosen
    Card FirstCard;
    Card SecondCard;

    //number of matches to determine when the game is over
    int Matches = 0;
    bool MatchFound = true;

    // Use this for initialization
    void Awake()
    {
        CardsWithSprite = new List<Card>();
        AddCards();
        FirstCard = null;
        SecondCard = null;
        Matches = 0;
    }

 
    //Add all the cards to the cards in the Project
    void AddCards()
    {
        int index = 0;
        foreach (Card C in Cards)
        {
            C.cardArtWork = CardsWithSprite[index].cardArtWork;
            C.index = CardsWithSprite[index].index;
            index++;
        }
    }
    bool noMatch = false;

    //called when cards are selected
    public void CardSelected(Card C)
    {
        // if no match return te cards to null
        if (noMatch)
        {
            noMatch = false;
       
            FirstCard = null;
            SecondCard = null;
        }

        //Fill the First Card
        if (FirstCard == null)
        {
            FirstCard = C;
            FirstCard.OpenCard();
            return;
        }

        //Fill the Second Card
        if (SecondCard == null)
        {
            SecondCard = C;
            SecondCard.OpenCard();

            //Matching
            if (FirstCard.index == SecondCard.index)
            {
                moo.Play();
                FirstCard.Chosen();
                SecondCard.Chosen();

                FirstCard.NotChosen(FaceDownCard);
                SecondCard.NotChosen(FaceDownCard);

                FirstCard = null;
                SecondCard = null;

                Matches++;
                if (Matches == 7)
                    GameOver();
            }
            else
            {
                //if no Matching
                noMatch = true;
                FirstCard.NoMatch();
                SecondCard.NoMatch();
            }
            return;
        }
    }

    //call when winning the game
    void GameOver()
    {
        WinText.SetActive(true);
        StartCoroutine(GameAgain());
    }

    //Reset the Game after 3 sec of winning
    IEnumerator GameAgain()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


  

}
