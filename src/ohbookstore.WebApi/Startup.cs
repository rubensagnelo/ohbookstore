using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ohbookstore.Application.UseCases;
using ohbookstore.Application.Boundaries;

namespace ohbookstore.WebApi
{
	public sealed  class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});


			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});

			//configurarServicos();
		}

		//public void AddUseCases(IServiceCollection services) => services.

	}



	public static class AppExtensions {


		private static IServiceCollection AddUseCases(this IServiceCollection services)
		{
			//Injeção das dependências
			services.AddScoped<ICadastrarLivroUseCase, CadastrarLivroUseCase>();
			services.AddScoped<IEditarLivroUseCase, EditarLivroUseCase>();
			services.AddScoped<IExcluirLivroUseCase, ExcluirLivroUseCase>();
			services.AddScoped<IGerarPedidoUseCase, GerarPedidoUseCase>();
			services.AddScoped<IIncluirLivroCarrinhoUseCase, IncluirLivroNoCarrinhoUseCase>();
			services.AddScoped<IRemoverLivroCarrinhoUseCase, RemoverLivroDoCarrinhoUseCase>();


			return services;
		}


	}

}
