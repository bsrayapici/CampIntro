namespace MyGame.Abstract
{
    using MyGame.Entities;

    public interface IPlayerService
    {
        void Save(Player player);

        void Update(Player player);

        void Delete(Player player);

    }
}
