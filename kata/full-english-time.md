# Full English Time

```
public string WhatIsTheTime(int secondsSinceMidnight)
{
  // Your code here!
  throw new Exception();
}
```

## Input
You are given the number of seconds elapsed since midnight (12:00 am, 00:00, one minute passed 23:59, however you want to represent that). 

## Output
Return a string that contains the text of the time in English, like this:

### Examples

| int   | string                                      |
| ----- | ------------------------------------------- |
| 0     | Midnight                                    |
| 60    | One minute past midnight                    | 
| 53700 | Five minutes to three                       |
| 53708 | Four minutes and fifty two seconds to three | 


## Extension 0
Can you do it without using a library to help you with the time parsing? (i.e. System.DateTime and its friends are banned)

## Extension 1
Is “Five minutes to three” in the morning or afternoon? Take the following as the definitions of the day:

| Time Range          | Name      |
| ------------------- | --------- |
| 00:00:00 → 06:00:00 | Night     |
| 06:00:00 → 12:00:00 | Morning   | 
| 12:00:00 → 18:00:00 | Afternoon |
| 18:00:00 → 00:00:00 | Night     | 

What should happen at 00:00:00 and 12:00:00?

## Extension 2
“Five minutes to three” feels clunky. Can the output for whole minutes be a more casual “Five to three”

## Extension 3
“Four minutes and fifty two seconds to three” feels clunky too. Can you round your output to the nearest 5min?