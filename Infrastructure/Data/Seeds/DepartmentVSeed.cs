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
    public class DepartmentVSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.DepartmentVs.Any())
                {
                    var depsVData = File.ReadAllText("../Infrastructure/Data/SeedData/departmentVs.json");
                    var depsV = JsonSerializer.Deserialize<List<DepartmentV>>(depsVData);

                    foreach (var depV in depsV)
                    {
                        context.DepartmentVs.Add(depV);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch (System.Exception ex)
            {
                
                var logger = loggerFactory.CreateLogger<DepartmentVSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}