using WalkingInTheWild;
using static WalkingInTheWild.Bagpack;

namespace TestWalkingInTheWild
{
    public class TestsBagPack
    {
        //region private attributes
        private Bagpack _bagpack;
        private readonly float _maxLoad = 25.50f;
        //endregion private attributes
        
        [SetUp]
        public void Setup()
        {
            _bagpack = new Bagpack(_maxLoad);
        }

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup method
            
            //when
            //Event is triggered directly by the assertion

            //then
            Assert.That(_bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));
            Assert.That(_bagpack.Clothes.Count, Is.EqualTo(0));
            Assert.That(_bagpack.Equipments.Count, Is.EqualTo(0));
        }

        [Test]
        public void Add_FirtClothInEmptyBagpack_Success()
        {
            //given
            //refer to Setup method
            Cloth cloth = new Cloth("Brand");

            //when
            _bagpack.Add(cloth);

            //then
            Assert.That(_bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));
            Assert.That(_bagpack.Clothes.Count, Is.EqualTo(1));
        }

        [Test]
        public void Add_SeveralClothesInEmptyBagpack_Success()
        {
            //given
            //refer to Setup method
            Cloth cloth = new Cloth("Brand");
            List<Cloth> clothes = Utils.GenerateClothes(5);
            
            //when
            foreach (Cloth clothToAdd in clothes)
            {
                _bagpack.Add(clothToAdd);
            }

            //then
            Assert.That(_bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));
            Assert.That(_bagpack.Clothes.Count, Is.EqualTo(clothes.Count));
        }

        [Test]
        public void Add_FirtEquipmentInEmptyBagpack_Success()
        {
            //given
            //refer to Setup method
            Equipment equipment = new Equipment("My Equipment", 0.5f);
            float expectedLoadCapacity = _maxLoad - equipment.Weight;

            //when
            _bagpack.Add(equipment);

            //then
            Assert.That(_bagpack.RemainingLoadCapacity, Is.EqualTo(expectedLoadCapacity));
            Assert.That(_bagpack.Equipments.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddEquipment_SeveralEquipmentsInEmptyBagpack_Success()
        {
            //given
            //refer to Setup method
            List<Equipment> equipments = Utils.GenerateEquipment(5);
            float expectedRemainingLoadCapacity = 10.5f;

            //when
            foreach (Equipment equipmentToAdd in equipments)
            {
                _bagpack.Add(equipmentToAdd);
            }

            //then
            Assert.That(_bagpack.RemainingLoadCapacity, Is.EqualTo(expectedRemainingLoadCapacity));
            Assert.That(_bagpack.Equipments.Count, Is.EqualTo(equipments.Count));
        }
        
        [Test]
        public void AddEquipment_SeveralEquipmentsMaxLoadReached_ThrowException()
        {
            //given
            //refer to Setup method
            List<Equipment> equipments = Utils.GenerateEquipment(6);
            foreach (Equipment equipmentToAdd in equipments)
            {
                _bagpack.Add(equipmentToAdd);
            }

            //when
            //event is called directly by the assertion

            //then
            Assert.Throws<MaximumLoadReachedException>(delegate { _bagpack.Add(equipments[5]); });
        }
    }
}