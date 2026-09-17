using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace תרגול_כיתה
{
    //עבודה מהגיט
    // gus 
    /*public class jumper
    {
        private string id;
        private int[] jumps;

        public jumper(string id, int[] jumps)
        {
            this.id = id;
             this.jumps = new int[jumps.Length];
            for (int i = 0; i < jumps.Length; i++)
            {
                this.jumps[i] = jumps[i];
            }
        }
        public string GetId()
        {
            return id;
        }
        public int[] GetJumps()
        {
            int[] copy = new int[this.jumps.Length];
            for (int i = 0; i < this.jumps.Length; i++)
            {
                copy[i] = this.jumps[i];
            }
            return copy;
        }
        public double Average()
        {
            double sum = 0;
            for (int i = 0; i < this.jumps.Length; i++)
            {
                sum += this.jumps[i];
            }
            return sum / this.jumps.Length;
        }
        public int BestJump()
        {
            int best = this.jumps[0];
            for (int i = 1; i < this.jumps.Length; i++)
            {
                if (this.jumps[i] > best)
                {
                    best = this.jumps[i];
                }
            }
            return best;
        }
        public bool IsImproving()
        {
            for (int i = 1; i < this.jumps.Length; i++)
            {
                if (this.jumps[i] <= this.jumps[i - 1])
                {
                    return false;
                }
            }
            return true;
        }*/
    public class Flat
    {
        private int numFlat;
        private string ownerName;
        private int numRooms;
        private int familyMembers;
        private int[] payments;

        public Flat(int numFlat, string ownerName, int numRooms, int familyMembers)
        {
            this.numFlat = numFlat;
            this.ownerName = ownerName;
            this.numRooms = numRooms;
            this.familyMembers = familyMembers;
            this.payments = new int[12];
            for (int i = 0; i < this.payments.Length; i++)
            {
                this.payments[i] = 0;
            }
            
           
        }
        public int GetNumFlat()
        {
            return numFlat;
        }
        public void SetNumFlat(int numFlat)
        {
            this.numFlat = numFlat;
        }
        public string GetOwnerName()
        {
            return this.ownerName;
        }
        public void SetOwnerName(string ownerName)
        {
            this.ownerName = ownerName;
        }
        public int calcPament()
        {
            return this.numRooms* 20 + this.familyMembers* 10;
        }
        public void Pay(int numMonth)
        {
            this.payments[numMonth - 1] = this.calcPament();
        }
        public int debt()
        {
            int count = 0;
            for (int i = 0; i < this.payments.Length; i++)
            {
                if (this.payments[i] == 0)
                    count++;
            }
            return count * this.calcPament();
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                /*jumper[] jumps = new jumper[3];
                string id, maxId = "";
                double maxAvg = 0;
                int[] jump = new int[3];
                for (int i = 0; i < jump.Length; i++)
                {
                    Console.WriteLine("Enter the id of the jumper");
                    id = Console.ReadLine();
                    Console.WriteLine("Enter the three jumps of the jumper");
                    for(int j = 0; j < jump.Length; j++)
                    {
                        jump[i] = int.Parse(Console.ReadLine());
                    }
                    jumps[i] = new jumper(id, jump);
                }*/
                
            }
        }
    }

