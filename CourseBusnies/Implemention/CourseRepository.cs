using AutoMapper;
using CourseBusnies.Contracts;
using CourseDataAccess.Data;
using CourseModels;
using CouseCommon;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseBusnies.Implemention
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseContext _Ctx;
        private readonly IMapper _mapper;

        public CourseRepository(CourseContext Ctx, IMapper mapper)
        {
            _Ctx = Ctx;
            _mapper = mapper;
        }

        public async Task<Result<CourseDto>> CreateCourse(CourseDto courseDto)
        {
            var course = _mapper.Map<CourseDto, Course>(courseDto);

            var addedCourse = await _Ctx.Courses.AddAsync(course);

            await _Ctx.SaveChangesAsync();
            var returnData = _mapper.Map<Course, CourseDto>(addedCourse.Entity);
            return new Result<CourseDto>(true, ReusltConstant.RecordCreateSuccesfully, returnData);


        }

        public async Task<Result<int>> DeleteeCourse(int courseId)
        {

            var coursDetails = await _Ctx.Courses.FindAsync(courseId);
            if (coursDetails != null)
            {
                _Ctx.Courses.Remove(coursDetails);
                var result = await _Ctx.SaveChangesAsync();
                return new Result<int>(true, ReusltConstant.RecordRemoveSuccesfully, result);
            }

            return new Result<int>(false, ReusltConstant.RecordRemoveNotSuccesfully);

        }

        public async Task<Result<IEnumerable<CourseDto>>> GetAllCourse()
        {
            try
            {
                var courseDtos = _mapper.Map<IEnumerable<Course>, IEnumerable<CourseDto>>(_Ctx.Courses);
                return new Result<IEnumerable<CourseDto>>(true, ReusltConstant.RecordFound, courseDtos, courseDtos.ToList().Count);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<CourseDto>>(false, ReusltConstant.RecordNotFound);


            }
        }

        public async Task<Result<CourseDto>> GetCourse(int courseId)
        {
            try
            {
                var data = await _Ctx.Courses.FirstOrDefaultAsync(X => X.Id == courseId);
                var retrunData = _mapper.Map<Course, CourseDto>(data);
                return new Result<CourseDto>(true, ReusltConstant.RecordFound, retrunData);
            }
            catch (Exception)
            {

                return new Result<CourseDto>(false, ReusltConstant.RecordNotFound);
            }
        }

        public async Task<Result<CourseDto>> UpdateCourse(int courseId, CourseDto courseDto)
        {
            try
            {
                if (courseId == courseDto.Id)
                {
                    var coursDetails = await _Ctx.Courses.FindAsync(courseId);
                    var course = _mapper.Map<CourseDto, Course>(courseDto, coursDetails);
                    course.UpdateBy = "ceyda";
                    course.UpdateDate = DateTime.Now;
                    var updateCourse = _Ctx.Courses.Update(course);
                    await _Ctx.SaveChangesAsync();
                    var returnData = _mapper.Map<Course, CourseDto>(updateCourse.Entity);
                    return new Result<CourseDto>(true, ReusltConstant.RecordUpdateSuccesfully, returnData);

                }

                else
                {
                    return new Result<CourseDto>(false, ReusltConstant.RecordUpdateNotSuccesfully);
                }
            }
            catch (Exception)
            {
                return new Result<CourseDto>(false, ReusltConstant.RecordUpdateNotSuccesfully);

            }
        }

        public Task<Result<CourseDto>> UpdateCourse(CourseDto courseDto)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<CourseDto>> UpdateCourseImage(int courseId, string imagePath)
        {
            try
            {
                if (courseId > 0)
                {
                    var coursDetails = await _Ctx.Courses.FindAsync(courseId);

                    coursDetails.UpdateBy = "ceyda";
                    coursDetails.UpdateDate = DateTime.Now;
                    coursDetails.ImageUrl = imagePath;
                    var updateCourse = _Ctx.Courses.Update(coursDetails);
                    await _Ctx.SaveChangesAsync();
                    var returnData = _mapper.Map<Course, CourseDto>(updateCourse.Entity);
                    return new Result<CourseDto>(true, ReusltConstant.RecordUpdateSuccesfully, returnData);

                }

                else
                {

                    return new Result<CourseDto>(false, ReusltConstant.RecordUpdateNotSuccesfully);
                }
            }


            catch (Exception)
            {
                return new Result<CourseDto>(false, ReusltConstant.RecordUpdateNotSuccesfully);

            }
        }



    }
}


