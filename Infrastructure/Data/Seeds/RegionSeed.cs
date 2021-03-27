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
    public class RegionSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.Regions.Any())
                {
                    var regionsData = File.ReadAllText("../Infrastructure/Data/SeedData/regions.json");
                    var regions = JsonSerializer.Deserialize<List<Region>>(regionsData);

                    foreach (var region in regions)
                    {
                        context.Regions.Add(region);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch (System.Exception ex)
            {
                
                var logger = loggerFactory.CreateLogger<RegionSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}