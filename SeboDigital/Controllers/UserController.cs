using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeboDigital.Data;
using SeboDigital.Data.Dtos;
using SeboDigital.Models;

namespace SeboDigital.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private ApplicationDbContext _context;
    private IMapper _mapper;
    public UserController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        _context.Users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, userDto);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }
        var readUserDto = _mapper.Map<ReadUserDto>(user);
        return Ok(readUserDto);
    }
}
