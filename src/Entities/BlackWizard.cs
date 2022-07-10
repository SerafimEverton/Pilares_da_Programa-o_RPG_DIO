using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDIO.src.Entities
{
    public class BlackWizard : Hero
    {
       public BlackWizard(string Name, int ExperienceLevel, string PowerType, int PowerLevel, int LevelLife) : base (Name, ExperienceLevel, PowerType, PowerLevel, LevelLife)
       {
            this.Name = Name;
            this.ExperienceLevel = ExperienceLevel;
            this.PowerType = PowerType;
            this.PowerLevel = PowerLevel;
            this.LevelLife = LevelLife;
       }

        public override string Attack(){
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6)
            {
             return this.Name + " Lançou Magia com Bonus de "+ Bonus;   
            }else{
            return this.Name + " Lançou Magia com baixo efeito com Bonus de " + Bonus;
            }
        }

       public override string AddItems(int Nivel){

            if(Nivel > 39){
                return this.Name + " parabéns, você tem permissão para utilizar novos itens, magia e equipamentos que iram evoluir conforme seu nível de experiencia for aumentando. ";
            }else{
                return this.Name + " você ainda não tem experiencia suficiente para subir de nível";
            }
        }
    }
}