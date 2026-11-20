namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface IHasherHelper
    {
        string Hash(string value);
        bool Verify(string hash, string value);
    }
}
