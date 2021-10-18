using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace TheBootstrapTheme.OrchardCore
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static readonly ResourceManifest _manifest = new();

        static ResourceManagementOptionsConfiguration()
        {
            _manifest
                .DefineStyle("TheBootstrapTheme-bootstrap-oc")
                .SetUrl("~/TheBootstrapTheme/css/bootstrap-oc.min.css", "~/TheBootstrapTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("navbar-top-fixed")
                .SetUrl("~/TheBootstrapTheme/css/navbar-top-fixed.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("sticky-footer")
                .SetUrl("~/TheBootstrapTheme/css/sticky-footer.css")
                .SetVersion("1.0.0");
        }

        public void Configure(ResourceManagementOptions options) => options.ResourceManifests.Add(_manifest);
    }
}
