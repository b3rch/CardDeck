# CardDeck

Deck of cards implementation.

###Solution Description

The solution has two projects CardDeck and TestDeck.

CardDeck is a class library that contains de implementation of the card deck.

TestDeck is a console application to test the class library.

###CardDeck is a class library interface

#####Card[] Shuffle(int steps); 
Shuffle the cards, steps are the times that the algorithm is applied

#####Card Deal();
Get a card from the deck.

#####string ToString();
string representation of the deck.

###Shuffle Implementation

The CardDeck use one algorithm to shuffle the cards and is possible to use your own implementation too. 

I have implememted two algorithms to shuffle the cards Swap and ToFirst.

Swap: swap two random cards 

ToFirst: swap the first card and other random card(the first one is not consider in the random card selection)

###Use your own shuffle implementation

Use the interface IShuffleMethod to implement your own algorithm.

