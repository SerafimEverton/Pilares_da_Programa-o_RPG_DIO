using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDIO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int ExperienceLevel, string PowerType, int PowerLevel, int LevelLife) : base (Name, ExperienceLevel, PowerType, PowerLevel, LevelLife)
       {
            this.Name = Name;
            this.ExperienceLevel = ExperienceLevel;
            this.PowerType = PowerType;
            this.PowerLevel = PowerLevel;
            this.LevelLife = LevelLife;
      
       }

        public override string Attack(){
            return this.Name + " Deu um golpe de " + this.PowerType;
        }

        public string Attack(int Bonus){
             if (Bonus > 10)
            {
        return this.Name + " Deu um golpe de " + this.PowerType + " com Bonus de " + Bonus;
            }else{
            return this.Name + " seu golpe foi com baixo efeito com Bonus valor de " + Bonus;
            }
        }

        public override string AddItems(int Nivel){

            if(Nivel > 45){
                return this.Name + " parabéns, você tem permissão para utilizar novos itens, magia e equipamentos que iram evoluir conforme seu nível de experiencia for aumentando. ";
            }else{
                return this.Name + " você ainda não tem experiencia suficiente para subir de nível";
            }
        }
    }
}