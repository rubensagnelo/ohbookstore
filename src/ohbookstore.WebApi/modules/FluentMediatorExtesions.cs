namespace WebApi.Modules.Common
{
	using ohbookstore.Application.Boundaries;
	using FluentMediator;
	using Microsoft.Extensions.DependencyInjection;

	/// <summary>
	///     Fluent Mediator.
	/// </summary>
	public static class FluentMediatorExtensions
	{
		/// <summary>
		///     Register Inputs dependencies.
		/// </summary>
		public static IServiceCollection AddMediator(this  IServiceCollection services)
		{
			//services.AddTransient

			//Mediatr
			////services.Madia
			////services.AddMediator(


			////services.AddFluentMediator(
			//services.AddMediator( builder =>
			//{
			//	builder.On<CloseAccountInput>().PipelineAsync()
			//			.Call<ICloseAccountUseCase>((handler, request) => handler.Execute(request));

			//		builder.On<DepositInput>().PipelineAsync()
			//			.Call<IDepositUseCase>((handler, request) => handler.Execute(request));

			//		builder.On<GetAccountInput>().PipelineAsync()
			//			.Call<IGetAccountUseCase>((handler, request) =>
			//				handler.Execute(request));

			//		builder.On<GetAccountsInput>().PipelineAsync()
			//			.Call<IGetAccountsUseCase>((handler, request) =>
			//				handler.Execute(request));

			//		builder.On<GetCustomerInput>().PipelineAsync()
			//			.Call<IGetCustomerUseCase>((handler, request) =>
			//				handler.Execute(request));

			//		builder.On<RegisterInput>().PipelineAsync()
			//			.Call<IRegisterUseCase>((handler, request) => handler.Execute(request));

			//		builder.On<TransferInput>().PipelineAsync()
			//			.Call<ITransferUseCase>((handler, request) => handler.Execute(request));

			//		builder.On<WithdrawInput>().PipelineAsync()
			//			.Call<IWithdrawUseCase>((handler, request) => handler.Execute(request));

			//		builder.On<GetAccountInput>().PipelineAsync("GetAccountDetailsV2")
			//			.Call<IGetAccountUseCaseV2>((handler, request) => handler.Execute(request));
			//	});

			return services;
		}
	}
}
