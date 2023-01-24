using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fvo.Store.Domain.Helpers
{
    public static class StringHelpers
    {
        public static string Ecrypt(this string senha)
        {
            var salt = "| F20DDC9E68614F0EAB8D8D430E2346EC27E9CB3C2B164192A392D32A6FDD45B0";
            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
