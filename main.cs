using System;

class MainClass {
  public static void Main (string[] args) {
    double sum = 0;
    for ( int counter = 1; counter <= 7 ; counter++){
       Console.WriteLine ("Enter the distance covered by car#" + counter);
       double distance = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Enter the time taken by car#"+ counter);
       double time = Convert.ToDouble(Console.ReadLine());
       double speed = distance / time;
       sum = sum + speed;
       Console.WriteLine("The speed of this car is " + speed + " miles per hour");
    }
    double average = sum / 7;
    Console.WriteLine("The average speed of the cars is " + average + " miles per hour");
   
  }
}