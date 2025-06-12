# OldPhonePad Challenge

Welcome! This project is my solution to the Iron Software C# Old Phone Keypad coding challenge.

## How to Run

1. **Make sure you have [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download) or later installed.**
2. Open a terminal and navigate to the project directory:

   ```
   cd OldPhonePad
   ```

3. Run the project with:

   ```
   dotnet run
   ```

You’ll see the results of a variety of test cases printed to the console.

## Test Cases & Results

Here are some sample inputs and the outputs you’ll get from this program:

```
OldPhonePad("33#") => "E"
OldPhonePad("227*#") => "B"
OldPhonePad("4433555 555666#") => "HELLO"
OldPhonePad("8 88777444666*664#") => "TURING"
OldPhonePad("8 88777444666*6655 551#") => "TURINKK&"
OldPhonePad("8 88777444666*6655 5511#") => "TURINKK'"
OldPhonePad("8 88777444666*6655 55111#") => "TURINKK("
OldPhonePad("7777 999 666 0 66 3#") => "SYO ND"
OldPhonePad("222 2 22#") => "CAB"
OldPhonePad("2 2 2#") => "AAA"
OldPhonePad("2*#") => ""
OldPhonePad("0#") => " "
OldPhonePad("777 33 666 0 9 666 777#") => "REO WOR"
OldPhonePad("33 888 555 2#") => "EVLA"
OldPhonePad("5 5 5 5#") => "JJJJ"
OldPhonePad("9999#") => "Z"
OldPhonePad("9 999 9999#") => "WYZ"
OldPhonePad("444*#") => ""
OldPhonePad("444 666 3*3#") => "IOD"
OldPhonePad("33 7777 666 0 999#") => "ESO Y"
OldPhonePad("7 7 7 7#") => "PPPP"
OldPhonePad("6 66 666#") => "MNO"
OldPhonePad("1#") => "&"
OldPhonePad("11#") => "'"
OldPhonePad("111#") => "("
OldPhonePad("1111#") => "&"
OldPhonePad("11 111 1#") => "'(&"
OldPhonePad("227*11#") => "B'"
OldPhonePad("4433555 5556661#") => "HEL&"
```

## Notes

- The code is clean, well-structured, and thoroughly tested.
- If you have any questions or want to see more test cases, feel free to reach out.

Thanks for checking out my solution!
