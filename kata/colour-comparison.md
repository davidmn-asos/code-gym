# Colour comparison kata

## Pre-Requistes

An understanding of hexadecimal values and how RGB colour values are displayed is a must for this one!

## Description

Regional elections have come to pigment province and it's up to you to count the votes!  Voters very specific beliefs are turned into a hexadecimal RBG colour value and then a voter's vote goes to the candidates whose colour is most similar. 

For example if you had a candidates

- Candidate A - 00 00 00
- Candidate B - FF FF FF

And voters

- Voter A - 00 11 00
- Voter B - FE 22 FF

Then voter A will vote for candidate A and voter B will vote for Candidate B.

## Hints


<details>
<summary>If you'd like to know how to turn hexadecimal into integers take a look below!</summary>

A call to `Convert.ToInt32("FF", 16);` will convert a hex string to an integer.

</details>

---

## Exercise 1

Currently the pigment province uses a first past the post system, work out which candidates wins given the following candidates and voters.  In the case of a tie the vote is chosen randomly between the most applicable candidates.

Candidates

- c6a944
- 7b8e7f
- d98a15
- 0c8ee9

Voters

- 48ef58
- 6c564e
- c5b325
- 9d6206
- 402d1f
- 35e122
- caf674
- 714d99
- 6fa84a
- 7e96cb

## Exercise 2  

What if pigment province used a different voting system? Would that change the result? Try implementing the borda count method from the positional methods given on this page https://votevote.page/

## Exercise 3

A choice of 3 for you here, pick which ever one you feel like

### Option 1 - Another voting system

Pick another voting system from the page above, go for run off voting if you want to work more on the vote calculation or budgetary if you want to implement an algorithm to decide on point allocation.

### Option 2 - Generate candidates and voters

Generate your own set of candidates and voters