using System;
namespace KnowledgeCheckM2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            List<PoliceRecord> recordList = new List<PoliceRecord>();
            List<string> crimeList = new List<string>();
            for (int i = 0; i < numberOfRecords; i++)
            {

                var PoliceRecord = new PoliceRecord();
                PoliceRecord.Id = i;

                Console.WriteLine($"\nId = {i} Enter the value for Name");
                PoliceRecord.Name = Console.ReadLine();
                Console.WriteLine("Enter crimes comitted with a comma to separate each crime");
                String crimes = Console.ReadLine();

                foreach (String a in crimes.Split(','))
                {
                    Console.Write($"{a} was added\n");
                    crimeList.Add(a);
                }

                recordList.Add(PoliceRecord);

                Console.WriteLine("PoliceRecord was added.\n");
                Console.WriteLine("These are the current records... ");

                foreach (var item in recordList)
                {
                    Console.WriteLine(item.Name);
                }


            }

        }
    }




}
// Print out theConsole.WriteLine("Enter the value for ");, list of records using Console.WriteLine()