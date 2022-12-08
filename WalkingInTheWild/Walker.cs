namespace WalkingInTheWild
{
    public class Walker
    {
        #region private attributes
        private string _pseudo;
        private Bagpack? _bagpack;
        #endregion private attributes

        #region public methods
        public Walker(string pseudo)
        {
            _pseudo = pseudo;
        }

        public string Pseudo
        {
            get
            {
                return _pseudo;
            }
        }

        public Bagpack? Bagpack
        {
            get
            {
                return _bagpack;
            }
        }

        public void TakeBagpack(Bagpack bagpack)
        {
            _bagpack = bagpack;
        }

        public void DropBagpack()
        {
            _bagpack = null;
        }

        public void LoadBagpack(List<Cloth> cloths)
        {
            throw new NotImplementedException();
        }

        public void LoadBagpack(List<Equipment> equipments)
        {
            throw new NotImplementedException();
        }

        public void EmptyBagpack()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        #endregion private methods

        #region nested classes
        public class WalkerException:Exception{}
        public class WalkerAlreadyCarriesABagpackException : Exception { }
        public class WalkerDoesntCarryABagpackException : Exception { }
        public class EmptyBagpackException : WalkerException { }
        #endregion nested classes
    }
}