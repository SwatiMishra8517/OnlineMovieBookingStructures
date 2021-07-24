using System;
using OnlineMovieBooking.Domain.Repository;
using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Domain.Services.CinemaHallService;
using OnlineMovieBooking.Domain.Services.FeedbackService;
using OnlineMovieBooking.Domain.Services.MovieService;
using OnlineMovieBooking.Domain.Services.PaymentService;
using OnlineMovieBooking.Domain.Services.ShowService;
using OnlineMovieBooking.Domain.Services.ShowSeatService;
using OnlineMovieBooking.Domain.Services.UserService;


using Unity;

namespace OnlineMovieBooking
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            
            //Proxy
            container.RegisterType<IUserProxy, UserProxy>();
            container.RegisterType<IShowSeatProxy, ShowSeatProxy>();
            container.RegisterType<IShowProxy,ShowProxy>();
            container.RegisterType<IPaymentProxy, PaymentProxy>();
            container.RegisterType<IMovieProxy, MovieProxy>();
            container.RegisterType<IFeedbackProxy, FeedbackProxy>();
            container.RegisterType<ICinemaHallProxy, CinemaHallProxy>();

            //Reopsitory
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IShowSeatRepository, ShowSeatRepository>();
            container.RegisterType<IShowRepository, ShowRepository>();
            container.RegisterType<IPaymentRepository, PaymentRepository>();
            container.RegisterType<IMovieRepository, MovieRepository>();
            container.RegisterType<IFeedbackRepository, FeedbackRepository>();
            container.RegisterType<ICinemaHallRepository, CinemaHallRepository>();

            //Services
            container.RegisterType<ICinemaHallCommandService, CinemaHallCommandService>();
            container.RegisterType<ICinemaHallQueryService, CinemaHallQueryService>();
            container.RegisterType<IFeedbackCommandService, FeedbackCommandService>();
            container.RegisterType<IFeedbackQueryService, FeedbackQueryService>();
            container.RegisterType<IMovieCommandService, MovieCommandService>();
            container.RegisterType<IMovieQueryService, MovieQueryService>();
            container.RegisterType<IPaymentCommandService, PaymentCommandService>();
            container.RegisterType<IPaymentQueryService, PaymentQueryService>();
            container.RegisterType<IShowCommandService, ShowCommandService>();
            container.RegisterType<IShowQueryService, ShowQueryService>();
            container.RegisterType<IShowSeatCommandService, ShowSeatCommandService>();
            container.RegisterType<IShowSeatQueryService, ShowSeatQueryService>();
            container.RegisterType<IUserCommandService, UserCommandService>();
            container.RegisterType<IUserQueryService, UserQueryService>();
        }
    }
}