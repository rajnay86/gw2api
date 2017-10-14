namespace GW2API.Common
{
    public class InvalidKeyException : System.Exception
    {
        public InvalidKeyException(PermissionValues value) : base($"Key is invalid or does not have {value} permissions") { }
    }
}
