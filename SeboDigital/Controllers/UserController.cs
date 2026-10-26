using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeboDigital.Data;
using SeboDigital.Data.Dtos;
using SeboDigital.Models;

namespace SeboDigital.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private ApplicationDbContext _context;
    private IMapper _mapper;
    public UserController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IActionResult CreateUser(CreateUserDto userDto)
    {
        var user = _mapper.Map<User>(userDto);
        _context.Users.Add(user);
        _context.SaveChanges();
        var readUserDto = _mapper.Map<ReadUserDto>(user);
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, readUserDto);
    }

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
