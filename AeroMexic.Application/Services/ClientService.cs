

using AeroMexic.Application.DTOs;
using AeroMexic.Domain.Entities;

namespace AeroMexic.Application.Services
{
    public class ClientService
    {
        public async Task<User> GetClientById(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Invalid client ID.");
            }

            var query = new ClientDto();

            var result = new User
            {
                Id = query.Id,
                Name = query.Name,
                PaternalLastName = query.LastName,
                Email = query.Email,
                Password = query.Password,
                Role_Id = query.Role_Id
            };

            return await Task.FromResult(result);
        }
    }
}
