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
                // In this loop, populate the object's properties using Console.ReadLine()
                var PoliceRecord = new PoliceRecord();

                //Console.WriteLine("Enter the value for Id ");
                //PoliceRecord.Id = int.Parse(Console.ReadLine());
                PoliceRecord.Id = i;
                Console.WriteLine($"Id = {i}");
                Console.WriteLine("Enter the value for Name");
                PoliceRecord.Name = Console.ReadLine();
                Console.WriteLine("Enter crimes comitted with a comma to separate each crime");
                String crimes = Console.ReadLine();

                foreach (String a in crimes.Split(','))
                {
                    Console.Write($"{a} was added\n");
                    crimeList.Add(a);
                }
                recordList.Add(PoliceRecord);
                Console.WriteLine("PoliceRecord was added.");
                Console.WriteLine("These are the current records... ");
                Console.ReadLine();

                List<PoliceRecord> records = PrintRecordList();
                foreach (var item in records)
                {
                    Console.WriteLine(item.Name);
                }


            }

        }
        public static List<PoliceRecord> PrintRecordList()
        {
            return recordList;
        }
    }




}
// Print out theConsole.WriteLine("Enter the value for ");, list of records using Console.WriteLine()