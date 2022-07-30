// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace course.Pages.CoursePages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using course.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\CourseListData.razor"
using CourseModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\CourseListData.razor"
using CourseBusnies.Contracts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/courseListData")]
    public partial class CourseListData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\CourseListData.razor"
      

    private IEnumerable<CourseDto> CourseModelList { get; set; } = new List<CourseDto>();
    public string ErrorMessage { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var data = await _courseRepository.GetAllCourse();
        if (!data.IsSucces)
        {
            ErrorMessage = data.Message;
        }

        else
        {
            CourseModelList = data.Data;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseRepository _courseRepository { get; set; }
    }
}
#pragma warning restore 1591