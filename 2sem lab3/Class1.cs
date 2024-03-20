using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _2sem_lab3
{
    public class Variables
    {

        public int Variable1;
        public int Variable2;
        public Variables(int Var1, int Var2)
        {
            this.Variable1 = Var1;
            this.Variable2 = Var2;
        }

        //виводимо
        public void Write()
        {
            Console.WriteLine($"{this.Variable1}, {this.Variable2}");
        }

        //змінаа значень
        public void Change(int NewVar1, int NewVar2)
        {
            this.Variable1 = NewVar1;
            this.Variable2 = NewVar2;
        }

        //cума
        public int Sum()
        {
            return this.Variable1 + this.Variable2;
        }

        //макс
        public int Max()
        { 
            return Math.Max( this.Variable1, this.Variable2);
        }

        //сереал в json
        public void SaveToJson(string fileName)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(fileName, json);
        }

        //десер з json
        public static Variables LoadFromJson(string fileName)
        {
            string json = File.ReadAllText(fileName);
            Variables loadedVariables = JsonConvert.DeserializeObject<Variables>(json);
            return loadedVariables;
        }
    }
}
