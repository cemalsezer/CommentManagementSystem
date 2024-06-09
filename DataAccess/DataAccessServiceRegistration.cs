using Castle.Core.Configuration;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CommentManagemenContext>(options => options.UseSqlServer(configuration.GetConnectionString("CommentManagement")));

            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IOperationClaimDal, EfOperationClaimDal>();
            services.AddScoped<IUserOperationClaimDal, EfUserOperationClaimDal>();
            services.AddScoped<IAssignmentDal, EfAssignmentDal>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IUserAssignmentDal, EfUserAssignmentDal>();

            return services;
        }
    }
}
