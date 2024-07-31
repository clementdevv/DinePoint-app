// namespace DinePoint.Api.Common.Mapping
// {
//     public class AuthenticationMappingConfig : IRegister
//     {
//         public void Register(TypeAdapterConfig config)
//         {
//             config.NewConfig<RegisterRequest, RegisterCommand>();
//             config.NewConfig<LoginRequest, LoginQuery>();
//             config.NewConfig<AuthenticationResult, AuthenticationResponse>()
//             // .Map(dest => dest.Token, scr => scr.Token)
//             .Map(dest => dest, src => src.User);
//         }
//     }
// }