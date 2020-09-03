using System.Linq;

namespace Zeats.Legacy.IP
{
    public static class IpValidator
    {
        public static bool IsIpV4(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                return false;

            var values = ip.Split('.');

            return values.Length == 4 && values.All(r => byte.TryParse(r, out _));
        }
    }
}