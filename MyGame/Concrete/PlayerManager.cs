namespace MyGame.Concrete
{
    using MyGame.Abstract;
    using MyGame.Entities;
    using System;

    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Delete(Player player)
        {
            Console.WriteLine("deleted from db ");
        }

        public void Save(Player player)
        {
            var _isRealPeplayerCheckService.CheckIfRealPerson(player);
            Console.WriteLine("saved to db : " + player.FullName);
        }

        public void Update(Player player)
        {
            Console.Write("updated on db " + player.FullName);
        }
    }
}
