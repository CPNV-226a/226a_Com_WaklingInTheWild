namespace WalkingInTheWild
{
    public class Bagpack
    {
        //region private attributes
        private List<Cloth> _clothes;
        private List<Equipment> _equipments;
        private readonly float _maxLoad;    
        //endregion private attributes

        //region public methods
        public Bagpack(float maxLoad)
        {
            throw new NotImplementedException();
        }
        
        public List<Cloth> Clothes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<Equipment> Equipments
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float RemainingLoadCapacity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Cloth cloth)
        {
            throw new NotImplementedException();
        }

        public void Add(Equipment equipment)
        {
            throw new NotImplementedException();
        }
        //endregion public methods

        //region private methods
        //endregion private methods

        //region nested classes
        public class BagpackException : Exception { }
        public class MaximumLoadReachedException : BagpackException { }
        //enregion  nested classes
    }
}