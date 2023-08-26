using System;
using System.Threading;

class Program {
    public static int [] num = new int[10];
    
	static void Main() {
	    
		Thread t1 = new Thread(checkNumIndex1);
		Thread t2 = new Thread(checkNumIndex2);
        Thread t3 = new Thread(checkNumIndex3);
        Thread t4 = new Thread(checkNumIndex4);
        Thread t5 = new Thread(checkNumIndex5);
        Thread t6 = new Thread(checkNumIndex6);
        Thread t7 = new Thread(checkNumIndex7);
        Thread t8 = new Thread(checkNumIndex8);
        Thread t9 = new Thread(checkNumIndex9);
	    Thread t10 = new Thread(checkNumIndex10);
	    
	    Console.WriteLine("Enter Numbers: ");
		for (int i = 0; i < num.Length; i++) {
			num[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("\n");
		
	    //RUN ALL THREAD
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        t5.Start();
        t6.Start();
        t7.Start();
        t8.Start();
        t9.Start();
        t10.Start();
		//t.Join();

	}
	
	static void checkNumIndex1() {
        if(num[0] % 2 == 0) {
            Console.WriteLine($"{num[0]} is Even");
        } else {
            Console.WriteLine($"{num[0]} is Odd");
        }
    }
    
    static void checkNumIndex2() {
        if(num[1] % 2 == 0) {
            Console.WriteLine($"{num[1]} is Even");
        } else {
            Console.WriteLine($"{num[1]} is Odd");
        }
    }
    
    static void checkNumIndex3() {
        if(num[2] % 2 == 0) {
            Console.WriteLine($"{num[2]} is Even");
        } else {
            Console.WriteLine($"{num[2]} is Odd");
        }
    }
    
    static void checkNumIndex4() {
        if(num[3] % 2 == 0) {
            Console.WriteLine($"{num[3]} is Even");
        } else {
            Console.WriteLine($"{num[3]} is Odd");
        }
    }
    
    static void checkNumIndex5() {
        if(num[4] % 2 == 0) {
            Console.WriteLine($"{num[4]} is Even");
        } else {
            Console.WriteLine($"{num[4]} is Odd");
        }
    }
    
    static void checkNumIndex6() {
        if(num[5] % 2 == 0) {
            Console.WriteLine($"{num[5]} is Even");
        } else {
            Console.WriteLine($"{num[5]} is Odd");
        }
    }
    
    static void checkNumIndex7() {
        if(num[6] % 2 == 0) {
            Console.WriteLine($"{num[6]} is Even");
        } else {
            Console.WriteLine($"{num[6]} is Odd");
        }
    }
    
    static void checkNumIndex8() {
        if(num[7] % 2 == 0) {
            Console.WriteLine($"{num[7]} is Even");
        } else {
            Console.WriteLine($"{num[7]} is Odd");
        }
    }
    
    static void checkNumIndex9() {
        if(num[8] % 2 == 0) {
            Console.WriteLine($"{num[8]} is Even");
        } else {
            Console.WriteLine($"{num[8]} is Odd");
        }
    }
    
    static void checkNumIndex10() {
        if(num[9] % 2 == 0) {
            Console.WriteLine($"{num[9]} is Even");
        } else {
            Console.WriteLine($"{num[9]} is Odd");
        }
    }
    


}
