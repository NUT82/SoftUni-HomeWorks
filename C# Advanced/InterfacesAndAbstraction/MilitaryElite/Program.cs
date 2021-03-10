using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            List<Private> privates = new List<Private>();
            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] split = text.Split();
                string type = split[0];
                string id = split[1];
                string firstName = split[2];
                string lastName = split[3];
                decimal salary = decimal.Parse(split[4]);

                switch (type)
                {
                    case "Private":
                        Private @private = new Private(id, firstName, lastName, salary);
                        soldiers.Add(@private);
                        privates.Add(@private);
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                        for (int i = 5; i < split.Length; i++)
                        {
                            if (privates.Any(s => s.Id == split[i]))
                            {
                                lieutenantGeneral.AddPrivate(privates.FirstOrDefault(s => s.Id == split[i]));
                            }
                        }

                        soldiers.Add(lieutenantGeneral);
                        break;
                    case "Engineer":
                        string corp = split[5];

                        if (Enum.IsDefined(typeof(Enums.Corp), corp))
                        {
                            Engineer engineer = new Engineer(id, firstName, lastName, salary, Enum.Parse<Enums.Corp>(corp));

                            for (int i = 6; i < split.Length; i += 2)
                            {
                                engineer.AddRepair(new Repair(split[i], int.Parse(split[i + 1])));
                            }

                            soldiers.Add(engineer);
                        }
                        break;
                    case "Commando":
                        corp = split[5];

                        if (Enum.IsDefined(typeof(Enums.Corp), corp))
                        {
                            Commando commando = new Commando(id, firstName, lastName, salary, Enum.Parse<Enums.Corp>(corp));

                            for (int i = 6; i < split.Length; i += 2)
                            {
                                if (Enum.IsDefined(typeof(Enums.State), split[i + 1]))
                                {
                                    commando.AddMission(new Mission(split[i], Enum.Parse<Enums.State>(split[i + 1])));
                                }
                            }

                            soldiers.Add(commando);
                        }
                        break;
                    case "Spy":
                        int codeNumber = (int)salary;
                        soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                        break;
                }

                text = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
