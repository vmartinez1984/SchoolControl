using Microsoft.AspNetCore.Mvc;
using SchoolControl.Core.Dtos;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IBusinessLayer _businessLayer;

    public StudentsController(
        IBusinessLayer businessLayer
    )
    {
        _businessLayer = businessLayer;
    }

    [HttpGet("{studentId}")]
    public async Task<IActionResult> Get(string studentId)
    {
        StudentDto studentDto;

        studentDto = await _businessLayer.Student.GetAsync(studentId);

        return Ok(studentDto);
    }

    [HttpPost]
    public async Task<IActionResult> Post(StudentDtoIn studentDtoIn)
    {
        string id;

        id = await _businessLayer.Student.AddAsync(studentDtoIn);



        return Created($"/Students/{id}", new { Id = id });
    }

    [HttpPut]
    public async Task<IActionResult> Put(string studentId, StudentDtoIn studentDtoIn)
    {
        await _businessLayer.Student.UpdateAsync(studentId, studentDtoIn);

        return NoContent();
    }

    [HttpGet("{groupId}/Group")]
    public async Task<IActionResult> GetByGroup(string groupId)
    {
        List<StudentDto> list;

        list = await _businessLayer.Student.GetByGroupAsync(groupId);

        return Ok(list);
    }

    [HttpGet("{courseId}/Course")]
    public async Task<IActionResult> GetByCourse(string courseId)
    {
        List<StudentDto> list;

        list = await _businessLayer.Student.GetByCourseAsync(courseId);

        return Ok(list);
    }
}