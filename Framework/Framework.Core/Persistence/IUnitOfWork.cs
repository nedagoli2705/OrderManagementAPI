﻿namespace Framework.Core.Persistence
{
    public interface IUnitOfWork
    {
        void Commit();

        void Rollback();
    }
}