/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
class HelloWorld {

 public static ArrayList alphabets = new ArrayList() {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    
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
    var encryptedText = new ArrayList();
    for (int i = 0; i < character.Length; i++) {
        if(string.IsNullOrWhiteSpace(character[i].ToString())) {
            encryptedText.Add(" ");
        }else {
            // encryptedText.Add(alphabets[(alphabets.IndexOf(character[i].ToString().ToUpper()) + 3) % 26]);
            int index = alphabets.IndexOf(character[i].ToString().ToUpper());
            if (index >= 0) {
                encryptedText.Add(alphabets[(index + 3) % 26]);
            } else {
                encryptedText.Add(character[i]);
            }
        }
    }
    
    string getEncryptedString = string.Join("", encryptedText.ToArray());
    encryptText = getEncryptedString;
    Console.WriteLine("Encryted Text: {0}", getEncryptedString);
  }
  
  static void decrypt() {
    var decryptedText = new ArrayList();
    for (int i = 0; i < encryptText.Length; i++) {
        if(string.IsNullOrWhiteSpace(encryptText[i].ToString())) {
            decryptedText.Add(" ");
        }else {
            // decryptedText.Add(alphabets[(alphabets.IndexOf(encryptText[i].ToString().ToUpper()) - 3) % 26]);
            int index = alphabets.IndexOf(encryptText[i].ToString().ToUpper());

            int getNewIndex = (index - 3) % 26;
            if(getNewIndex < 0) {
                int newIndex = 26 - (getNewIndex * -1);
                decryptedText.Add(alphabets[newIndex]);
            } else {
                decryptedText.Add(alphabets[getNewIndex]);
            }
        }
    }
    
    string getDecryptedString = string.Join("", decryptedText.ToArray());
    Console.WriteLine("Decryted Text: {0}", getDecryptedString);
  }
}
