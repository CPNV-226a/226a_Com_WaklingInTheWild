﻿namespace WalkingInTheWild
{
    public class Equipment
    {
        //region private attributes
        private string _description;
        private float _weight;
        //endregion private attributes

        //region public methods
        public Equipment(string description, float weight)
        {
            throw new NotImplementedException();
        }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Weight
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        //endregion public methods

        //region private methods
        //endregion private methods

        //region nested classes
        public class EquipmentException : Exception { }
        public class TooSmallerWeight : EquipmentException { }
        //enregion  nested classes
    }
}