### Game states
###### Initial setup
* Randomize play order
* Choose starting player
###### Start next round
* Shuffle deck
* Deal cards
* Setup required plays
###### Turns
* Set players active and inactive in order
* Handle hep
* Stop when player has no cards in hand
###### Calc score
* Display player scores
* Play animations
###### End game
* Display winner
* Start new game
* Disband lobby
* Leave

### Turn states
###### Draw
* Set deck and discard pile active
###### Make plays
* Set play button active
* Check if round ends
###### Discard
* Set discard zone active
* Check if rounds end

### Active player
* Who is doing turn
* Turn timer

### Turn swap
* Sets active player inactive
* Sets next player in order active

### Players
* Map of turn order and scores