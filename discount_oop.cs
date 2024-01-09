class parkingfee {
    Console.WriteLine("Enter entrance hour: ");
    int hourEnt = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter entrance minute:");
    int minEnt = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter exit hour: ");
    int hourExt = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter exit minute:");
    int minExt = Convert.ToInt32(Console.ReadLine());
    
    int result = 0;
    int tmp = 0;
    static void Main(string[] args){
        if ((((hourEnt == hourExt) && (minExt-minEnt<=15)) || ((hourExt - hourEnt == 1) && (minEnt + 15 <= 30)))) {    
            Console.WriteLine("parking fee = 0 baht");
        }else if (((hourExt-hourEnt >= 3) && (minExt-minEnt >= 15)) || ((hourExt-hourEnt >= 4) && (minEnt + 15 <= 30))){
            if (minExt-minEnt > 3){
                ++result;
            }
            else {
                result += (hourExt-hourEnt)*10
                Console.WriteLine("parking fee = "+(result)+" baht")
            }
        }else if (var(hourExt-hourEnt) in range(4, 6)) {
            if (minExt-minEnt > 15)
                ++result;
            else { 
                result += (hourExt-hourEnt)*20;
                Console.WriteLine("parking fee = "+(result)+)
            }
        }else if (hourExt<hourEnt){
            Console.WriteLine("YOur parking fees = 200 baht")
        }else {
        Console.WriteLine("out of range")
        }
    }
}