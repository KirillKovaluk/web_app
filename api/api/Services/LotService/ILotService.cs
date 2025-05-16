namespace api.Services
{
    public interface ILotService
    {
        Task<IEnumerable<LotPublicView>> GetLotsPublicAsync();
        Task<IEnumerable<LotUserView>> GetLotsCreatedAsync();
        Task<IEnumerable<LotUserView>> GetLotsBoughtAsync();
        Task CreateLotAsync(LotCreateInput lotCreateInput);
        Task BetLotAsync(LotBetInput lotBetInput);
    }
}
