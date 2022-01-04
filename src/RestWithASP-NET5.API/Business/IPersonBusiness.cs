﻿using RestWithASP_NET5.API.Data.VO;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);
    }
}
