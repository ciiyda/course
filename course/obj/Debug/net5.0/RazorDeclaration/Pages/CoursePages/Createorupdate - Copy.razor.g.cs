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
#line 13 "C:\Users\Lenovo\source\repos\Course\course\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\Createorupdate - Copy.razor"
using CourseModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\Createorupdate - Copy.razor"
using CourseBusnies.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\Createorupdate - Copy.razor"
using course.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/course/Createorupdate")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/course/edit/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/course/delete/{Id:int}")]
    public partial class Createorupdate___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Lenovo\source\repos\Course\course\Pages\CoursePages\Createorupdate - Copy.razor"
       

    [Parameter]
    public int? Id { get; set; }

    private string Title { get; set; }
    private CourseDto courseModel { get; set; } = new CourseDto();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            Title = "Update";
            var data = await _courseRepository.GetCourse((int)Id);
            courseModel = data.Data;
        }
    }

    private async Task CoureCreateOrUpdate()

    {

        try
        {
            if (Id != null)
            {
                var updateData = await _courseRepository.UpdateCourse((int)Id, courseModel);
                if (updateData.IsSucces)

                    await _jsruntime.ToastrSuccess(updateData.Message);

                else
                    await _jsruntime.ToastrError(updateData.Message);

            }
            else
            {
                var created = await _courseRepository.CreateCourse(courseModel);
                if (created.IsSucces)

                    await _jsruntime.ToastrSuccess(created.Message);
                else
                    await _jsruntime.ToastrError(created.Message);

            }
        }
        catch (Exception ex)
        {

            await _jsruntime.ToastrError(ex.Message.ToString());
        }

    }



    //private async Task AddPicture(InputFileChangeEventArgs file)
    //{
    //    var fileName = file.File;

    //    if (fileName != null)
    //    {
    //        var data = await _fileUpload.UploadFile(fileName);
    //        var updateCourse = await _courseRepository.UpdateCourseImage((int)Id, data);

    //        if (updateCourse.IsSucces)

    //            await _jsruntime.ToastrSuccess(updateCourse.Message);

    //        else
    //            await _jsruntime.ToastrError(updateCourse.Message);

    //    }
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload _fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsruntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseRepository _courseRepository { get; set; }
    }
}
#pragma warning restore 1591
