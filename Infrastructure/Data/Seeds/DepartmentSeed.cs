using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Data;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Seeds
{
    public class DepartmentSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Departments.Any())
                {
                    var depsData = File.ReadAllText("../Infrastructure/Data/SeedData/departments.json");
                    var deps = JsonSerializer.Deserialize<List<Department>>(depsData);

                    foreach (var dep in deps)
                    {
                        context.Departments.Add(dep);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch (System.Exception ex)
            {
                
                var logger = loggerFactory.CreateLogger<DepartmentSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}