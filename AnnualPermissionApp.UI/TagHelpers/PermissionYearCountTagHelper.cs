using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;

namespace AnnualPermissionApp.UI.TagHelpers
{
    public class PermissionYearCountTagHelper:TagHelper
    {
        private readonly IPermissionService _permissionService;
        public PermissionYearCountTagHelper(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        public int EmployeeId { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            int number = await _permissionService.CountThisYearPermissions(EmployeeId);
            var html=$"<td>{number} GÜN</td>";
            output.Content.SetHtmlContent(html);
        }
    }
}