using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using TechGuide.Models;

namespace TechGuide.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepID { get; set; }
        [StringLength(50)]
        public string? DepName { get; set; }
        [ForeignKey("Subjects")]
        public int SubCode { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}

//public static class DepartmentEndpoints
//{
//	public static void MapDepartmentEndpoints (this IEndpointRouteBuilder routes)
//    {
//        var group = routes.MapGroup("/api/Department").WithTags(nameof(Department));

//        group.MapGet("/", async (TechGuideDbContext db) =>
//        {
//            return await db.Departments.ToListAsync();
//        })
//        .WithName("GetAllDepartments")
//        .WithOpenApi();

//        group.MapGet("/{id}", async Task<Results<Ok<Department>, NotFound>> (int depid, TechGuideDbContext db) =>
//        {
//            return await db.Departments.AsNoTracking()
//                .FirstOrDefaultAsync(model => model.DepID == depid)
//                is Department model
//                    ? TypedResults.Ok(model)
//                    : TypedResults.NotFound();
//        })
//        .WithName("GetDepartmentById")
//        .WithOpenApi();

//        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int depid, Department department, TechGuideDbContext db) =>
//        {
//            var affected = await db.Departments
//                .Where(model => model.DepID == depid)
//                .ExecuteUpdateAsync(setters => setters
//                  .SetProperty(m => m.DepID, department.DepID)
//                  .SetProperty(m => m.DepName, department.DepName)
//                  .SetProperty(m => m.SubCode, department.SubCode)
//                  );
//            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
//        })
//        .WithName("UpdateDepartment")
//        .WithOpenApi();

//        group.MapPost("/", async (Department department, TechGuideDbContext db) =>
//        {
//            db.Departments.Add(department);
//            await db.SaveChangesAsync();
//            return TypedResults.Created($"/api/Department/{department.DepID}",department);
//        })
//        .WithName("CreateDepartment")
//        .WithOpenApi();

//        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int depid, TechGuideDbContext db) =>
//        {
//            var affected = await db.Departments
//                .Where(model => model.DepID == depid)
//                .ExecuteDeleteAsync();
//            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
//        })
//        .WithName("DeleteDepartment")
//        .WithOpenApi();
//    }
//}}
