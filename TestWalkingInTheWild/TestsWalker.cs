using WalkingInTheWild;
using static WalkingInTheWild.Bagpack;
using static WalkingInTheWild.Cloth;
using static WalkingInTheWild.Walker;

namespace TestWalkingInTheWild
{
    public class TestsWalker
    {
        //region private attributes
        private Walker _walker;
        private string _pseudo;
        private Bagpack _bagpack = null;
        private float _maxLoad = 60.50f;
        //endregion private attributes

        [SetUp]
        public void Setup()
        {
            _pseudo = "Pseudo";
            _walker = new Walker(_pseudo);
            _bagpack = new Bagpack(_maxLoad);
        }

        [Test]
        public void Properties_AfterInstantiationDefaultValues_PropertiesAreCorrecltyReturned()
        {
            //given
            //refer to Setup()

            //when
            //constructor is called in Setup() 

            //then
            Assert.That(_walker.Pseudo, Is.EqualTo(_pseudo));
            Assert.IsNull(_walker.Bagpack);
        }

        [Test]
        public void TakeBagpack_WalkerDoesntCarryABagpack_BagpackTaken()
        {
            //given
            //refer to Setup()
            Assert.Null(_walker.Bagpack);

            //when
            _walker.TakeBagpack(_bagpack);

            //then
            Assert.That(_walker.Bagpack, Is.EqualTo(_bagpack));
        }

        [Test]
        public void TakeBagpack_WalkerAlreadyCarriesABagpack_ThrowException()
        {
            //given
            //refer to Setup()
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);

            //when
            //Event is called by the assertion

            //then
            Assert.Throws<WalkerAlreadyCarriesABagpackException>(() => _walker.TakeBagpack(_bagpack));
        }

        [Test]        
        public void DropBagpack_WalkerIsAlreadyCarringABagpack_WalkerDropsTheBagpack()
        {
            //given
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);

            //when
            _walker.DropBagpack();

            //then
            Assert.IsNull(_walker.Bagpack);
        }

        [Test]
        public void DropBagpack_WalkerIsNotCarringABagpack_ThrowException()
        {
            //given
            Assert.Null(_walker.Bagpack);

            //when
            //Event is called by the assertion

            //then
            Assert.Throws<WalkerDoesntCarryABagpackException>(() => _walker.DropBagpack());
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadSingleCloth_ClothIsLoadedInBagpack()
        {
            //given
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);
            Assert.That(_walker.Bagpack.Clothes.Count, Is.EqualTo(0));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));

            //when
            _walker.LoadBagpack(Utils.GenerateClothes(1));

            //then
            Assert.That(_walker.Bagpack.Clothes.Count, Is.EqualTo(1));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadMultipleCloths_ClothsAreLoadedInBagpack()
        {
            //given
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);
            Assert.That(_walker.Bagpack.Clothes.Count, Is.EqualTo(0));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));

            //when
            _walker.LoadBagpack(Utils.GenerateClothes(10));

            //then
            Assert.That(_walker.Bagpack.Clothes.Count, Is.EqualTo(10));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));
        }

        [Test]
        public void LoadBagpack_ClothBagpackNotAvailable_ThrowException()
        {
            //given
            Assert.Null(_walker.Bagpack);

            //when
            //Event is called by the assertion

            //then
            Assert.Throws<WalkerDoesntCarryABagpackException>(() => _walker.LoadBagpack(Utils.GenerateClothes(1)));
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadSingleEquipment_EquipmentIsLoadedInBagpack()
        {
            //given
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);
            Assert.That(_walker.Bagpack.Equipments.Count, Is.EqualTo(0));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));

            //when
            _walker.LoadBagpack(Utils.GenerateEquipment(1));

            //then
            Assert.That(_walker.Bagpack.Equipments.Count, Is.EqualTo(1));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad - 1));
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadMultipleEquipments_EquipmentAreLoadedInBagpack()
        {
            //given
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);
            Assert.That(_walker.Bagpack.Equipments.Count, Is.EqualTo(0));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad));

            //when
            _walker.LoadBagpack(Utils.GenerateEquipment(10));

            //then
            Assert.That(_walker.Bagpack.Equipments.Count, Is.EqualTo(10));
            Assert.That(_walker.Bagpack.RemainingLoadCapacity, Is.EqualTo(_maxLoad - 55));
        }

        [Test]
        public void LoadBagpack_EquipmentBagpackNotAvailable_ThrowException()
        {
            //given
            Assert.Null(_walker.Bagpack);

            //when
            //Event is called by the assertion

            //then
            Assert.Throws<WalkerDoesntCarryABagpackException>(() => _walker.LoadBagpack(Utils.GenerateEquipment(1)));
        }

        [Test]
        public void LoadBagpack_ReachMaxLoad_ThrowException()
        {
            //given
            _walker.TakeBagpack(_bagpack);
            Assert.NotNull(_walker.Bagpack);
            
            //when
            //Event is called by the assertion
            
            //then
            Assert.Throws<MaximumLoadReachedException>(() => _walker.LoadBagpack(Utils.GenerateEquipment(50)));
        }
    }
}