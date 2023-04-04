###### Verbatim strings.

Verbatim strings that do not use escape characters and preserves new lines are created by putting 'at' sign just before the string.
```csharp
"\x0041BCDE"  \\ Will print "ABCD"
@"\x0041BCDE"  \\ Will print "\x0041BCDE"
@"The quick
brown fox
jumps over the lazy dog"  \\ New lines in verbatim strings are preserved
```

###### float and double literals.

By default, every number with decimal fraction is of `double` type, unless we add `f` after the number. So: `3.14` as double, `3.14f` is float.

###### Casting.

```csharp
double d = 1.0;
float f = (float)d;
int i;
i = (int)2.5;
```

###### Loops

There are three looping constructs in C#.

```csharp
do
	// do something here
while (condition);

while (condition)
    // do something here

for (setup; finish; update)
    // do something here
```

###### Every statement returns a value

E.g. `i = (j=0);` sets both `i` and `j` variables to 0.
