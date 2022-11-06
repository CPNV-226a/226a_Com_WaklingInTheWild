using WalkingInTheWild;
using static WalkingInTheWild.Cloth;
using static WalkingInTheWild.Equipment;

namespace TestWalkingInTheWild
{
    public class TestsEquipment
    {
        //region private attributes
        private Equipment _equipment;
        private string _description;
        private float _weight;
        //endregion private attributes

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            _description = "Bottle";
            _weight = 1.2f;
            _equipment = new Equipment(_description, _weight);

            //when
            //Event is triggered directly by the assertion

            //then
            Assert.That(_equipment.Description, Is.EqualTo(_description));
            Assert.That(_equipment.Weight, Is.EqualTo(_weight));
        }

        [Test]
        public void Constructor_SetTooSmallerValue_ThrowException()
        {
            //given
            _description = "Bottle";
            _weight = -1.2f;
            
            //when
            //Event is triggered directly by the assertion

            //then
            Assert.Throws<TooSmallerWeight>(delegate { new Equipment(_description, _weight); });
        }
    }
}