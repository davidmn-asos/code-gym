# Shunting Yard

WARNING this one is hard

## Inglenook

Based on the "popular" idea of an Inglenook Shunting Puzzle in the Model Railway world.

https://skippy.org.uk/wp-content/uploads/2018/07/Inglenook.png

The puzzle consists of:
- a main line track that can hold 3 carriages in the left section and 5 in the right
- two sidings each can hold 3 carriages
- one locomotive, which is small enough to fit in each section of track along with the stated carriages
- 8 carriages, each given a letter, in an arbitary arrangement on the mainline & sidings 

## Input

The input to the puzzle looks like:

```
start:
    main: a,b,c,d,e
    siding0: f,g
    siding1: h
target:
    main: a,c,e,g,b
```

The start block describes which carriages are on each segment of track. For example on the mainline there are carriages a through e. In siding zero you can find carriages f and g. In siding one you can find carriage h.

Target describes which carriages and what order they should be arranged on the main line (the right section of track).

## Rules

The locomotive always starts in the left section of the main line.

Your locomotive can move between the mainline and sidings via the points. You may ignore the mechnaism of the points.

The finished state always requires no carriages in the left section of the mainline (you dont tend to put locomotives in the middle of trains).

Your locomotive can pull an arbitrary number of carraiges.

Carriages maybe be coupled and uncoupled when stationary and may not be left sat on points. 

Moves are defined by the movement of the locomotive e.g.:
    - Moving the locomotive from the mainline left to siding one & coupling the locomotive to h
    - Moving the locomotive from siding one to siding zero and coupling locomotive h to f and g
    - Moving the locomotive from siding zero to siding one

## Task

Given the following inputs, describe a sequence of moves that results in the target state. Bonus question, is your solution optimal (i.e. the solution with the least moves).

```
start:
    main: a,b,c,d,e
    siding0: f,g
    siding1: h
target:
    main: h,b,c,d,e
```

```
start:
    main: a,b,c,d,e
    siding0: f,g
    siding1: h
target:
    main: f,g,c,d,e
```

```
start:
    main: a,b,c,d,e
    siding0: f,g
    siding1: h
target:
    main: e,d,c,b,a
```

```
start:
    main: a,b,c,d,e
    siding0: f,g
    siding1: h
target:
    main: a,f,g,h,e
```

### Optional

Render diagrams of your moves e.g.

```
@__ abcde
    \fg_
     \h__

___ abcde
    \fg_
     \@h_

___ abcde
    \@hfg
     \___

___ abcde
    \___
     \@hfg
```

## Extension One

Can you handle target states on the sidings, with the extension to the input:

```
start:
    main: a,b,c,d,e
    siding0: f,g
    siding1: h
target:
    main: a,c,e,g,b
    siding0: d,f,h
    siding1: 
```

## Extension Two

The train driver is very lazy & so far your solutions have had them running all over the yard switching points manually. Consider the positions of the points and describe in your output when the points change. Can you find the optimal solution for the minimum number of point changes? Is that the same solution for the leave number of moves?

Assume the starting state of the points is to allow mainline traffic & the switch between siding zero and one to be set to siding zero.

## Extension Three

How easy is it to increase the capacity of each section of track? What about changing the number of sidings?


## Reading

https://www.sciencedirect.com/science/article/pii/S2192437621000145

With machine learning:
https://vlamen.github.io/mscfinished/peer/