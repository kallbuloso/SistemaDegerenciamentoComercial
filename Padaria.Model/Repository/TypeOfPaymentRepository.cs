﻿using Padaria.Repository.Entities;
using System.Collections.Generic;


namespace Padaria.Repository.Repository
{
    public class TypeOfPaymentRepository : DefaultRepository<TypeOfPayment>
    {

        public List<TypeOfPayment> GetAlls() => base.GetAll();
        public int Creates()
        {
            int returning = 0;

            if (GetQuantitys().Equals(0))
            {
                 var list = new List<TypeOfPayment>
                {
                    new TypeOfPayment { Type="Money" },
                    new TypeOfPayment { Type="Check" },
                    new TypeOfPayment { Type="Credit"  }
                };
                list?.ForEach(c => returning = base.Create(c));

            }

            return returning;
        }
        public int GetQuantitys() => base.GetQuantity();

        public TypeOfPayment GetByIDs(int typeOfPaymentID) => base.GetByID(typeOfPaymentID);
    }
}
