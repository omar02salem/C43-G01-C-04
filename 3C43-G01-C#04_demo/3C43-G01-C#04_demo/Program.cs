using System.ComponentModel;
using System.Text;
using System.Threading.Channels;

namespace _3C43_G01_C_04_demo
{
    internal class Program
    {
        #region FunctionsParams

       /* static int SumArray(params int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 0;
            if(Arr is not null )
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += Arr[i];
                }
            }
            return Sum;
        }*/

        #endregion
        #region passing by out
        /*public static void SumMul(int X ,int Y, out int Sum,out int Mul)
        {
            Sum = X + Y ;
            Mul = X * Y ;
            
        }*/
        #endregion
        #region passing by ref and value
        /*public static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }*/
        /*public static void Print(string Pattern,int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(Pattern);
            }
            Console.WriteLine();
        }
        public static void PrintPattern(int count, string Pattern = "#")
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(Pattern);
            }
            Console.WriteLine();
        }*/
        #endregion
        static void Main(string[] args)
        {
            #region String

            //string is a Class [Reference Type ] , Internally is an Array of Chars

            /*string Name;
            //Declare for Reference of type "String"
            //this reference 'name' id Refering to the default value of Reference Type =Null
            //CLR Will allocate 4 Bytes at STACK for the Reference 'Name'
            //CLR will allocate 0 Bytes at HEAP 

            Name = new string("omar"); //CLR will Allocate 8 Bytes at HEAP

            Name = "omar";
            Console.WriteLine(Name);
            Console.WriteLine($"hash code is {Name.GetHashCode()}");*/

            /* string Name01 = "Ahmed "; //has 2 references 
             string Name02 = "Omar";*/ // unreachable object
            /*Console.WriteLine(Name01);
            Console.WriteLine(Name02);
            Console.WriteLine(Name01.GetHashCode());
            Console.WriteLine(Name02.GetHashCode());*/

            /*Name02 = Name01;// Console.WriteLine("after Name02 = Name01");

            Name02 = "Yassmin";

            Console.WriteLine(Name01);
            Console.WriteLine(Name02);*/

            /*Console.WriteLine(Name01);
            Console.WriteLine(Name02);
            Console.WriteLine(Name01.GetHashCode());
            Console.WriteLine(Name02.GetHashCode());*/


            /*string Message = "Hello";
            Console.WriteLine($"Message : {Message}");
            Console.WriteLine(Message.GetHashCode());

            Message += "omar";//initiated new object
            Console.WriteLine("After changing the message");

            Console.WriteLine(Message.GetHashCode());*/

            #endregion

            #region StringBuilder

            //string builder is a Class [Reference Type] and is Mutable strung [internaly is a linked list of Chars]

            /*StringBuilder Message ;
            //Declare a Referece of type 'ReferencBuilder'
            //CLR will Allocate 4 Bytes at the STACK for the Reference 'Message'
            //CLR will Allocate 0 Bytes at the Heap

            Message = new StringBuilder("Hello");
            Console.WriteLine($"Message is {Message}");
            Console.WriteLine($"Message Hashcode is {Message.GetHashCode()}");

            Message.Append(" Omar");
            Message.AppendLine(" salem  ");
            Message.AppendLine(" you age is 22 ");
            Message.Remove(0, 5);
            Message.Insert(0,"hi");
            Message.AppendFormat(" you{0} age is{1} 22 ", "omar",true);
            Message.AppendJoin(";", "omar", "mohamed", "salem");
            Console.WriteLine($"Message is {Message}");
            Console.WriteLine($"Message is {Message.GetHashCode()}");*/

            #endregion

            #region Arrays -one dimension

            //array is a Class : Reference Type
            /*int[] Numbers;
            //References to Null

            Numbers = new int[3*//*don't have to*//*] { 1,2,3};
            Numbers = [5,6,7];
            //CLR will allocate 12 bytes at the heap will be intialized by 0 
            *//*Numbers[0] = 0;
            Numbers[1] = 1;
            Numbers[2] = 2;*//*

            Console.WriteLine(Numbers[0]);          
            Console.WriteLine(Numbers[1]);
            Console.WriteLine(Numbers[2]);
            Console.WriteLine($"the number of number is {Numbers.Length} The diminsint is {Numbers.Rank}");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }*/
            //arays o(1) to select an item 
            //arrays have fixed length
            #endregion

            #region Arrays - Two D 
            /*int[,] Marks = new int[3, 5];
            Console.WriteLine(Marks.Rank);

            Console.Clear();
            Console.Beep(2000,1500);

            bool flag;
            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                Console.WriteLine($"please enter the markse of the student no{i + 1}");
                //do while is better here
                for (int j = 0; j <Marks.GetLength(1); *//*j++*//*)
                {
                    Console.WriteLine($"please enter the mark of the subject no{j+1}");
                    flag=int.TryParse(Console.ReadLine(), out Marks[i, j]);
                    if (flag)
                        j++;
                }
            }

            Console.Clear();

            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                Console.WriteLine($"the data for student no {i+1} is");
                for (int j = 0; j < Marks.GetLength(1);j++)
                {

                    Console.WriteLine($"the grade of subject no {j + 1} is {Marks[i, j]}");
                }
                Console.WriteLine("======================");
            }*/

            /* Marks[0, 0] = 1;
             Marks[0, 1] = 2;
             Marks[0, 2] = 3;
             Marks[0, 3] = 4;
             Marks[0, 4] = 5;

             Marks[1, 0] = 1;
             Marks[1, 1] = 2;
             Marks[1, 2] = 3;
             Marks[1, 3] = 4;
             Marks[1, 4] = 5;

             Marks[2, 0] = 1;
             Marks[2, 1] = 2;
             Marks[2, 2] = 3;
             Marks[2, 3] = 4;
             Marks[2, 4] = 5;

             Marks[3, 0] = 1;
             Marks[3, 1] = 2;
             Marks[3, 2] = 3;
             Marks[3, 3] = 4;
             Marks[3, 4] = 5;*/


            /*int[,] Numbers = { {1,2,3 },{4,5,6 } };
            for (int i = 0; i < Numbers.GetLength(0) * Numbers.GetLength(1); i++)
            {
                Console.WriteLine(Numbers[i / Numbers.GetLength(1), i % Numbers.GetLength(1)]);
            }*/

            #endregion

            #region Two D array judged

            /*int[][] Marks = new int[3][];
            Marks[0] = new int[3] { 9, 8, 3 };
            Marks[1] = new int[2] { 7, 2 };
            Marks[2] = new int[1] { 5 };*/


            #endregion

            #region Array Methods

            //1- Class member methods

            // the Class named Array [static]

            /*int[] numbers = { 1, 2, 6, 5, 2, 8, 4, 8, 9, 0, 4, 97 };


            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            int[] array1 = { 1, 2, 3 };
            int[] array2 = new int[2];


            Array.Copy(array1, array2, 2);
            foreach (int number in array2)
            {
            Console.WriteLine(number); 
            }
            Array.Clear(array1);
            //Array.ConstrainedCopy();
            

            Array array3 = Array.CreateInstance(typeof(char), 10);

            int[] array4 = (int[])Array.CreateInstance(typeof(int),5,4);
            */

            //2- object member methods [non-static]

            /*int[] array = { 1, 2 };
            Array array2 = new int[4];
            array.CopyTo(array2,2);
            foreach(int i in array2)
                Console.WriteLine(i.GetHashCode());

            array.GetLength(0);
            int a = 0;  */


            #endregion

            #region Functions

            //functions has two components
            //1- prototype signature RetrunType and the name paraamters and the body
            //2-Calling of Function
            /* Program.Print("#",5);
             PrintPattern(5,"$");

             //to not pass arguments by different order you should pass by name
             PrintPattern(  10, Pattern: "^");*/
            #region Passing By Value and reference
            //passing by reference 
            /* int A = 5, B =8;

             Swap(ref A,ref B);

             Console.WriteLine($"After The Swap is A :{A} and B: {B}");*/



            #endregion

            //passing by out

            #region passing by out
            /*int A = 10, B = 5;
                SumMul(A, B, out int sumres, out int multres);
                Console.WriteLine($"sum :{sumres} multi :{multres}");*/
            #endregion

            #region Functions-Params

            /*int[] number = { 1, 2, 3, 4, 5, 6, 7 };
            int totatl= SumArray(number);
            Console.WriteLine(totatl);
            Console.WriteLine(number[0]);*/

            #endregion

            #endregion

            #region Boxing vs UnBoxing

            //Boxing : casting from value type to reference type 
            //UnBoxing : casting from reference type to value type
            #region ex1
            /*object obj;
            //declare for reference of type object refer to null
            //the reference can refere to instance of Object 
            obj = new object();
            obj = new string("omar ");
            obj = 'O';//Casting from char [Value Type ] to object [Refernce Type ] implicitly

            obj = 3;//Casting from inter [Value Type ] to object [Refernce Type ] implicitly

            obj = true; //Casting from boolian [Value Type ] to object [Refernce Type ] implicitly

            bool flag = (bool)obj;//unboxing 
            Console.WriteLine(flag);*/
            #endregion

            #region ex2
            /* //Boxing 
             int X = 5;

             object O1 = X;
             //casting from int to object  Boxing safe casting impilicit castin 

             Console.WriteLine(O1);

             //UnBoxing 
             object O2 = 10;

             O2 = "ahmed";

             int Y = (int)O2;*/

            #endregion
            #endregion

            int x;
            Console.WriteLine(x);
        }
    }
}
