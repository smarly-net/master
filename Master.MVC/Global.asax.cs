using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace Master.MVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory1());

//            var f = new DefaultControllerFactory();

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }

    public class DefaultControllerFactory1 : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var controller = base.CreateController(requestContext, controllerName);
            return controller;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            var controllerInstance = base.GetControllerInstance(requestContext, controllerType);
            return controllerInstance;
        }

        protected override SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, Type controllerType)
        {
            var controllerSessionBehavior = base.GetControllerSessionBehavior(requestContext, controllerType);
            return controllerSessionBehavior;
        }

        protected override Type GetControllerType(RequestContext requestContext, string controllerName)
        {
            var controllerType = base.GetControllerType(requestContext, controllerName);
            return controllerType;
        }

        public override void ReleaseController(IController controller)
        {
            base.ReleaseController(controller);
        }
    }
}