using System;
using System.Collections.Generic;
using System.Text;

namespace OpenStack.NetCoreSwiftClient.Infrastructure.Models
{
    public class SwiftAuthV2Request
    {
        public SwiftAuthV2Request(string name, string password, IScopeDescriptorObject scope = null)
        {
            Auth = new AuthObject()
            {
                PasswordCredentials = new UserObject()
                {
                    Username = name,
                    Password = password,
                },
                TenantName = name
            };
        }

        public AuthObject Auth { get; set; }

        public class AuthObject
        {
            public UserObject PasswordCredentials { get; set; }
            public string TenantName { get; set; }
            //public ScopeObject Scope { get; set; }
        }
        public class IdentityObject
        {
            public PasswordObject Password { get; set; }
            public TokenObject Token { get; set; }
        }
        public class PasswordObject
        {
            public UserObject User { get; set; }
        }
        public class TokenObject
        {
            public string Id { get; set; }
        }
        public class UserObject
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public DomainObject Domain { get; set; }

        }
        public class DomainObject : IScopeDescriptorObject
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class ScopeObject
        {
            public ScopeObject(IScopeDescriptorObject scope = null)
            {
                System = scope as SystemObject;
                Project = scope as ProjectObject;
                Domain = scope as DomainObject;
            }

            public SystemObject System { get; set; }
            public ProjectObject Project { get; set; }
            public DomainObject Domain { get; set; }
        }
        public interface IScopeDescriptorObject { }
        public class SystemObject : IScopeDescriptorObject
        {
            public bool? All { get; set; }
        }
        public class ProjectObject : IScopeDescriptorObject
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public DomainObject Domain { get; set; }
        }
    }

}
