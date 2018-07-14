using System;

class Sittingarrangement{
    public static string seating_arrangement(int x){
        int seat_num=x;
        int spec=seat_num % 12;
        string seat=" ";
        int front_seat=0;
        if(spec == 0 || spec == 1 || spec ==6 || spec == 7){
            seat="WS";
        }
        else if(spec == 2 || spec == 11 || spec == 5 || spec ==8){
            seat="MS";
        }
        else if(spec == 3 || spec ==10 || spec == 4 || spec == 9){
            seat="AS";
        }
        if(seat=="WS"){
            if(spec ==0){
                front_seat=seat_num-11;
            }
            else if(spec ==1){
                front_seat=seat_num+11;
            }
            else if(spec == 6){
                front_seat=seat_num+1;
            }
            else if(spec == 7){
                front_seat=seat_num-1;
            }
        }
        
        if(seat=="MS"){
            if(spec ==2){
                front_seat=seat_num+9;
            }
            else if(spec ==11){
                front_seat=seat_num-9;
            }
            else if(spec == 5){
                front_seat=seat_num+3;
            }
            else if(spec == 8){
                front_seat=seat_num-3;
            }
        }
        
        if(seat=="AS"){
            if(spec ==3){
                front_seat=seat_num+7;
            }
            else if(spec ==10){
                front_seat=seat_num-7;
            }
            else if(spec == 4){
                front_seat=seat_num+5;
            }
            else if(spec == 9){
                front_seat=seat_num-5;
            }
        }
        return front_seat.ToString()+" "+seat;
        
    }
    static void Main(string[] args){
        int n=0,seat_num=0;
        string req_result;
        n=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++){
            seat_num=Convert.ToInt32(Console.ReadLine());
            req_result=seating_arrangement(seat_num);
            Console.WriteLine(req_result);
        }
        
    }
}

