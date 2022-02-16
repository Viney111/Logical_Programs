using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            // Array to store No. of notes values
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            Console.Write("Enter the change amount: ");
            //VARIABLES
            int changeAmount = Convert.ToInt32(Console.ReadLine());
            IDictionary<int, int> indidualNotesList = new Dictionary<int, int>();
            int minNotes = 0;
            int i = 7;

            while (changeAmount > 0)
            {
                int noteCounter = 0;
                if (changeAmount >= notes[i])
                {
                    noteCounter = changeAmount / notes[i];
                    indidualNotesList[notes[i]] = noteCounter;
                    changeAmount = changeAmount - noteCounter * notes[i];
                }
                minNotes = minNotes + noteCounter;
                i--;
            }
            Console.WriteLine($"The minimum no. of notes given by the note vending machine in change is {minNotes}");
            foreach(KeyValuePair<int, int> note in indidualNotesList)
            {
                Console.WriteLine($"The numbers of {note.Key} Rs. Note is {note.Value}" );
            }

        }        
    }
}
