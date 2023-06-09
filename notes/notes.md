###### Verbatim strings

Verbatim strings that do not use escape characters and preserves new lines are created by putting 'at' sign just before the string.
```csharp
"\x0041BCDE"  \\ Will print "ABCD"
@"\x0041BCDE"  \\ Will print "\x0041BCDE"
@"The quick
brown fox
jumps over the lazy dog"  \\ New lines in verbatim strings are preserved
```


###### float and double literals

By default, every number with decimal fraction is of `double` type, unless we add `f` after the number. So: `3.14` as double, `3.14f` is float.

###### Casting.

```csharp
double d = 1.0;
float f = (float)d;
int i;
i = (int)2.5;
```


###### Loops

There are four looping constructs in C#.

```csharp
do
	// do something here
while (condition);

while (condition)
    // do something here

for (setup; finish; update)
    // do something here

foreach (element in iterable)
    // do something here
```


###### Every statement returns a value

E.g. `i = (j=0);` sets both `i` and `j` variables to 0.


###### Printing tips and tricks

```csharp
// Using placeholders:
int i = 150;
double f = 1234.56789;
Console.WriteLine("i: {0} f: {1}", i, f);
Console.WriteLine("i: {1} f: {0}", f, i);
// It works similarly to Python's .format used
// before f-strings were a thing.

// Adjusting real number precision:
Console.WriteLine("i: {0:0} f: {1:0.00}", i, f);
/* First number, for example '1' after 'f', has the same role
   as in the first example, so: positioning.
   '0.00' specifies precision, where '0' stands for
   one or more digits.
   Result:
   i: 150 f: 1234.57
*/

// Specifying the number of printed digits:
Console.WriteLine("i: {0:0000} f: {1:00000.00}", i, f);
// Result:
// i: 0150 f: 01234.57

// Really fancy formatting:
Console.WriteLine("i: {0:#,##0} f: {1:##,##0.00}", i, f);
// '#' in the format string means "put a digit here if you have one".
// Looks like notation I know from formatting spreadsheets.
// Result:
// i: 150 f: 1,234.57

// Printing in columns:
Console.WriteLine("i: {0,10:0} f: {1,15:0.00}", i, f);
Console.WriteLine("i: {0,10:0} f: {1,15:0.00}", 0, 0);
/* Result:
   i:        150 f:         1234.57
   i:          0 f:            0.00
   Integer value in printed in a column 10 characters wide, and
   the double is printed in a 15 character wide column.
   Output is right-justified. To make it left-justified,
   width of columns should be negative, like that:*/
Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", i, f);
Console.WriteLine("i: {0,-10:0} f: {1,-15:0.00}", 0, 0);
// Result:
// i: 150       f: 1234.57
// i: 0         f: 0.00
```


###### Values and references

Looks like C# by default passes variables by values. That is considerable change in comparison to Python that passes everything as reference, but should not be too different to Go that has values and pointers, should it?

To pass argument by reference instead by value, simply add `ref` before type: `foo(ref int bar);`.


###### in and out parameters

C# supports `in` and `out` parameters. `in` parameters can not be changed by method, and `out` parameters must by changed by method. A dabbled in Ada and D that have similar concepts – not sure about implementation details though. According to MS docs, `in`, `out`, and `ref` may cause problems with method overloading.


###### Contracts

C# allows using design-by-contract, by supporting preconditions (`Contract.Requires`), postconditions (`Contract.Ensures`) and invariants (`Contract.Invariant`). Invariant methods must be marked as such by `[ContractInvariantMethod]` statement just above method declaration.
More info is needed to use contracts properly.


###### Arrays

```csharp
// Explicitely typed arrays.
string[] monthNames = new string[]
{
    null,  // null element for non-existent month 0
	"January", "February", ...
};

// Implicitely typed arrays.
string[] weekDays = 
{
    "Monday", "Tuesday", ...
};

// Arrays that are not initialized on declaration
// must be explicitely typed.
string[] calendarTypes = new string[];

// Multidimensional arrays are declared and accessed
// differently than I'm used to.
// Declaring 2D array:
int[,] squareWeights = 
{
    {1, 0, 1},
	{0, 2, 0},
	{1, 0, 1}
};
// Accessing: arr[col, row]
int w = squareWeights[1, 1];  // 2
// 3D array:
int[,,] board = new int[3, 3, 3];
board[1, 1, 1] = 1;

// Getting array length also is different:
int l1 = squareWeights(0);
int l2 = squareWeights(1);
// instead of
// l1 = squareWeights[0]
// l2 = squareWeights[0][1]
```


###### Exceptions

Exceptions seem quite similar to their Python equivalent, it's just `try-catch` instead of `try-except`. However, there are two differences.
1. In Python you can use `try-except-else-finally`. After basic googling I did not find reference for such construct, it's either `try-catch-finally` or `try-catch-else`. In Python, `else` block is executed only when exception has not been raised, and `finally` block is executed regardless of exceptions. As far as I can tell, it's the same for C#.
2. In the C# Yellow Book, in chapter 3.4.7 Exception Etiquette, we can read that "Exceptions are best reserved for situations when your program really cannot go any further." That's a different mindset, in Python you quite often use `try-except` for flow control.


###### Switch case

There are two notable facts about switches in C#. First, it implicitely fallsthrough so you may need to insert `break;` after handling each case. Secondly, it allows chaining cases like that:
```csharp
switch (command)
{
    case val1:
	case val2:
	    // handles cases for both val1 and val2.
}
```


###### Setters and getters

In Python, it is quite common change the class member directly (at least for the simple operations, like `player.active = False` when the turn ends). From the Yellow book I took an impression that changing members directly is kind of anti-pattern in C#. Well, it's beginners book so maybe it tries to teach what's _usually best_, but still...


###### static members

Rob Miles in his book writes that "The static keyword lets us create members which are not held in an instance, but in the class itself." So it's like class members in Python, declared before `__init__`?

Is
```csharp
class Foo
{
    static public int bar = 0;
}
```
equivalent to
```python
class Foo:
    bar = 0
```
?
What's about methods? Are all Python's methods like C# public static methods?
Also, in C# you actually call class (not instance!) member to change a static member:
```csharp
class Foo
{
    static int bar = 0;
}

Foo test = new Foo();
Foo.bar = 10;
```
Still, a better practice is to make static members private, and provide method to update the member.
```csharp
class Foo
{
    static int bar = 0;
	
	public void SetBar(int value)
	{
	    bar = value;
	}
}

Foo test = new Foo();
Foo.SetBar(10);
```

