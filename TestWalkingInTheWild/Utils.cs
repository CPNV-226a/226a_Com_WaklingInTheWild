using WalkingInTheWild;

namespace TestWalkingInTheWild
{
    internal static class Utils
    {
        public static List<Cloth> GenerateClothes(int amount)
        {
            List<Cloth> clothes = new List<Cloth>();
            for (int i = 0; i < amount; i++)
            {
                clothes.Add(new Cloth("Brand " + i.ToString()));
            }
            return clothes;
        }

        public static List<Equipment> GenerateEquipment(int amount)
        {
            List<Equipment> equipments = new List<Equipment>();
            for (int i = 0; i < amount; i++)
            {
                equipments.Add(new Equipment("Equipment " + i.ToString(), i+1));
            }
            return equipments;
        }
    }
}
