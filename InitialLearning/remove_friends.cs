using System;
using System.Collections.Generic;
using System.Linq;

class solution{
    static void Main(string[] args){
        int t=Convert.ToInt32(Console.ReadLine());
        while(t>0){
            string s=Console.ReadLine();
            string[] token=s.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
            int[] array=Array.ConvertAll(token,int.Parse);
            int fr_count=array[0];
            int del_count=array[1];
            
            LinkedList<int> friends = new LinkedList<int>(Console.ReadLine().Trim().Split(' ').Select(int.Parse));          
            LinkedListNode<int> current=friends.First;
            while(del_count > 0){
                while((current.Next!= null) && (current.Value>=current.Next.Value)){
                    current=current.Next;
                }
                if(current.Next == null){
                    break;
                }
                
                LinkedListNode<int> del_node= current;
                current= current.Previous ?? current.Next;
                friends.Remove(del_node);
                del_count--;
            }
            if(del_count >0){
                friends.Remove(friends.Last);
            }
            Console.WriteLine(string.Join(" ",friends));
            t--;
        }
    }
}
