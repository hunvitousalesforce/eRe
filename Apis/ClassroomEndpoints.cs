﻿using System.Reflection.Metadata.Ecma335;
using eRe.Dto;
using eRe.Repository;

namespace eRe;

public static class ClassroomEndpoints
{
    public static void MapClassroomEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/", async (IClassroomRepository service, ClassroomDto classDto) =>
        {
            var result = new Dto.Response();
            result = await service.CreateAsync(classDto);
            return result.Success == true ? Results.Created("/classroom", result) : Results.BadRequest(result);
        });

        app.MapGet("/", async (IClassroomRepository service, string ownerId) =>
        {
            List<Classroom.Classroom> result = [];
            try
            {
                result = await service.GetAllAsync(ownerId);
            }
            catch
            {
                throw;
            }
            return result;
        });

        app.MapPost("/{classroomId}/enroll", async (IClassroomRepository service, string classroomId, List<string> studentIds) =>
        {
            EnrollResult result;
            try
            {
                result = await service.EnrollStudents(classroomId, studentIds);

            }
            catch
            {
                throw;
            }
            return Results.Ok(result);
        });

        app.MapGet("/{classroomId}/enroll", async (IClassroomRepository service, string classroomId) =>
        {
            var result = new Response();
            result = await service.GetEnrollStudentAsync(classroomId);
            return result.Success == true ? Results.Ok(result) : Results.BadRequest(result);
        });

        app.MapPost("/{classroomId}/subjectItem", async (IClassroomRepository service, string classroomId, SubjectItemDto dto) =>
        {
            var result = new Response();

            result = await service.AddSubjectItemAsync(classroomId, dto);

            return result.Success == true ? Results.Ok(result) : Results.BadRequest(result);
        });

        app.MapGet("/{classroomId}/subjectItem", async (IClassroomRepository service, string classroomId) =>
        {
            var result = new Dto.Response();
            result = await service.GetSubjectItemsAsync(classroomId);
            return Results.Ok(result);
        });

        app.MapPost("/{teacherId}/report", async (IReportRepository service, string teacherId, ReportDto reportDto) =>
        {
            var result = new Response();
            result = await service.CreateAsync(teacherId, reportDto);
            return result.Success == true ? Results.Created("/report", result) : Results.BadRequest(result);
        });

        app.MapGet("/{classroomId}/reports", async (IReportRepository service, string classroomId, MonthOfYear? month) =>
        {
            var result = new Response();
            result = await service.GetAllAsync(classroomId, month);
            return Results.Ok(result);
        });


        app.MapGet("/subjects", async (IClassroomRepository service) =>
        {
            var result = await service.GetSubjectsAsync();
            return Results.Ok(result);
        });

        app.MapGet("/months", async (IClassroomRepository service) =>
        {
            var result = await service.GetMonthsAsync();
            return Results.Ok(result);
        });
    }

}
