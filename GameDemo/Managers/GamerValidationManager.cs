using GameDemo.Entities;
using GameDemo.Services;
using MernisServiceReference;

namespace GameDemo.Managers
{
    internal class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(long.Parse(gamer.IdentityNumber), gamer.Firstname.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
