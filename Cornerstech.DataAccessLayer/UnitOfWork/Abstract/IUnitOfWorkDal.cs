namespace Cornerstech.DataAccessLayer.UnitOfWork.Abstract
{
    public interface IUnitOfWorkDal // Interface for managing multiple database operations as a single atomic transaction
    {
        void Save(); // Commits all changes to the database as part of the Unit of Work

    }
}
