namespace api.Services
{
    public interface ILotService
    {
        Task<IEnumerable<LotPublicView>> GetLotsPublicAsync();
    }
}
