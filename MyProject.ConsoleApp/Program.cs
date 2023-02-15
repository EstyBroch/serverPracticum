using MyProject.Mock;
using MyProject.Repositories.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;
using System;

namespace MyProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var context = new MockContext();
            //Console.WriteLine("Roles:");
            //context.Roles.ForEach(role => Console.WriteLine(role.ToString()));
            //Console.WriteLine("Permissions:");
            //context.Permissions.ForEach(per => Console.WriteLine(per.ToString()));
            //Console.WriteLine("Claims:");
            //context.Claims.ForEach(claim => Console.WriteLine(claim.ToString()));

            //var roleRepository = new RoleRepository(context);
            //roleRepository.Add(4, "Mr. Inbar", "developer");

            //var permissionRepository = new PermissionRepository(context);
            //permissionRepository.Add(4, "UPDATE_CLAIM", "Can update claim in claims' list");

            //var claimRepository= new ClaimRepository(context);
            //claimRepository.Add(4,4,4, ePolicy.Allow);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("After changes:");
            Console.ForegroundColor = ConsoleColor.White ;
            Console.WriteLine();
            Console.WriteLine("Roles:");
            context.Roles.ForEach(role => Console.WriteLine(role.ToString()));
            Console.WriteLine("Permissions:");
            context.Permissions.ForEach(per => Console.WriteLine(per.ToString()));
            Console.WriteLine("Claims:");
            context.Claims.ForEach(claim => Console.WriteLine(claim.ToString()));
            
            //roleRepository.Update(new Role() {Id= 4,Name="User",Description="use the website"});
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("After changes:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Roles:");
            context.Roles.ForEach(role => Console.WriteLine(role.ToString()));
        }
    }
}
