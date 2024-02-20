using Calculate_potential_energy;

PotentialEnergy ball = new PotentialEnergy();
ball.Mass = 15.5;
ball.Height = 50.3;

double Ep = ball.CalculatePotentialEnergy();

Console.WriteLine("The potential energy is: " + Ep + " joules");
Console.ReadKey();