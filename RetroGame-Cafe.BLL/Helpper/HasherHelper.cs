using Isopoh.Cryptography.Argon2;
using RetroGame_Cafe.BLL.Interfaces;

namespace RetroGame_Cafe.BLL.Helpper
{
    public class HasherHelper : IHasherHelper
    {
        public string Hash(string value)
        {
            return Argon2.Hash(value);
        }

        public bool Verify(string hash, string value)
        {
            return Argon2.Verify(hash, value);
        }
    }
}
