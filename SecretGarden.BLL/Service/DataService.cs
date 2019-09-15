﻿using SecretGarden.DAL.Repositories.UnitOfWork;
using SecretGarden.Models.Abstraction;
using System;

namespace SecretGarden.BLL.Service
{
    public class DataService : IService, IDisposable
    {
        private IUnitOfWork unitOfWork;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (unitOfWork == null)
                    unitOfWork = new UnitOfWork();
                return unitOfWork;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
