using _02_Claims.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims.Console
{
    private ClaimRepository _claims = new ClaimRepository();
    public class ProgramUI
    {
        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                System.Console.Clear();
                System.Console.WriteLine("Welcome to Komodo Claims Department\n\n");
                System.Console.WriteLine("Please select a menu option:\n" +
                    "1) See all claims\n" +
                    "2) Take care of next claim\n" +
                    "3) Enter a new claim\n" +
                    "4) Exit\n");

                string input = System.Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        System.Console.WriteLine("\nThank you for using the Komodo System!\nHave a nice day!\n");
                        keepRunning = false;
                        break;
                    default:
                        System.Console.WriteLine("Please enter a valid number:");
                        break;
                }

                System.Console.WriteLine("Please press any key to continue...");
                System.Console.ReadKey();
                System.Console.Clear();
            }
        }

        private void SeeAllClaims()
        {
            System.Console.Clear();
            Queue<Claim> allClaims = _claims.SeeAllClaims();
            
            System.Console.WriteLine("ClaimID\tType\tDescription\tAmount\tDateOfAccident\tDateOfClaim\tIsValid");
        }

        private void TakeCareOfClaim()
        {

        }

        private void EnterNewClaim()
        {

        }

        public void SeedContent()
        {
            Claim claimOne = new Claim(1, ClaimType.Car, "Car accident on 465.", 400, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"), true);
        }
    }
}
