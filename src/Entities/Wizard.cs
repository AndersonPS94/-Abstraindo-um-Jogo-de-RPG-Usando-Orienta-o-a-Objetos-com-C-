namespace dotnet.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack()
        {
            return this.Name + "lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
            return this.Name + "lançou magia super efetiva com bonus de ataque de " + Bonus;
            }else{
                return this.Name + "lançou magia  com força fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}