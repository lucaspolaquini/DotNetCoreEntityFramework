﻿using Fiap.MasterChef.Model;
using Fiap.MasterChef.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.MasterChef.Repository
{
    public class IngredienteRepository : RepositoryBase<IngredienteModel>, IIngredienteRepository
    {
        public IngredienteRepository(MasterChefContext context):base(context)
        {

        }
    }
}
