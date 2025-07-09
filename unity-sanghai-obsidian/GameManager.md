### Game states

Use [[GameStateBase]]
###### Start game
* Randomize play order
* Choose starting player
###### Start round
* Shuffle deck
* Deal cards
* Setup required plays
###### Next turn
* Set players active and inactive in order
###### Draw
* Set deck and discard pile active
* Handle hep
###### Discard
* Set discard zone active
* Set play button active
* Check if rounds end
###### End round
* Display player scores
* Play animations
###### End game
* Display winner
* Start new game
* Disband lobby
* Leave

### Active player
* Who is doing turn
* Turn timer

### Turn swap
* Sets active player inactive
* Sets next player in order active

### Players
* Map of turn order and scores

### Update game state