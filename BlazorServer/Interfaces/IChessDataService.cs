using System.Threading.Tasks;
using System.Collections.Generic;
using BlazorServer.Data;

public interface IChessDataService
{
    public Task<List<ChessData>> GetResponse(string username);
}