using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using TeaShop.Core.Commands.Users.CreateUserCommand;
using TeaShop.Core.Commands.Users.DeleteUserCommand;
using TeaShop.Core.Commands.Users.UpdateUserCommand;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.User;
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
            var usersDto = _mapper.Map<List<UserDTO_Id>>(users);

            return Ok(usersDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _mediator.Send(new GetUserQuery { Id = id });
            var userDto = _mapper.Map<UserDTO_Id>(user);

            return Ok(userDto);
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] UserDTO userDTO)
        {
            var user = await _mediator.Send(new CreateUserCommand
            {
                Id = new Guid(),
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password,
                Address = new Address
                {
                    Id = new Guid(),
                    City = userDTO.Address.City,
                    Street = userDTO.Address.Street,
                    Number = userDTO.Address.Number
                }
            });

            var result = CreatedAtAction(nameof(GetUser), new { id = _mapper.Map<UserDTO, User>(userDTO).Id }, user);
            return result;
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UserDTO userDTO)
        {
            var user = await _mediator.Send(new UpdateUserCommand
            {
                Id = id,
                User = new User
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Password = userDTO.Password,
                    Address = new Address
                    {
                        City = userDTO.Address.City,
                        Street = userDTO.Address.Street,
                        Number = userDTO.Address.Number
                    }
                }
            });

            var result = CreatedAtAction(nameof(GetUser), new { id = _mapper.Map<UserDTO, User>(userDTO).Id }, user);
            return result;
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var users = await _mediator.Send(new DeleteUserCommand { Id = id });

            return Ok();
        }
    }
}
