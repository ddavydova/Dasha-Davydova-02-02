using System;

namespace compsci
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //print individual characters of string in reverse order :
                string str;
                int l = 0;
                Console.Write("Input the string : ");
                str = Console.ReadLine();

                l = str.Length - 1;
                Console.Write("The characters of the string in reverse are : \n");
                while (l >= 0)
                {
                    Console.Write("{0}", str[l]);
                    l--;
                }
                Console.Write("\n\n");


                { // Count the total number of words in a string :
                    string str;
                    int i, wrd, l;

                    Console.Write("Input the string : ");
                    str = Console.ReadLine();

                    l = 0;
                    wrd = 1;

                    /* loop till end of string */
                    while (l <= str.Length - 1)
                    {
                        /* check whether the current character is white space or new line or tab character*/
                        if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                        {
                            wrd++;
                        }

                        l++;
                    }

                    Console.Write("Total number of words in the string is : {0}\n", wrd);



                    //Count total number of alphabets, digits and special characters :

                    {
                        string str;
                        int alp, digit, splch, i, l;
                        alp = digit = splch = i = 0;

                        Console.Write("Input the string : ");
                        str = Console.ReadLine();
                        l = str.Length;

                        /* Checks each character of string*/

                        while (i < l)
                        {
                            if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                            {
                                alp++;
                            }
                            else if (str[i] >= '0' && str[i] <= '9')
                            {
                                digit++;
                            }
                            else
                            {
                                splch++;
                            }

                            i++;
                        }

                        Console.Write("Number of Alphabets in the string is : {0}\n", alp);
                        Console.Write("Number of Digits in the string is : {0}\n", digit);
                        Console.Write("Number of Special characters in the string is : {0}\n\n", splch);
                    }

                    { //Check whether a given substring is present in the given strig :
                        string str1, str2;
                        bool m;


                        Console.Write("Input the string : ");
                        str1 = Console.ReadLine();

                        Console.Write("Input the substring to  search : ");
                        str2 = Console.ReadLine();
                        m = str1.Contains(str2); // boolean value tapped hare
                        if (m) // check boolean value is true or false.
                            Console.Write("The substring exists in the string.\n\n");
                        else
                            Console.Write("The substring is not exists in the string. \n\n");
                    }

                    {// Replace lowercase characters by uppercase and vice-versa :
                        string str1;
                        char[] arr1;
                        int l, i;
                        l = 0;
                        char ch;


                        Console.Write("Input the string : ");
                        str1 = Console.ReadLine();
                        l = str1.Length;
                        arr1 = str1.ToCharArray(0, l); // Converts string into char array.

                        Console.Write("\nAfter conversion, the string is : ");
                        for (i = 0; i < l; i++)
                        {
                            ch = arr1[i];
                            if (Char.IsLower(ch)) // check whether the character is lowercase
                                Console.Write(Char.ToUpper(ch)); // Converts lowercase character to uppercase.
                            else
                                Console.Write(Char.ToLower(ch)); // Converts uppercase character to lowercase.
                        }
                        Console.Write("\n\n");
                    }

                    {// Search the position of a substing within a string :

                        string str1;
                        string findstr;

                        Console.Write("Input a String: ");
                        str1 = Console.ReadLine();

                        Console.Write("Input a substring to be found in the string: ");
                        findstr = Console.ReadLine();
                        int index = str1.IndexOf(findstr);
                        if (index < 0)
                            Console.WriteLine("The substring no found  in the given string \n");
                        else
                            Console.WriteLine("Found '{0}' in '{1}' at position {2}",
                                              findstr, str1, index);
                    }
                }
            }
        }
    }
}
}