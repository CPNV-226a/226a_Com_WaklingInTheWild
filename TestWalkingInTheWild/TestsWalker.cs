using WalkingInTheWild;
using static WalkingInTheWild.Cloth;
using static WalkingInTheWild.Walker;

namespace TestWalkingInTheWild
{
    public class TestsWalker
    {
        //region private attributes
        private Walker walker;
        private string pseudo;
        //endregion private attributes

        [SetUp]
        public void Setup()
        {
            pseudo = "Pseudo";
            walker = new Walker(pseudo);
        }

        [Test]
        public void Properties_AfterInstantiationDefaultValues_PropertiesAreCorrecltyReturned()
        {
            //given
            //refer to Setup()

            //when
            //constructor is called in Setup() 

            //then
            Assert.AreEqual(pseudo, walker.Pseudo);
            Assert.IsNull(walker.Bagpack);
        }

        [Test]
        public void TakeBagpack_WalkerReady_BagpackTaken()
        {
            //given
            //refer to Setup()
            Bagpack bagpack = new Bagpack(20.00f);
            Assert.Null(walker.Bagpack);

            //when
            this.walker.TakeBagpack(bagpack);

            //then
            Assert.AreEqual(bagpack, walker.Bagpack);
        }

        [Test]
        public void TakeBagpack_WalkerNotReady_ThrowException()
        {
            //given
            //refer to Setup()
            Bagpack bagpack = new Bagpack(20.00f);
            this.walker.TakeBagpack(bagpack);
            Assert.NotNull(walker.Bagpack);

            //when
            //Event is called by the assertion

            //then
            Assert.Throws<WalkerNotReadyException>(() => this.walker.TakeBagpack(bagpack));
        }

        /*
        [Test]        
        public void DropBagpack_WalkerIsCarringABagpack_WalkerDropsTheBagpack()
        {
            //given

            //when

            //then
        }

        [Test]
        public void DropBagpack_WalkerIsNotCarringABagpack_ThrowException()
        {
            //given

            //when

            //then
        }

        
        [Test]
        public void LoadBagpack_BagpackAvailableLoadSingleCloth_ClothIsLoadedInBagpack()
        {
            //given

            //when

            //then
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadMultipleCloths_ClothsAreLoadedInBagpack()
        {
            //given

            //when

            //then
        }

        [Test]
        public void LoadBagpack_ClothBagpackNotAvailable_ThrowException()
        {
            //given

            //when

            //then
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadSingleEquipment_EquipmentIsLoadedInBagpack()
        {
            //given

            //when

            //then
        }

        [Test]
        public void LoadBagpack_BagpackAvailableLoadMultipleEquipments_EquipmentAreLoadedInBagpack()
        {
            //given

            //when

            //then
        }

        [Test]
        public void LoadBagpack_EquipmentBagpackNotAvailable_ThrowException()
        {
            //given

            //when

            //then
        }

        [Test]
        public void EmptyBagpack_BagpackContainsClothsAndEquipment_BackpackIsEmpty()
        {
            //given

            //when

            //then
        }

        [Test]
        public void EmptyBagpack_BagpackDoesntContainNeitherClothsOrEquipment_ThrowException()
        {
            //given

            //when

            //then
        }
        */
    }
}