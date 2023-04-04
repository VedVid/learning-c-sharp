###### Verbatim strings.

Verbatim strings that do not use escape characters and preserves new lines are created by putting 'at' sign just before the string.
```csharp
"\x0041BCDE"  \\ Will print "ABCD"
@"\x0041BCDE"  \\ Will print "\x0041BCDE"
@"The quick
brown fox
jumps over the lazy dog"  \\ New lines in verbatim strings are preserved
```

