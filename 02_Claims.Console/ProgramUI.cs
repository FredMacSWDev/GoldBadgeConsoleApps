using _02_Claims.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims.Console
{
    public class ProgramUI
    {
        private ClaimRepository _repo = new ClaimRepository();
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
            Queue<Claim> allClaims = _repo.GetClaims();
            DataTable claimTable = new DataTable("Komodo Insurance Claims Database");
            System.Console.WriteLine(string.Format("{0," + ((System.Console.WindowWidth / 2) + (claimTable.TableName.Length / 2)) + "}", claimTable));
            DataColumn claimIdCol = new DataColumn("Claim ID", typeof(int));
            DataColumn claimTypeCol = new DataColumn("Type", typeof(Enum));
            DataColumn claimDescCol = new DataColumn("Description", typeof(string));
            DataColumn claimAmtCol = new DataColumn("Amount", typeof(string));
            DataColumn claimIncCol = new DataColumn("Date of Incident", typeof(DateTime));
            DataColumn claimClmDtCol = new DataColumn("Date of Claim", typeof(DateTime));
            DataColumn claimValidCol = new DataColumn("Validity", typeof(bool));
            claimTable.Columns.Add(claimIdCol);
            claimTable.Columns.Add(claimTypeCol);
            claimTable.Columns.Add(claimDescCol);
            claimTable.Columns.Add(claimAmtCol);
            claimTable.Columns.Add(claimIncCol);
            claimTable.Columns.Add(claimClmDtCol);
            claimTable.Columns.Add(claimValidCol);
            DataRow clmIdRow;
            
            foreach (Claim idPrint in allClaims)
            {                
                clmIdRow = claimTable.NewRow();
                clmIdRow["Claim ID"] = idPrint.ClaimID;
                clmIdRow["Type"] = idPrint.ClaimType;
                clmIdRow["Description"] = idPrint.Description;
                clmIdRow["Amount"] = idPrint.ClaimAmount.ToString("C2");
                clmIdRow["Date of Incident"] = idPrint.DateOfIncident.ToString("d");
                clmIdRow["Date of Claim"] = idPrint.DateOfClaim.ToString("MM/dd/yyyy");
                clmIdRow["Validity"] = idPrint.IsValid;
                claimTable.Rows.Add(clmIdRow);
            }
            PrintDataTable(claimTable);
            System.Console.WriteLine();
        }

        private void PrintDataTable(DataTable claimTable)
        {

            System.Console.WriteLine("{0, 8}\t{1, 1}\t{2, 5}\t{3, 17}\t{4, 5}\t{5, 12}\t{6, 16}",
                "Claim ID",
                "Type",
                "Description",
                "Amount",
                "Date of Incident",
                "Date of Claim",
                "Validity"
                );

            foreach (DataRow row in claimTable.Rows)
            {
                System.Console.WriteLine("{0, 8}\t{1, 1}\t{2, 5}\t{3, 9}\t{4, 5}\t{5, 12}\t{6, 8}",
                row["Claim ID"],
                row["Type"],
                row["Description"],
                row["Amount"],
                row["Date of Incident"],
                row["Date of Claim"],
                row["Validity"]);
            }
        }

        private void TakeCareOfClaim()
        {
            System.Console.Clear();            
            System.Console.WriteLine("Here are the details for the next claim to be handled:\n");

            Queue<Claim> newDetails = _repo.GetClaims();
            Claim nextClaim = newDetails.Peek();

            System.Console.WriteLine($"Claim ID: \n" +
                $"Type: \n" +
                $"Description:  \n" +
                $"Amount:  \n" +
                $"Date of Incident: \n" +
                $"Date of Claim: \n" +
                $"IsValid: \n" +
                $"\n" +
                $"Do you want to deal with this claim now (y/n)?");

         
            string input = System.Console.ReadLine().ToLower();
            switch (input)
            {
                case "y":
                    newDetails.Dequeue();
                System.Console.WriteLine("The claim is ready to be reviewed for processing.");
                    break;
                case "n":
                    System.Console.WriteLine("The claim has been returned to queue.");
                    Menu();
                    break;
                default:
                    System.Console.WriteLine("Please enter either y or n");
                    break;
            }

            
        }

        private void EnterNewClaim()
        {
            System.Console.Clear();
            Claim addClaim = new Claim();

            System.Console.Write("Please enter the NEW Claim Number:  ");
            string claimIdAsString = System.Console.ReadLine();
            int claimIdAsInt = Convert.ToInt32(claimIdAsString);
            addClaim.ClaimID = claimIdAsInt;

            System.Console.WriteLine("Please enter the NEW Claim Type:\n" +
                "1) Car\n" +
                "2) Home\n" +
                "3) Theft\n");

            string claimTypeAsString = System.Console.ReadLine();
            int claimTypeAsInt = Convert.ToInt32(claimTypeAsString);
            addClaim.ClaimType = (ClaimType)claimTypeAsInt;

            System.Console.Write("Please enter a description of the NEW Claim:  ");
            addClaim.Description = System.Console.ReadLine();

            System.Console.Write("Please enter the NEW Claim Amount:  ");
            string claimAmountAsString = System.Console.ReadLine();
            decimal claimAmountAsDecimal = Convert.ToDecimal(claimAmountAsString);
            addClaim.ClaimAmount = claimAmountAsDecimal;

            System.Console.Write("Please enter the NEW Claim Date of Incident:  ");
            string claimIncDt = System.Console.ReadLine();
            DateTime clmIncToDateTime = Convert.ToDateTime(claimIncDt);
            addClaim.DateOfIncident = clmIncToDateTime;



        }

        private void SeedContent()
        {            
            Claim claimOne = new Claim(1, ClaimType.Car, "Car accident on 465.", 400.00M, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);
            Claim claimTwo = new Claim(2, ClaimType.Home, "House fire in kitchen.", 4000.00M, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12), true);
            Claim claimThree = new Claim(3, ClaimType.Theft, "Stolen pancakes.", 4.00M, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01), false);

            _repo.AddClaim(claimOne);
            _repo.AddClaim(claimTwo);
            _repo.AddClaim(claimThree);

        }
    }
}
