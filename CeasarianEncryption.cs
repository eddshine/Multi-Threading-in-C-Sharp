/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Threading;
using System.Collections.Generic;
class HelloWorld {

  public static Dictionary<string, string> cypher = new Dictionary<string, string>(){
	{"A", "B"},
	{"B", "C"},
	{"C", "D"},
    {"D", "E"},
    {"E", "F"},
    {"F", "G"},
    {"G", "H"},
    {"H", "I"},
    {"I", "J"},
    {"J", "K"},
    {"K", "L"},
    {"L", "M"},
    {"M", "N"},
    {"N", "O"},
    {"O", "P"},
    {"P", "Q"},
    {"Q", "R"},
    {"R", "S"},
    {"S", "T"},
    {"T", "U"},
    {"U", "V"},
    {"V", "W"},
    {"W", "X"},
    {"X", "Y"},
    {"Y", "Z"},
    {"Z", "A"},
    {"a", "b"},
	{"b", "c"},
	{"c", "d"},
    {"d", "e"},
    {"e", "f"},
    {"f", "g"},
    {"g", "h"},
    {"h", "i"},
    {"i", "j"},
    {"j", "k"},
    {"k", "l"},
    {"l", "m"},
    {"m", "n"},
    {"n", "o"},
    {"o", "p"},
    {"p", "q"},
    {"q", "r"},
    {"r", "s"},
    {"s", "t"},
    {"t", "u"},
    {"u", "v"},
    {"v", "w"},
    {"w", "x"},
    {"x", "y"},
    {"y", "z"},
    {"z", "a"}
  };
    
    
  public static string encryptText;
  static void Main() {
    Console.WriteLine("Input a string: ");
    string toCypher = Console.ReadLine();
    
    Thread encryptString = new Thread(() => encrypt(toCypher));
    Thread decryptString = new Thread(() => decrypt());
    encryptString.Start();
    encryptString.Join();
    decryptString.Start();
  }
  
  static void encrypt(string character) {
    char[] ch = new char[character.Length];
    for (int i = 0; i < character.Length; i++) { 
            ch[i] = char.Parse(cypher[Char.ToString(character[i])]);
            //Console.WriteLine(cypher[Char.ToString(character[i])]);
    }
    
    string encryptedText = new string(ch);
    encryptText = encryptedText;
    Console.WriteLine("Encryted Text: {0}", encryptedText);
  }
  
  static void decrypt() {
     char[] ch = new char[encryptText.Length];
    for (int i = 0; i < encryptText.Length; i++) { 
            ch[i] = char.Parse(cypher[Char.ToString(encryptText[i])]);
            //Console.WriteLine(cypher[Char.ToString(encryptText[i])]);
    }
    
    string decryptedText = new string(ch);
    Console.WriteLine("Decrypted Text: {0}", decryptedText);
  }
}
