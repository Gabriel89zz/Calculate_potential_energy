using Calculate_potential_energy;

PotentialEnergy ball = new PotentialEnergy();
ball.Mass = 15.5;
ball.Height = 50.3;

Console.WriteLine("The potential energy of the object with mass of: "+ball.Mass+ " kg and height of: "+ball.Height +" m it is: "+ ball.CalculatePotentialEnergy(ball)+" Joules");
Console.ReadKey();