using System;
using System.Collections.Generic;
using System.Threading;

class cypher {
    
    public static string word;
    public static string key;
    
    private static int Mod(int a, int b) {
	    return (a % b + b) % b;
    }

    private static string Cipher(string input, string key, bool encipher) {
    	for (int i = 0; i < key.Length; ++i)
    		if (!char.IsLetter(key[i]))
    			return null;
    
    	string output = string.Empty;
    	int nonAlphaCharCount = 0;
    
    	for (int i = 0; i < input.Length; ++i) {
    		if (char.IsLetter(input[i])) 	{
    			bool cIsUpper = char.IsUpper(input[i]);
    			char offset = cIsUpper ? 'A' : 'a';
    			int keyIndex = (i - nonAlphaCharCount) % key.Length;
    			int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
    			k = encipher ? k : -k;
    			char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
    			output += ch;
    		} else {
    			output += input[i];
    			++nonAlphaCharCount;
    		}
    	}
    
    	return output;
    }

    public static string Encipher(string input, string key) {
	    return Cipher(input, key, true);
    }

    public static string Decipher(string input, string key) {
	    return Cipher(input, key, false);
    }
    
    public static string showresult(string result) {
        Console.Clear();
        Console.WriteLine("[*]===========================[ RESULT ]===========================[*]");
        Console.WriteLine($"                                 {result}");
        Console.WriteLine("[*]===========================[ RESULT ]===========================[*]");
        Thread.Sleep(3000);
        Main();
        return result;
    }
    
    public static void encryptor() {
        Console.Clear();
        Console.WriteLine("[*]===========================[ ENCRYPT ]===========================[*]");
        Console.WriteLine("                         ENTER WORD: ");
        Console.WriteLine("[*]===========================[ ENCRYPT ]===========================[*]");
        word = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("[*]===========================[ ENCRYPT ]===========================[*]");
        Console.WriteLine("                         ENTER KEY: ");
        Console.WriteLine("[*]===========================[ ENCRYPT ]===========================[*]");
        key = Console.ReadLine();
        
        string cipherText = Encipher(word, key);
        showresult(cipherText);
    }
    
    public static void dencryptor() {
        Console.Clear();
        Console.WriteLine("[*]===========================[ DENCRYPT ]===========================[*]");
        Console.WriteLine("                         ENTER WORD: ");
        Console.WriteLine("[*]===========================[ DENCRYPT ]===========================[*]");
        word = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("[*]===========================[ DENCRYPT ]===========================[*]");
        Console.WriteLine("                         ENTER KEY: ");
        Console.WriteLine("[*]===========================[ DENCRYPT ]===========================[*]");
        key = Console.ReadLine();
        
        string cipherText = Decipher(word, key);
        // Console.WriteLine(cipherText);
        showresult(cipherText);
    }
    
    public static void Menu() {
        Console.Clear();
        Console.WriteLine("[*]===========================[ MENU ]===========================[*]");
        Console.WriteLine("                         1. Encrypt a Text");
        Console.WriteLine("                         2. Decrypt a Text");
        Console.WriteLine("                         3. Exit");
        Console.WriteLine("[*]===========================[ MENU ]===========================[*]");
        string choosen = Console.ReadLine();
        if(choosen.ToString() == "1") {
            encryptor();
        } else if (choosen.ToString() == "2") {
            dencryptor();
        } else if (choosen.ToString() == "3") {
            Environment.Exit(0);
        } else {
            Main();
        }
    }
    
    static void Main() {
        Menu();
    }
}
