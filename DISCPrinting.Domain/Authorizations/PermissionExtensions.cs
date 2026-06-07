using DISCPrinting.Domain.Utils;
using System.Reflection;
using System.Security.Claims;

namespace DISCPrinting.Domain.Authorizations;

public static class PermissionExtensions
{
    public static PermissionDetail PermissionByCombinedCode(this string permissionCode, List<PermissionDetail> allPermission)
    {
        short valueOnly = -1;
        short.TryParse(permissionCode, out valueOnly);
        var allAcceptPermisison = allPermission.Where(x => x.Value == valueOnly || x.ModuleName + x.Value == permissionCode);
        if (allAcceptPermisison.Count() == 1)
            return allAcceptPermisison.First();
        return null;
    }

    public static List<PermissionDetail> SharedPermissions(string? moduleName)
    {
        return typeof(SharedPermission).AvailablePermissions(moduleName);
    }

    public static List<PermissionDetail> SystemPermissions()
    {
        List<PermissionDetail> result = new List<PermissionDetail>();
        foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.StartsWith(Helper.ConstantKey.ASSEMBLY_PREFIX)))
        {
            result.AddRange(GetAssemblyPermission(assembly));
        }
        return result.Distinct().ToList();
    }

    private static List<PermissionDetail> GetAssemblyPermission(Assembly assembly)
    {
        List<PermissionDetail> result = new List<PermissionDetail>();
        foreach (Type type in assembly.GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Permission))))
        {
            var permissionInType = type.AvailablePermissions();
            if (permissionInType.Any())
            {
                result.AddRange(permissionInType);

                if (type.BaseType.IsSubclassOf(typeof(Permission)))
                {
                    result.AddRange(type.BaseType.AvailablePermissions(permissionInType[0].ModuleName));
                }
            }
        }
        return result.Distinct().ToList();
    }

    private static List<PermissionDetail> AvailablePermissions(this Type permissionClass, string baseModule = "")
    {
        string moduleName = string.Empty;
        var allProperties = permissionClass.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                   .Select(f =>
                   {
                       if (f.Name == "Module")
                       {
                           moduleName = f.GetValue(permissionClass).ToString();
                           return null;
                       }
                       var attr = f.GetCustomAttribute<PermissionDetail>();
                       if (attr == null)
                           return null;
                       if (!int.TryParse(f.GetRawConstantValue().ToString(), out _))
                           return null;

                       attr.Name = f.Name;
                       attr.Value = (short)f.GetRawConstantValue();
                       return attr;
                   }).Where(x => x != null).ToList();
        if (!string.IsNullOrEmpty(moduleName) || !string.IsNullOrEmpty(baseModule))
            allProperties.ForEach(x => x.ModuleName = string.IsNullOrEmpty(baseModule) ? moduleName : baseModule);
        return allProperties;
    }

    public static List<(string group, List<PermissionDetail> permissionInGroup)> PermissionByGroup(this string module, List<PermissionDetail> allPermission)
    {
        var allPermissionInModule = allPermission.Where(x => x.ModuleName == module).ToList();
        var allGroup = allPermissionInModule.Select(x => x.GroupName).Distinct();
        List<(string, List<PermissionDetail>)> results = new List<(string, List<PermissionDetail>)>();
        foreach (var group in allGroup)
        {
            results.Add((group, allPermissionInModule.Where(x => x.GroupName == group).ToList()));
        }

        return results;
    }

    public static List<string> GetAllRoles(this IEnumerable<Claim> claims)
    {
        var results = new List<string>();
        if (claims == null)
            return results;
        return claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).ToList();
    }

    public static List<(string name, string module, string role)> GetExtratedRoles(this IEnumerable<Claim> claims)
    {
        var results = new List<(string, string, string)>();
        if (claims == null)
            return results;
        var roleNameList = claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).ToList();
        roleNameList.ForEach(roleName =>
        {
            var ectractedRoleName = roleName.ExtractRoleName();
            if (ectractedRoleName != null)
                results.Add(ectractedRoleName.Value);
        });
        return results;
    }

    public static (string name, string module, string role)? ExtractRoleName(this string roleName)
    {
        if (string.IsNullOrEmpty(roleName))
            return null;
        var roleNameSeparated = roleName.Split('.');
        if (roleNameSeparated.Length >= 2)
        {
            return (roleName, roleNameSeparated[1], roleNameSeparated.Length >= 3 ? roleNameSeparated[2] : "");
        }
        return null;
    }

    public static string EncodePermission(this string[] permissionNames, string moduleName, List<PermissionDetail> allPermission)
    {
        return string.Join("", allPermission.Where(x => x.ModuleName == moduleName && permissionNames.Contains(x.Name)).Select(x => Convert.ToChar(x.Value).ToString()));
    }
}
