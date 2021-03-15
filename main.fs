module Assignment

// Problem 1
let rec tribn n =
    if n <=0 then 0
    elif n = 1 then 1
    elif n = 2 then 1 
    else tribn (n-1) + tribn (n-2) + tribn (n-3) 

// Problem 2
let tribn2 n =
    // write your code here
    0

// Problem 3
let rec last lst =
    if List.tail lst > 0
    then List.tail lst::List.head lst
    else List.head lst

// Problem 4
let fourth (lst:int list) =
    // write your code here
    0

// Problem 5
let everyfourth (lst:int list) =
    // write your code here
    []

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    []

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
    []
