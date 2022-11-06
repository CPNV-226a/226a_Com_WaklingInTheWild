namespace WalkingInTheWild
{
    public class Cloth
    {
        //region private attributes
        private string _brand;
        private bool _waterProof;
        //endregion private attributes

        //region public methods
        public Cloth(string brand, bool waterProof = false)
        {
            throw new NotImplementedException();
        }

        public string Brand
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsWaterProof
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        //endregion public methods

        //region private methods
        //endregion private methods

        //region nested classes
        public class ClothException : Exception { }
        public class AlreadyWaterProofException : ClothException { }
        //enregion  nested classes
    }
}