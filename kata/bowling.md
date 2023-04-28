# Bowling Dojo

## Description

Write a program to calculate the score (integer) of Ten-Pin Bowling based on a input (string)

## Scoring rules

- Each game includes ten frames for the bowler

- In each frame, the bowler has up to two tries to knock down all ten pins

- If the first ball in a frame knocks down all ten pins, this is called a `strike`. The frame is over
    - The score for the frame is ten plus the total of the pins knocked down in the next two balls

- If the second ball in a frame knocks down all ten pins, this is called a `spare`. The frame is over.
    - The score for the frame is `ten plus the number of pins knocked down in the next ball`

- If, after both balls, there is still at least one of the ten pins standing the score for that frame is simply the `total number of pins knocked down in those two balls`

- If you get a spare in the last frame you get one bonus ball

- If you get a strike in the last frame you get two bonus balls

- Bonus throws are taken as part of the same turn. The bonus balls are only used to calculate the score of the final frame.

- The game score is the total of all frame scores

## Input Syntax

`X` indicates a strike

`/` indicates a spare

`-` indicates a miss

`|` indicates a frame boundary

Characters after the `||` indicate bonus balls

## Examples

`X|X|X|X|X|X|X|X|X|X||XX` -> Total score = 10 frames x 30 = 300

`9-|9-|9-|9-|9-|9-|9-|9-|9-|9-||` -> Total score = 10 frames x 9 = 90

`5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5` -> Total score = 10 frames x 15 = 150

`X|7/|9-|X|-8|8/|-6|X|X|X||81` -> Total score = 167

The final example is broken down below:

```
X        |7/     |9-   |X       |-8   |8/     |-6   |X         |X        |X||81
10+7+3 + 7+3+9 + 9+0 + 10+0+8 + 0+8 + 8+2+0 + 0+6 + 10+10+10 + 10+10+8 + 10+8+1
20       19      9     18       8     10      6     30         28        19
```