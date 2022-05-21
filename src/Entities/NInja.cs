namespace dotnet.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack()
        {
            return this.Name + "lançou um ninjutsu";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
            return this.Name + "lançou um ninjustu super efetiva com bonus de ataque de " + Bonus;
            }else{
                return this.Name + "lançou uma shuriken com força fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}