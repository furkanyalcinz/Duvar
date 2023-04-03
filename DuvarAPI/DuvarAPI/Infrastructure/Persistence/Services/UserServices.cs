using Application.Repositories.UserRepository;
using Domain.Common.ReturnTypes;
using Domain.Entities;


namespace Persistence.Services
{
    public class UserServices:IUserService
    {
        readonly IUserReadRepository _userReadRepository;
        readonly IUserWriteRepository _userWriteRepository;
        public UserServices(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        public async Task<Result> Register(User newUser)
        {
            if(newUser.Name==null || newUser.Name.Length<2)
            {
                return new ErrorResult("User name cannot be empty or les than 3 character");
            }
            if(newUser.Email==null || newUser.Email.Length<6 || !newUser.Email.Contains('@'))
            {
                return new ErrorResult("Email cannot be null and the length can not be under 7 and it shoud contains @");
            }
            if(newUser.Password == null || newUser.Password.Length < 5)
            {
                return new ErrorResult("Password cannot be null and Its length cannot be under 6");
            }
            await _userWriteRepository.AddAsync(newUser);
            await _userWriteRepository.SaveAsync();
            return new SuccessResult();
        }

        

        

    }
}
