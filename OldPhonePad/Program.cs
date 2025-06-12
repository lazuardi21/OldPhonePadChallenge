
namespace OldPhonePadApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var testInputs = new[]
      {
              "33#",
              "227*#",
              "4433555 555666#",
              "8 88777444666*664#",
              "8 88777444666*6655 551#",
              "8 88777444666*6655 5511#",
              "8 88777444666*6655 55111#",
              "7777 999 666 0 66 3#",
              "222 2 22#",
              "2 2 2#",
              "2*#",
              "0#",
              "777 33 666 0 9 666 777#",
              "33 888 555 2#",
              "5 5 5 5#",
              "9999#",
              "9 999 9999#",
              "444*#",
              "444 666 3*3#",
              "33 7777 666 0 999#",
              "7 7 7 7#",
              "6 66 666#",
              "1#",
              "11#",
              "111#",
              "1111#",
              "11 111 1#",
              "227*11#",
              "4433555 5556661#"
          };

      foreach (var input in testInputs)
      {
        string result = IronSoftware.Challenge.OldPhoneKeypad.OldPhonePad(input);
        Console.WriteLine($"OldPhonePad(\"{input}\") => \"{result}\"");
      }
    }
  }
}
