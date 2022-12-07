namespace WalkingInTheWild
{
    public class Walker
    {
        #region private attributes
        private string _pseudo;
        private Bagpack? _backpack;
        #endregion private attributes

        #region public methods
        public Walker(string pseudo)
        {
            throw new NotImplementedException();
        }

        public string Pseudo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Bagpack? Bagpack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void TakeBagpack(Bagpack bagpack)
        {
            throw new NotImplementedException();
        }

        public void DropBagpack()
        {
            throw new NotImplementedException();
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
        public class WalkerNotReadyException : WalkerException { }
        public class EmptyBagpackException : WalkerException { }
        #endregion nested classes


    }
}