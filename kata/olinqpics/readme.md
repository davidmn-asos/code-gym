# Welcome to the OLINQpic games!

This is a quick exercise to get you to explore many of LINQs operations and show off some of what it can do.  The code is set out so that you should be able to just add new functions and call them fairly easily.

## Pre-requisites : Lambda expressions
<details>
In case you haven't worked with lamdba expression before, they're just a way of turning this

```CSharp
public string SelectName(Person person)
{
    return person.Name;
}
```
into this
```CSharp
person => person.Name
```

The part on the left is simply the name given to the variable and the compiler will work out what the right return type is based on the code so you often don't need to declare it explicitly.

### What's a Func?

In the intellisense you will sometimes see parameter types like this which can be quite confusing

```CSharp
Func<Person, TResult> selector
```

Put simply this is a way of saying a function that takes a person type as an argument and returns any type (Note, this is an over simplification but probably good enough for a rule of thumb for simple cases). The important thing to know is that he last type is *always* the type that the function returns and the types to the left are the parameters.  If a function passes in multiple parameters you can declare your function like this

```CSharp
(a,b) => a
```

If you get stuck then try delcaring your function as a variable with a type which will help you validate your understanding and potentially produce more useful compiler errors.  In the case of the example above it might look like this.

```CSharp
Func<int,int,int> aggregateFunction = (a,b) => a;
```

The other variant you might see in areas other than LINQ is the `Action<T>`.  This is like a `Func<T>` but actions are equivalent to a method that returns void (i.e. nothing) so you don't need to worry about returning anything. 
</details>

## Exercises

Given the starting code in the solution, output the following to the console

1. Return the average age of the group (Hint: Use the average function)
2. Return a list of names (Hint: Use the select function)
3. Return a list the names of anyone under the age of 25 (Hint: Use the where function)
4. Return output from exercise 3 as a comma separated string (Hint: Use the aggregate function)
5. Return a boolean of whether the list contains anyone above a given age (Hint: Use the Any function)
6. Return the oldest age in the group (Hint: Use the Max function)
7. Return the name of the oldest person in the group (Hint: Use the MaxBy function)
8. The average age of each gender in the group (Hint: Use the GroupBy function)
9. The most popular colour of the group (Hint: Use the SelectMany function)
10. A complete list of favourite colours with no duplicates (Hint: Use the distinct function)

## Extension exercise 
Re-write a few of the above functions without using LINQ syntax, is this code easier to read? More verbose? 

## Discussion
Does LINQ help by compressing the code or does it hide a lot of complexity, does it depend on the situation or the functions being used?