using WalkingInTheWild;
using static WalkingInTheWild.Cloth;

namespace TestWalkingInTheWild
{
    public class TestsCloth
    {
        //region private attributes
        private Cloth _cloth;
        private string _brand;
        private bool _waterProof;
        //endregion private attributes

        [SetUp]
        public void Setup()
        {
            _brand = "NorthFace";
            _cloth = new Cloth(_brand);
        }

        [Test]
        public void AllProperties_AfterInstantiationNotWaterProof_Success()
        {
            //given
            //refer to Setup method

            //when
            //Event is triggered directly by the assertion

            //then
            Assert.That(_cloth.Brand, Is.EqualTo(_brand));
            Assert.IsFalse(_cloth.IsWaterProof);
        }

        [Test]
        public void AllProperties_AfterInstantiationWaterProof_Success()
        {
            //given
            //refer to Setup method
            //override Setup method regarding waterproof attribute
            _waterProof = true;
            _cloth = new Cloth(_brand, _waterProof);

            //when
            //Event is triggered directly by the assertion

            //then
            Assert.That(_cloth.Brand, Is.EqualTo(_brand));
            Assert.IsTrue(_cloth.IsWaterProof);
        }

        [Test]
        public void IsWaterProof_SetAsTrue_Success()
        {
            //given
            //refer to Setup method
            Assert.IsFalse(_cloth.IsWaterProof);

            //when
            _cloth.IsWaterProof = true;

            //then
            Assert.That(_cloth.Brand, Is.EqualTo(_brand));
            Assert.IsTrue(_cloth.IsWaterProof);
        }

        [Test]
        public void IsWaterProof_SetAsTrueButAlreadyWaterProof_ThrowException()
        {
            //given
            //refer to Setup method
            Assert.IsFalse(_cloth.IsWaterProof);
            _cloth.IsWaterProof = true;
            Assert.IsTrue(_cloth.IsWaterProof);

            //when
            //Event is triggerd directly by the assertion

            //then
            Assert.Throws<AlreadyWaterProofException>(delegate { _cloth.IsWaterProof = true; });
        }
    }
}