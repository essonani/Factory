namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numofwheel;bool input = false;
            do
            {
                Console.WriteLine("how many wheel does your vehicule has?");
                input = int.TryParse(Console.ReadLine(), out numofwheel);
                var Vehicule = VehiculeFactory.GetVehicule(numofwheel); Vehicule.Drive();
            }while (!input);
                    
        }

        
    }
}
