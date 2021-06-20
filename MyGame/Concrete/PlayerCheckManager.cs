namespace MyGame.Concrete
{
    using MyGame.Abstract;
    using MyGame.Entities;
    using KPSServiceReference;

    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            var client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrula(player.TurkishNationalId, player.FirstName, player.LastName, player.DateOfBirth.Year);
        }
    }
}
