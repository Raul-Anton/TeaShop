using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Commands.Users.UpdateUserCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.User.Get;
using TeaShop.Core.DTO.User.Post;
using TeaShop.Core.Queries.Users.GetUserQuery;
using TeaShop.Core.Queries.Users.GetUsersQuery;

namespace TeaShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _mediator.Send(new GetUsersQuery());
            var usersDto = _mapper.Map<List<GetUserDto>>(users);

            return Ok(usersDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _mediator.Send(new UpdateUserQuery { Id = id });
            var userDto = _mapper.Map<GetUserDto>(user);

            return Ok(userDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] PostUserDto postUserDto)
        {
            var user = await _mediator.Send(new CreateUserCommand
            {
                Id = new Guid(),
                Name = postUserDto.Name,
                Email = postUserDto.Email,
                Password = postUserDto.Password,
                Address = new Address
                {
                    Id = new Guid(),
                    City = postUserDto.Address.City,
                    Street = postUserDto.Address.Street,
                    Number = postUserDto.Address.Number
                }
            });

            var result = CreatedAtAction(nameof(GetUser), new { id = _mapper.Map<PostUserDto, User>(postUserDto).Id }, user);
            return result;
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] PostUserDto postUserDto)
        {
            var user = await _mediator.Send(new UpdateUserCommand
            {
                Id = id,
                User = new User
                {
                    Name = postUserDto.Name,
                    Email = postUserDto.Email,
                    Password = postUserDto.Password,
                    Address = new Address
                    {
                        City = postUserDto.Address.City,
                        Street = postUserDto.Address.Street,
                        Number = postUserDto.Address.Number
                    }
                }
            });

            var result = CreatedAtAction(nameof(GetUser), new { id = _mapper.Map<PostUserDto, User>(postUserDto).Id }, user);
            return result;
        }

    }
}
