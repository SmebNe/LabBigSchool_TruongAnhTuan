using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigSchool_TruongAnhTuan.Startup))]
namespace LabBigSchool_TruongAnhTuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
