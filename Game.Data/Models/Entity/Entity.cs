
namespace Game.Data.Models.Entity
{
    public class Entity
    {      
        public string Name {get;set;}
        public int Hp {get;set;}
        public int Damage {get;set;}
        public virtual int Attack(){
            return 0;
        }
    }
}