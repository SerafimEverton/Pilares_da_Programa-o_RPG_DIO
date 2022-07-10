using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDIO.src.Entities
{
    public abstract class Hero{

        public Hero(string Name, int ExperienceLevel, string PowerType, int PowerLevel, int LevelLife){
            this.Name = Name;
            this.ExperienceLevel = ExperienceLevel;
            this.PowerType = PowerType;
            this.PowerLevel = PowerLevel;
            this.LevelLife = LevelLife;
        }

        public string Name;
        public int ExperienceLevel;
        public string PowerType;
        public int PowerLevel;
        public int LevelLife;

        public override string ToString(){
            return this.Name +" "+ this.ExperienceLevel +" "+ this.PowerType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada";
        }

        public virtual string AddItems(int Nivel){
            Nivel = this.ExperienceLevel;

            if(Nivel > 35){
                return this.Name + " parabéns, você tem permissão para utilizar novos itens, magia e equipamentos que iram evoluir conforme seu nível de experiencia for aumentando. ";
            }else{
                return this.Name + " você ainda não tem experiencia suficiente para subir de nível";
            }
        }
    }
}