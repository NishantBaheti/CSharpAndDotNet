using System;

class Solution {
    static void staircase(int n) {
        int num_of_rows,num_of_columns,col1,col2,row;
        num_of_rows=n;
        num_of_columns=num_of_rows-1;
        for(row=1;row<=num_of_rows;row++){
            for(col1=1;col1<=num_of_columns;col1++){
                Console.Write(" ");
                }
            num_of_columns--;
            for(col2=1;col2<=row;col2++){
                Console.Write("#");
            }
            Console.WriteLine(" ");
                
        }


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
