using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ShareConfigsDemo.Core;

namespace ShareConfigsDemo.Web.Pages
{
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private IConfigurationRoot _configRoot;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configRoot)
    {
        _logger = logger;
        _configRoot = (IConfigurationRoot)configRoot;

    }

    public string? Key1ValueFromConfigHelper { get; set; }
    public string? Key1ValueFromAppConfig { get; set; }

    public void OnGet()
    {
        var config = ConfigHelper.Load();
        Key1ValueFromConfigHelper = config.GetSection("Key1").Value;

        Key1ValueFromAppConfig = _configRoot.GetSection("Key1").Value;
    }
}
}