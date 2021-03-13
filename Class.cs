using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class Class
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Access
    {
        public bool manageGroupMembership { get; set; }
        public bool view { get; set; }
        public bool mapRoles { get; set; }
        public bool impersonate { get; set; }
        public bool manage { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public object createdTimestamp { get; set; }
        public string username { get; set; }
        public bool enabled { get; set; }
        public bool totp { get; set; }
        public bool emailVerified { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<string> disableableCredentialTypes { get; set; }
        public List<string> requiredActions { get; set; }
        public int notBefore { get; set; }
        public Access access { get; set; } 
    }
}
