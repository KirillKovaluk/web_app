namespace api.Services
{
    public interface ILotService
    {
        Task<IEnumerable<LotView>> GetLotsPublicAsync();
    }
}
